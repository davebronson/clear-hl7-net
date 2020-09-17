using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClearHl7.Fhir.V282.Segments;

namespace ClearHl7.Fhir.V282
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

            if (Segments?.Any() == true)
            {
                foreach (ISegment item in Segments.OrderBy(x => x.Ordinal))
                {
                    output.Append(item.ToDelimitedString());
                    output.Append((char)13);
                }
            }

            return output.ToString();
        }
    }
}
