using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment QAK - Query Acknowledgment.
    /// </summary>
    public class QakSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "QAK";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// QAK.1 - Query Tag.
        ///// </summary>
        //public QueryTag { get; set; }

        ///// <summary>
        ///// QAK.2 - Query Response Status.
        ///// </summary>
        //public QueryResponseStatus { get; set; }

        ///// <summary>
        ///// QAK.3 - Message Query Name.
        ///// </summary>
        //public MessageQueryName { get; set; }

        ///// <summary>
        ///// QAK.4 - Hit Count Total.
        ///// </summary>
        //public HitCountTotal { get; set; }

        ///// <summary>
        ///// QAK.5 - This payload.
        ///// </summary>
        //public ThisPayload { get; set; }

        ///// <summary>
        ///// QAK.6 - Hits remaining.
        ///// </summary>
        //public HitsRemaining { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}"
                                ).TrimEnd('|');
        }
    }
}