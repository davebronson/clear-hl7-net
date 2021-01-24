using ClearHl7.Helpers;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
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

        /// <summary>
        /// QAK.1 - Query Tag.
        /// </summary>
        public string QueryTag { get; set; }

        /// <summary>
        /// QAK.2 - Query Response Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0208</remarks>
        public string QueryResponseStatus { get; set; }

        /// <summary>
        /// QAK.3 - Message Query Name.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0471</remarks>
        public CodedWithExceptions MessageQueryName { get; set; }

        /// <summary>
        /// QAK.4 - Hit Count Total.
        /// </summary>
        public decimal? HitCountTotal { get; set; }

        /// <summary>
        /// QAK.5 - This payload.
        /// </summary>
        public decimal? ThisPayload { get; set; }

        /// <summary>
        /// QAK.6 - Hits remaining.
        /// </summary>
        public decimal? HitsRemaining { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 7, Configuration.FieldSeparator),
                                Id,
                                QueryTag,
                                QueryResponseStatus,
                                MessageQueryName?.ToDelimitedString(),
                                HitCountTotal.HasValue ? HitCountTotal.Value.ToString(Consts.NumericFormat, culture) : null,
                                ThisPayload.HasValue ? ThisPayload.Value.ToString(Consts.NumericFormat, culture) : null,
                                HitsRemaining.HasValue ? HitsRemaining.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}