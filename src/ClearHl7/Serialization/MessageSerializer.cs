using System;
using System.Collections.Generic;
using System.Globalization;
using ClearHl7.Helpers;

namespace ClearHl7.Serialization
{
    /// <summary>
    /// Provides serialization methods for HL7 Messages.
    /// </summary>
    public static class MessageSerializer
    {
        /// <summary>
        /// Parses the text representing a single Message value into an instance of the appropriate type based upon the HL7 version provided in delimitedString.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>An instance of type Message.</returns>
        /// <exception cref="ArgumentException">Unable to determine the HL7 version provided in delimitedString.</exception>
        /// <exception cref="ArgumentNullException">delimitedString is null.</exception>
        public static IMessage Deserialize(string delimitedString)
        {
            if (string.IsNullOrEmpty(delimitedString))
            {
                throw new ArgumentNullException(nameof(delimitedString), $"{ nameof(delimitedString) } is null.");
            }

            // Detect HL7 version
            Hl7Version version = MessageHelper.DetectVersion(delimitedString);

            // Return
            return version switch
            {
                Hl7Version.V230 => Deserialize<V230.Message>(delimitedString),
                Hl7Version.V231 => Deserialize<V231.Message>(delimitedString),
                Hl7Version.V240 => Deserialize<V240.Message>(delimitedString),
                Hl7Version.V250 => Deserialize<V250.Message>(delimitedString),
                Hl7Version.V251 => Deserialize<V251.Message>(delimitedString),
                Hl7Version.V260 => Deserialize<V260.Message>(delimitedString),
                Hl7Version.V270 => Deserialize<V270.Message>(delimitedString),
                Hl7Version.V271 => Deserialize<V271.Message>(delimitedString),
                Hl7Version.V280 => Deserialize<V280.Message>(delimitedString),
                Hl7Version.V281 => Deserialize<V281.Message>(delimitedString),
                Hl7Version.V282 => Deserialize<V282.Message>(delimitedString),
                Hl7Version.V290 => Deserialize<V290.Message>(delimitedString),
                Hl7Version.None => throw new ArgumentException($"Unable to determine the HL7 version provided in { nameof(delimitedString) }.", nameof(delimitedString)),
                _ => throw new ArgumentException($"Unable to determine the HL7 version provided in { nameof(delimitedString) }.", nameof(delimitedString))
            };
        }

