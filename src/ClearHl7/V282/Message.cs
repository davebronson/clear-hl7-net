using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClearHl7.Helpers;

namespace ClearHl7.V282
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
