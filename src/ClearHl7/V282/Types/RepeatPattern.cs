using ClearHl7.Helpers;

namespace ClearHl7.V282.Types
{
    /// <summary>
    /// HL7 Version 2 RPT - Repeat Pattern.
    /// </summary>
    public class RepeatPattern : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// RPT.1 - Repeat Pattern Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0335</remarks>
        public CodedWithExceptions RepeatPatternCode { get; set; }

        /// <summary>
        /// RPT.2 - Calendar Alignment.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0527</remarks>
        public string CalendarAlignment { get; set; }

        /// <summary>
        /// RPT.3 - Phase Range Begin Value.
        /// </summary>
        public decimal? PhaseRangeBeginValue { get; set; }

        /// <summary>
        /// RPT.4 - Phase Range End Value.
        /// </summary>
        public decimal? PhaseRangeEndValue { get; set; }

        /// <summary>
        /// RPT.5 - Period Quantity.
        /// </summary>
        public decimal? PeriodQuantity { get; set; }

        /// <summary>
        /// RPT.6 - Period Units.
        /// </summary>
        public CodedWithExceptions PeriodUnits { get; set; }

        /// <summary>
        /// RPT.7 - Institution Specified Time.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string InstitutionSpecifiedTime { get; set; }

        /// <summary>
        /// RPT.8 - Event.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0528</remarks>
        public string Event { get; set; }

        /// <summary>
        /// RPT.9 - Event Offset Quantity.
        /// </summary>
        public decimal? EventOffsetQuantity { get; set; }

        /// <summary>
        /// RPT.10 - Event Offset Units.
        /// </summary>
        public CodedWithExceptions EventOffsetUnits { get; set; }

        /// <summary>
        /// RPT.11 - General Timing Specification.
        /// </summary>
        public string GeneralTimingSpecification { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 11, separator),
                                RepeatPatternCode?.ToDelimitedString(),
                                CalendarAlignment,
                                PhaseRangeBeginValue.HasValue ? PhaseRangeBeginValue.Value.ToString(Consts.NumericFormat, culture) : null,
                                PhaseRangeEndValue.HasValue ? PhaseRangeEndValue.Value.ToString(Consts.NumericFormat, culture) : null,
                                PeriodQuantity.HasValue ? PeriodQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                PeriodUnits?.ToDelimitedString(),
                                InstitutionSpecifiedTime,
                                Event,
                                EventOffsetQuantity.HasValue ? EventOffsetQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                EventOffsetUnits?.ToDelimitedString(),
                                GeneralTimingSpecification
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