        /// <summary>
        /// Parses the text representing a single Message value into an instance of a specified type.
        /// </summary>
        /// <typeparam name="T">The target type of the string value.</typeparam>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="options">Optional parser options. If null, uses global defaults from ParserConfiguration.</param>
        /// <returns>An instance of type T.</returns>
        /// <exception cref="ArgumentException">
        /// The first segment in delimitedString is not the MSH segment.
        /// -or-
        /// delimitedString contains a segment string that does not begin with a valid segment ID.
        /// -or-
        /// delimitedString contains an incomplete segment string.
        /// </exception>
        /// <exception cref="ArgumentNullException">delimitedString is null.</exception>
        public static T Deserialize<T>(string delimitedString, ParserOptions options = null) where T : class, IMessage
        {
            if (string.IsNullOrEmpty(delimitedString))
            {
                throw new ArgumentNullException(nameof(delimitedString), $"{ nameof(delimitedString) } is null.");
            }

            // Resolve options - use provided or get from global defaults
            options ??= ParserConfiguration.DefaultOptions;

            // Create instance of the Message class
            T item = Activator.CreateInstance<T>();

            CultureInfo culture = CultureInfo.CurrentCulture;
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(new char[] { Consts.LineTerminator }, StringSplitOptions.RemoveEmptyEntries);
            List<ISegment> list = new();
            Type messageClass = item.GetType();

            if (segments.Length > 0)
            {
                if (!segments[0].StartsWith("MSH", StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException($"The first segment in { nameof(delimitedString) } is not the MSH segment.", nameof(delimitedString));
                }
            }

            // Process the first segment (expected: MSH)
            ISegment mshSegment = (ISegment)messageClass.Assembly.CreateInstance($"{ messageClass.Namespace }.Segments.MshSegment", false);
            if (segments.Length > 0)
            {
                list.Add(mshSegment);
                list[0].FromDelimitedString(segments[0]);
            }

            // Capture the encoding chars
            IMshSegment msh = (IMshSegment)mshSegment;
            Separators seps = new Separators().UsingInput($"{ msh.FieldSeparator }{ msh.EncodingCharacters }");

            // Process remaining segments
            for (int i = 1; i < segments.Length; i++)
            {
                string segmentString = segments[i];

                if (segmentString.Length < 3)
                {
                    // Segment string is incomplete - handle based on options
                    if (!HandleMalformedSegment(segmentString, i, options, "Incomplete segment string"))
                    {
                        throw new ArgumentException($"{ nameof(delimitedString) } contains an incomplete segment string.  '{ segmentString }' is invalid.", nameof(delimitedString));
                    }
                    continue; // Skip to next segment
                }

                // Instantiate the segment
                string id = segmentString.Substring(0, 3);
                object segment = null;

                // First try to create segment using SegmentFactory (for custom segments)
                Hl7Version version = GetVersionFromNamespace(messageClass.Namespace);
                ISegment customSegment = SegmentFactory.CreateSegment(id, version);
                if (customSegment != null)
                {
                    segment = customSegment;
                }
                else
                {
                    // Fall back to reflection for built-in segments
                    segment = messageClass.Assembly.CreateInstance($"{ messageClass.Namespace }.Segments.{ id.Substring(0, 1).ToUpper(culture) }{ id.Substring(1, 2).ToLower(culture) }Segment", false);
                }

                if (segment == null)
                {
                    // Segment string begins with an invalid segment ID - handle based on options
                    if (!HandleUnknownSegment(id, segmentString, i, options))
                    {
                        throw new ArgumentException($"{ nameof(delimitedString) } contains a segment string that does not begin with a valid segment ID.  '{ id }' is invalid.", nameof(delimitedString));
                    }
                    continue; // Skip to next segment
                }

                // Init segment properties, and add to collection
                try
                {
                    ISegment seg = (ISegment)segment;
                    seg.Ordinal = i;
                    seg.FromDelimitedString(segmentString, seps);
                    list.Add(seg);
                }
                catch (Exception ex)
                {
                    if (!HandleSegmentParseError(id, segmentString, i, options, ex))
                    {
                        throw; // Re-throw if options say to throw
                    }
                    // Otherwise continue parsing
                }
            }

            // Flush segment list
            item.Segments = list;

            // Return
            return item;
        }

        /// <summary>
        /// Converts the value of a specified Message into a string.
        /// </summary>
        /// <param name="message">The Message to convert.</param>
        /// <returns>A string.</returns>
        /// <exception cref="ArgumentNullException">value is null.</exception>
        public static string Serialize(IMessage message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message), $"{ nameof(message) } is null.");
            }

