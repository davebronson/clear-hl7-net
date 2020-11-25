using System;
using System.Collections.Generic;
using System.Linq;

namespace ClearHl7.Fhir.V231.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment BTS - Batch Trailer.
    /// </summary>
    public class BtsSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "BTS";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// BTS.1 - Batch Message Count.
        /// </summary>
        public string BatchMessageCount { get; set; }

        /// <summary>
        /// BTS.2 - Batch Comment.
        /// </summary>
        public string BatchComment { get; set; }

        /// <summary>
        /// BTS.3 - Batch Totals.
        /// </summary>
        public IEnumerable<decimal> BatchTotals { get; set; }

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
                                BatchMessageCount,
                                BatchComment,
                                BatchTotals != null ? string.Join("~", BatchTotals.Select(x => x.ToString(Consts.NumericFormat, culture))) : null
                                ).TrimEnd('|');
        }
    }
}