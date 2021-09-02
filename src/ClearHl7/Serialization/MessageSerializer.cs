using System;
using System.Collections.Generic;
using System.Globalization;

namespace ClearHl7.Serialization
{
    /// <summary>
    /// Provides serialization methods for HL7 Messages.
    /// </summary>
    public static class MessageSerializer
    {
        /// <summary>
        /// Returns a new instance of type T with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>An instance of type T if delimitedString is not null or empty.  Otherwise, null.</returns>
        /// <exception cref="ArgumentException">
        /// The first segment in delimitedString is not the MSH segment.
        /// -or-
        /// delimitedString contains a segment string that does not begin with a valid segment ID.
        /// -or-
        /// delimitedString contains an incomplete segment string.
        /// </exception>
        public static T Deserialize<T>(string delimitedString) where T : class, IMessage
        {
            if (string.IsNullOrEmpty(delimitedString))
            {
                return null;
            }
            else
            {
                // Create instance of the Message class
                T item = Activator.CreateInstance<T>();

                

                CultureInfo culture = CultureInfo.CurrentCulture;
                string[] segments = delimitedString == null ? Array.Empty<string>() : delimitedString.Split(new char[] { (char)13 }, StringSplitOptions.RemoveEmptyEntries);
                List<ISegment> list = new();
                Type messageClass = item.GetType();

                // TODO: Add a check to ensure that line endings are \r
                // TODO: Add unit tests for Message.FromDelimitedString()
                // TODO: Test with a non-standard set of delimiter chars
                // TODO: Test methods for DetectHl7Version()

                if (segments.Length > 0)
                {
                    if (!segments[0].StartsWith($"MSH{ Configuration.FieldSeparator }", StringComparison.CurrentCultureIgnoreCase))
                    {
                        throw new ArgumentException($"{ nameof(delimitedString) } must begin with an MSH segment.", nameof(delimitedString));
                    }
                }

                // Process the first segment (MSH)
                ISegment mshSegment = (ISegment)messageClass.Assembly.CreateInstance($"{ messageClass.Namespace }.Segments.MshSegment", false);
                if (segments.Length > 0)
                {
                    list.Add(mshSegment);
                    list[0].FromDelimitedString(segments[0]);
                }

                // Capture the encoding chars
                Separators seps = new Separators().UsingInput(((IMshSegment)mshSegment).EncodingCharacters);

                // Process remaining segments
                for (int i = 1; i < segments.Length; i++)
                {
                    string segmentString = segments[i];

                    if (segmentString.Length < 3)
                    {
                        // Segment string is incomplete
                        throw new ArgumentException($"{ nameof(delimitedString) } contains an incomplete segment string.  '{ segmentString }' is invalid.", nameof(delimitedString));
                    }

                    // Instantiate the segment
                    string id = segmentString.Substring(0, 3);
                    object segment = messageClass.Assembly.CreateInstance($"{ messageClass.Namespace }.Segments.{ id.Substring(0, 1).ToUpper(culture) }{ id.Substring(1, 2).ToLower(culture) }Segment", false);

                    if (segment == null)
                    {
                        // Segment string begins with an invalid segment ID
                        throw new ArgumentException($"{ nameof(delimitedString) } contains a segment string that does not begin with a valid segment ID.  '{ id }' is invalid.", nameof(delimitedString));
                    }

                    // Init segment properties, and add to collection
                    ISegment sss = (ISegment)segment;
                    sss.Ordinal = i;
                    sss.FromDelimitedString(segmentString, seps);
                    list.Add(sss);
                }

                // Flush segment list
                item.Segments = list;

                // Return
                return item;
            }
        }
    }
}
