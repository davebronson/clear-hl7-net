using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V250
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
        public void FromDelimitedString(string delimitedString)
        {
            Segments = MessageSerializer.Deserialize<Message>(delimitedString).Segments;
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
                    output.Append(Consts.LineTerminator);
                }
            }

            return output.ToString();
        }
    }
}