            return message.ToDelimitedString();
        }

        /// <summary>
        /// Extracts the HL7 version from a namespace string.
        /// </summary>
        /// <param name="namespaceName">The namespace (e.g., "ClearHl7.V281").</param>
        /// <returns>The corresponding Hl7Version enumeration value.</returns>
        private static Hl7Version GetVersionFromNamespace(string namespaceName)
        {
            if (string.IsNullOrEmpty(namespaceName))
            {
                return Hl7Version.None;
            }

            // Extract version from namespace like "ClearHl7.V281"
            int lastDotIndex = namespaceName.LastIndexOf('.');
            if (lastDotIndex >= 0 && lastDotIndex < namespaceName.Length - 1)
            {
                string versionString = namespaceName.Substring(lastDotIndex + 1);
                if (Enum.TryParse<Hl7Version>(versionString, out Hl7Version version))
                {
                    return version;
                }
            }

            return Hl7Version.None;
        }

        /// <summary>
        /// Handles an unknown segment based on parser options.
        /// </summary>
        /// <param name="id">The segment ID.</param>
        /// <param name="segmentString">The raw segment string.</param>
        /// <param name="ordinal">The line number/ordinal.</param>
        /// <param name="options">Parser options.</param>
        /// <returns>True if the segment was handled (skip/continue), false if should throw.</returns>
        private static bool HandleUnknownSegment(
            string id, 
            string segmentString, 
            int ordinal, 
            ParserOptions options)
        {
            switch (options.UnknownSegmentHandling)
            {
                case UnknownSegmentHandling.Throw:
                    return false; // Let caller throw exception

                case UnknownSegmentHandling.Skip:
                    options.AddWarning(new ParserWarning
                    {
                        Type = ParserWarningType.UnknownSegment,
                        SegmentId = id,
                        LineNumber = ordinal,
                        Message = $"Unknown segment '{id}' skipped",
                        RawSegment = segmentString
                    });
                    return true; // Handled - skip segment

                case UnknownSegmentHandling.CreateGeneric:
                    // TODO: Future enhancement - create UnknownSegment instance
                    // For now, we skip the segment and add a warning
                    options.AddWarning(new ParserWarning
                    {
                        Type = ParserWarningType.UnknownSegment,
                        SegmentId = id,
                        LineNumber = ordinal,
                        Message = $"Unknown segment '{id}' skipped (CreateGeneric not yet implemented)",
                        RawSegment = segmentString
                    });
                    return true; // Handled - skip for now

                default:
                    return false;
            }
        }

        /// <summary>
        /// Handles a malformed segment based on parser options.
        /// </summary>
        /// <param name="segmentString">The raw segment string.</param>
        /// <param name="ordinal">The line number/ordinal.</param>
        /// <param name="options">Parser options.</param>
        /// <param name="reason">The reason the segment is considered malformed.</param>
        /// <returns>True if the segment was handled (skip/continue), false if should throw.</returns>
        private static bool HandleMalformedSegment(
            string segmentString,
            int ordinal,
            ParserOptions options,
            string reason)
        {
            string segmentId = segmentString.Length >= 3 ? segmentString.Substring(0, 3) : "???";
            
            switch (options.MalformedSegmentHandling)
            {
                case MalformedSegmentHandling.Throw:
                    return false; // Let caller throw exception

                case MalformedSegmentHandling.Skip:
                    options.AddWarning(new ParserWarning
                    {
                        Type = ParserWarningType.MalformedSegment,
                        SegmentId = segmentId,
                        LineNumber = ordinal,
                        Message = $"Malformed segment skipped: {reason}",
                        RawSegment = segmentString
                    });
                    return true; // Handled - skip segment

                case MalformedSegmentHandling.BestEffort:
                    options.AddWarning(new ParserWarning
                    {
                        Type = ParserWarningType.MalformedSegment,
                        SegmentId = segmentId,
                        LineNumber = ordinal,
                        Message = $"Malformed segment - attempting best effort parse: {reason}",
                        RawSegment = segmentString
                    });
                    // For BestEffort, we allow parsing to continue
                    // The segment will be skipped if it's too short to parse
                    return true; // Handled - continue parsing

                default:
                    return false;
            }
        }

        /// <summary>
        /// Handles an error that occurred while parsing a segment.
        /// </summary>
        /// <param name="id">The segment ID.</param>
        /// <param name="segmentString">The raw segment string.</param>
        /// <param name="ordinal">The line number/ordinal.</param>
        /// <param name="options">Parser options.</param>
        /// <param name="ex">The exception that occurred.</param>
        /// <returns>True if the error was handled (skip/continue), false if should throw.</returns>
        private static bool HandleSegmentParseError(
            string id,
            string segmentString,
            int ordinal,
            ParserOptions options,
            Exception ex)
        {
            switch (options.MalformedSegmentHandling)
            {
                case MalformedSegmentHandling.Throw:
                    return false; // Let caller re-throw exception

                case MalformedSegmentHandling.Skip:
                case MalformedSegmentHandling.BestEffort:
                    options.AddWarning(new ParserWarning
                    {
                        Type = ParserWarningType.ParseError,
                        SegmentId = id,
                        LineNumber = ordinal,
                        Message = $"Error parsing segment '{id}': {ex.Message}",
                        RawSegment = segmentString,
                        Exception = ex
                    });
                    return true; // Handled - skip or use partial data

                default:
                    return false;
            }
        }

        /// <summary>
        /// Deserializes an HL7 message and returns the result with collected warnings.
        /// This method forces warning collection regardless of options settings.
        /// Thread-safe.
        /// </summary>
        /// <typeparam name="T">The message type.</typeparam>
        /// <param name="delimitedString">The HL7 message string.</param>
        /// <param name="options">Optional parser options. If null, uses global defaults.</param>
        /// <returns>A ParseResult containing the message and any warnings.</returns>
        public static ParseResult<T> DeserializeWithWarnings<T>(
            string delimitedString, 
            ParserOptions options = null
        ) where T : class, IMessage
        {
            // Clone options and force warning collection
            var localOptions = (options ?? ParserConfiguration.DefaultOptions).Clone();
            localOptions.CollectWarnings = true;
            
            // Parse the message
            var message = Deserialize<T>(delimitedString, localOptions);
            
            // Return result with warnings
            return new ParseResult<T>
            {
                Message = message,
                Warnings = localOptions.Warnings // Already an immutable snapshot
            };
        }
    }
}
