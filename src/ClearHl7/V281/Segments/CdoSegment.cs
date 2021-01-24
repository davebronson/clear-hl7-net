using ClearHl7.Helpers;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment CDO - Cumulative Dosage.
    /// </summary>
    public class CdoSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "CDO";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// CDO.1 - Set ID - CDO.
        /// </summary>
        public uint? SetIdCdo { get; set; }

        /// <summary>
        /// CDO.2 - Action Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0206</remarks>
        public string ActionCode { get; set; }

        /// <summary>
        /// CDO.3 - Cumulative Dosage Limit.
        /// </summary>
        public CompositeQuantityWithUnits CumulativeDosageLimit { get; set; }

        /// <summary>
        /// CDO.4 - Cumulative Dosage Limit Time Interval.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0924</remarks>
        public CompositeQuantityWithUnits CumulativeDosageLimitTimeInterval { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 5, Configuration.FieldSeparator),
                                Id,
                                SetIdCdo.HasValue ? SetIdCdo.Value.ToString(culture) : null,
                                ActionCode,
                                CumulativeDosageLimit?.ToDelimitedString(),
                                CumulativeDosageLimitTimeInterval?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}