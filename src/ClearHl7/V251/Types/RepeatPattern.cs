using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V251.Types
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
        /// <para>Suggested: 0335 Repeat Pattern -&gt; ClearHl7.Codes.V251.CodeRepeatPattern</para>
        /// </summary>
        public CodedWithExceptions RepeatPatternCode { get; set; }

        /// <summary>
        /// RPT.2 - Calendar Alignment.
        /// <para>Suggested: 0527 Calendar Alignment -&gt; ClearHl7.Codes.V251.CodeCalendarAlignment</para>
        /// </summary>
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
        public string PeriodUnits { get; set; }

        /// <summary>
        /// RPT.7 - Institution Specified Time.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V251.CodeYesNoIndicator</para>
        /// </summary>
        public string InstitutionSpecifiedTime { get; set; }

        /// <summary>
        /// RPT.8 - Event.
        /// <para>Suggested: 0528 Event Related Period -&gt; ClearHl7.Codes.V251.CodeEventRelatedPeriod</para>
        /// </summary>
        public string Event { get; set; }

        /// <summary>
        /// RPT.9 - Event Offset Quantity.
        /// </summary>
        public decimal? EventOffsetQuantity { get; set; }

        /// <summary>
        /// RPT.10 - Event Offset Units.
        /// </summary>
        public string EventOffsetUnits { get; set; }

        /// <summary>
        /// RPT.11 - General Timing Specification.
        /// </summary>
        public string GeneralTimingSpecification { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            if (segments.Length > 0)
            {
                RepeatPatternCode = new CodedWithExceptions { IsSubcomponent = true };
                RepeatPatternCode.FromDelimitedString(segments.ElementAtOrDefault(0));
            }
            else
            {
                RepeatPatternCode = null;
            }

            CalendarAlignment = segments.ElementAtOrDefault(1);
            PhaseRangeBeginValue = segments.ElementAtOrDefault(2)?.ToNullableDecimal();
            PhaseRangeEndValue = segments.ElementAtOrDefault(3)?.ToNullableDecimal();
            PeriodQuantity = segments.ElementAtOrDefault(4)?.ToNullableDecimal();
            PeriodUnits = segments.ElementAtOrDefault(5);
            InstitutionSpecifiedTime = segments.ElementAtOrDefault(6);
            Event = segments.ElementAtOrDefault(7);
            EventOffsetQuantity = segments.ElementAtOrDefault(8)?.ToNullableDecimal();
            EventOffsetUnits = segments.ElementAtOrDefault(9);
            GeneralTimingSpecification = segments.ElementAtOrDefault(10);
        }

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
                                PeriodUnits,
                                InstitutionSpecifiedTime,
                                Event,
                                EventOffsetQuantity.HasValue ? EventOffsetQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                EventOffsetUnits,
                                GeneralTimingSpecification
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
