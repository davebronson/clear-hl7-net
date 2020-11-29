using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClearHl7.Fhir.Helpers;

namespace ClearHl7.Fhir.V230
{
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
            StringBuilder output = new StringBuilder();
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
