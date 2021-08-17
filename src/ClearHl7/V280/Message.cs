using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using ClearHl7.Helpers;
using ClearHl7.V280.Segments;

namespace ClearHl7.V280
{
    /// <summary>
    /// HL7 Version 2 Message.
    /// </summary>
    public class Message : IMessage
    {
        /// <summary>
        /// Gets or sets the list of Message Segments.
        /// </summary>
        public IEnumerable<ISegment> Segments { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">
        /// The first segment in delimitedString is not the MSH segment.
        /// -or-
        /// delimitedString contains a segment string that does not begin with a valid segment ID.
        /// -or-
        /// delimitedString contains an incomplete segment string.
        /// </exception>
        public void FromDelimitedString(string delimitedString)
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(new char[] { (char)13 }, StringSplitOptions.RemoveEmptyEntries);
            List<ISegment> list = new();
            Type messageClass = GetType();

            // MSH will be responsible for determing the separator chars, and processing itself accordingly.
            //      When MSH processing completes, this Message will grab the sparator chars and store locally
            // The locally stored chars should be used for processing the remaining Segments in the collection
            // Add a check to ensure that line endings are \r

            if (segments.Length > 0)
            {
                if (!segments[0].StartsWith($"MSH{ Configuration.FieldSeparator }", StringComparison.CurrentCultureIgnoreCase))
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } must begin with an MSH segment.", nameof(delimitedString));
                }
            }

            // Process the first segment (MSH)
            MshSegment msh = new();
            if (segments.Length > 0)
            {
                list.Add(msh);
                list[0].FromDelimitedString(segments[0]);
            }

            // Capture the encoding chars
            char[] encodingChars = msh.EncodingCharacters.ToCharArray();
            // TODO:  Throw error from MSH if encodingChars isn't length = 4
            char componentSepararor = encodingChars[0];
            char fieldRepeatSeparator = encodingChars[1];
            char escapeCharacter = encodingChars[2];
            char subcomponentSeparator = encodingChars[3];

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
                sss.FromDelimitedString(segmentString);
                list.Add(sss);
            }

            // Flush segment list
            Segments = list;
        }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            StringBuilder output = new();
            SegmentHelper segmentHelper = Configuration.AutoSetSubcomponentFlags ? new SegmentHelper() : null;

            if (Segments?.Any() == true)
            {
                foreach (ISegment item in Segments.OrderBy(x => x.Ordinal))
                {
                    if (Configuration.AutoSetSubcomponentFlags)
                    {
                        segmentHelper.SetSubcomponentFlags(item);
                    }

                    output.Append(item.ToDelimitedString());
                    output.Append((char)13);
                }
            }

            return output.ToString();
        }
    }
}
