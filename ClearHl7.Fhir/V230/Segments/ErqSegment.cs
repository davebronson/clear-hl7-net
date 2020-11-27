using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V230.Types;

namespace ClearHl7.Fhir.V230.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ERQ - Equipment Detail.
    /// </summary>
    public class ErqSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "ERQ";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// ERQ.1 - Query Tag.
        /// </summary>
        public string QueryTag { get; set; }

        /// <summary>
        /// ERQ.2 - Event Identifier.
        /// </summary>
        public CodedElement EventIdentifier { get; set; }

        /// <summary>
        /// ERQ.3 - Input Parameter List.
        /// </summary>
        public IEnumerable<QueryInputParameterList> InputParameterList { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}",
                                Id,
                                QueryTag,
                                EventIdentifier?.ToDelimitedString(),
                                InputParameterList != null ? string.Join("~", InputParameterList.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd('|');
        }
    }
}