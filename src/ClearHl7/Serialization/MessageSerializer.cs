using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
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

                // Init segment properties, and add to collection.
                // Declare seg before the try block so the catch can inspect its partially-populated
                // state for BestEffort null-boundary detection.
                ISegment seg = (ISegment)segment;
                seg.Ordinal = i;
                try
                {
                    seg.FromDelimitedString(segmentString, seps);
                    list.Add(seg);
                }
                catch (Exception ex)
                {
                    if (options.MalformedSegmentHandling == MalformedSegmentHandling.BestEffort)
                    {
                        // BestEffort field-level recovery.
                        //
                        // Because FromDelimitedString assigns fields strictly in order, the
                        // partially-populated `seg` instance is a precise record of where parsing
                        // stopped: the bad field is the first position where fields[] contains a
                        // non-empty value but the corresponding property in `seg` is still null
                        // (the "null boundary").  We jump directly to that field and blank it —
                        // O(1) per bad field rather than a full linear scan.
                        //
                        // After blanking the bad field we retry from scratch with a fresh instance.
                        // If the retry succeeds we are done; if it fails the new partial instance
                        // exposes the next null boundary.  The loop continues until the segment
                        // parses completely or no boundary can be found (e.g. the bad field is
                        // already empty in the raw segment).
                        //
                        // Five independently bad fields → five warnings, one per blanked field.
                        // If the segment cannot be fully recovered, a single fallback warning is
                        // emitted (no FieldIndex/RawFieldValue) and the segment is dropped, which
                        // is identical to Skip behaviour.
                        string fieldSep = seps.FieldSeparator[0];
                        string[] fields = segmentString.Split(seps.FieldSeparator, StringSplitOptions.None);
                        bool recovered = false;
                        ISegment currentPartialSeg = seg;
                        var pendingWarnings = new List<(int FieldIndex, string RawFieldValue)>();

                        while (true)
                        {
                            int badFieldIdx = FindNullBoundaryFieldIndex(currentPartialSeg, fields);
                            if (badFieldIdx == -1)
                                break; // No null boundary found — cannot make further progress.

                            string originalValue = fields[badFieldIdx];
                            fields[badFieldIdx] = string.Empty;
                            string repairedString = string.Join(fieldSep, fields);

                            ISegment freshSeg = (ISegment)Activator.CreateInstance(segment.GetType());
                            if (freshSeg == null)
                                break;

                            freshSeg.Ordinal = i;

                            try
                            {
                                freshSeg.FromDelimitedString(repairedString, seps);

                                // Full recovery: emit one warning per blanked field then add segment.
                                pendingWarnings.Add((badFieldIdx, originalValue));
                                foreach (var (warnFieldIdx, warnRawValue) in pendingWarnings)
                                {
                                    options.AddWarning(new ParserWarning
                                    {
                                        Type = ParserWarningType.ParseError,
                                        SegmentId = id,
                                        LineNumber = i,
                                        Message = $"Segment '{id}' recovered via best-effort parse: field {warnFieldIdx} was blanked (original value preserved in {nameof(ParserWarning.RawFieldValue)})",
                                        RawSegment = segmentString,
                                        Exception = ex,
                                        FieldIndex = warnFieldIdx,
                                        RawFieldValue = warnRawValue
                                    });
                                }

                                list.Add(freshSeg);
                                recovered = true;
                                break;
                            }
                            catch
                            {
                                // Blanking this field revealed another bad field further along.
                                // Keep it blank, record it as pending, and locate the next boundary.
                                pendingWarnings.Add((badFieldIdx, originalValue));
                                currentPartialSeg = freshSeg;
                            }
                        }

                        if (!recovered)
                        {
                            // Full recovery was not possible — fall back to Skip behaviour.
                            options.AddWarning(new ParserWarning
                            {
                                Type = ParserWarningType.ParseError,
                                SegmentId = id,
                                LineNumber = i,
                                Message = $"Error parsing segment '{id}': {ex.Message}",
                                RawSegment = segmentString,
                                Exception = ex
                            });
                        }
                    }
                    else if (!HandleSegmentParseError(id, segmentString, i, options, ex))
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
                    // BestEffort behaves the same as Skip here because a segment shorter than
                    // 3 characters has no identifiable segment ID or fields to retry with;
                    // there is nothing useful to attempt a field-level recovery on.
                    return true; // Handled - continue parsing

                default:
                    return false;
            }
        }

        /// <summary>
        /// Identifies the 1-based index of the first bad field in a partially-parsed segment
        /// using the "null boundary" technique.  Because <see cref="ISegment.FromDelimitedString"/>
        /// processes fields sequentially, the number of non-null data properties in
        /// <paramref name="partialSeg"/> equals the number of non-empty fields that were
        /// successfully parsed before the exception was thrown.  The bad field is therefore
        /// the next (i.e. the <c>parsedCount + 1</c>th) non-empty field in
        /// <paramref name="fields"/>.
        /// </summary>
        /// <param name="partialSeg">A segment instance in a partially-populated state from a failed parse.</param>
        /// <param name="fields">The raw field values split from the original segment string.</param>
        /// <returns>The 1-based field index of the bad field, or -1 if no boundary can be found.</returns>
        private static int FindNullBoundaryFieldIndex(ISegment partialSeg, string[] fields)
        {
            // Count non-null nullable/reference-type data properties.  Non-nullable value types
            // (e.g. int, bool) default to 0/false which box to a non-null object, making them
            // unreliable as "was this field reached?" indicators, so they are excluded.
            int parsedCount = partialSeg.GetType()
                .GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                .Where(p => p.Name != nameof(ISegment.Id) && p.Name != nameof(ISegment.Ordinal))
                .Where(p => !p.PropertyType.IsValueType || Nullable.GetUnderlyingType(p.PropertyType) != null)
                .Count(p =>
                {
                    // Broad catch is intentional: property access for a heuristic count must
                    // never surface unexpected reflection exceptions to the caller.  Any error
                    // (e.g. a lazy IEnumerable whose getter throws on first access) is treated
                    // conservatively as "was assigned" so the bad-field index is not under-counted.
                    try { return p.GetValue(partialSeg) != null; }
                    catch { return true; }
                });

            // The bad field is the (parsedCount + 1)-th non-empty field in the raw segment.
            // Empty raw fields result in null via the segment's Length > 0 guard and are not
            // counted among the successfully-parsed fields, so they are skipped here too.
            int nonEmptyFieldsEncountered = 0;
            for (int fieldIdx = 1; fieldIdx < fields.Length; fieldIdx++)
            {
                if (string.IsNullOrEmpty(fields[fieldIdx])) continue;
                nonEmptyFieldsEncountered++;
                if (nonEmptyFieldsEncountered == parsedCount + 1)
                    return fieldIdx;
            }

            return -1; // No null boundary found (e.g. bad field is already empty in raw segment).
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
