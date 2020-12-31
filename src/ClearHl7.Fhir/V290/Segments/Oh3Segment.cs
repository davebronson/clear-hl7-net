using System;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V290.Types;

namespace ClearHl7.Fhir.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment OH3 - Usual Work.
    /// </summary>
    public class Oh3Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "OH3";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// OH3.1 - Set ID.
        /// </summary>
        public uint? SetId { get; set; }

        /// <summary>
        /// OH3.2 - Action Code.
        /// </summary>
        public string ActionCode { get; set; }

        /// <summary>
        /// OH3.3 - Occupation.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0958</remarks>
        public CodedWithExceptions Occupation { get; set; }

        /// <summary>
        /// OH3.4 - Industry.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0955</remarks>
        public CodedWithExceptions Industry { get; set; }

        /// <summary>
        /// OH3.5 - Usual Occupation Duration (Years).
        /// </summary>
        public decimal? UsualOccupationDurationYears { get; set; }

        /// <summary>
        /// OH3.6 - Start Year.
        /// </summary>
        public DateTime? StartYear { get; set; }

        /// <summary>
        /// OH3.7 - Entered Date.
        /// </summary>
        public DateTime? EnteredDate { get; set; }

        /// <summary>
        /// OH3.8 - Work Unique Identifier.
        /// </summary>
        public EntityIdentifier WorkUniqueIdentifier { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 9, Configuration.FieldSeparator),
                                Id,
                                SetId.HasValue ? SetId.Value.ToString(culture) : null,
                                ActionCode,
                                Occupation?.ToDelimitedString(),
                                Industry?.ToDelimitedString(),
                                UsualOccupationDurationYears.HasValue ? UsualOccupationDurationYears.Value.ToString(Consts.NumericFormat, culture) : null,
                                StartYear.HasValue ? StartYear.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                EnteredDate.HasValue ? EnteredDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                WorkUniqueIdentifier?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}