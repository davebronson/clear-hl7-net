using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V250.Types
{
    /// <summary>
    /// HL7 Version 2 RPT - Repeat Pattern.
    /// </summary>
    public class RepeatPattern : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepeatPattern"/> class.
        /// </summary>
        public RepeatPattern()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepeatPattern"/> class.
        /// </summary>
        /// <param name="repeatPatternCode">RPT.1 - Repeat Pattern Code.</param>
        public RepeatPattern(CodedWithExceptions repeatPatternCode)
        {
            RepeatPatternCode = repeatPatternCode;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// RPT.1 - Repeat Pattern Code.
        /// <para>Suggested: 0335 Repeat Pattern -&gt; ClearHl7.Codes.V250.CodeRepeatPattern</para>
        /// </summary>
        public CodedWithExceptions RepeatPatternCode { get; set; }

        /// <summary>
        /// RPT.2 - Calendar Alignment.
        /// <para>Suggested: 0527 Calendar Alignment -&gt; ClearHl7.Codes.V250.CodeCalendarAlignment</para>
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V250.CodeYesNoIndicator</para>
        /// </summary>
        public string InstitutionSpecifiedTime { get; set; }

        /// <summary>
        /// RPT.8 - Event.
        /// <para>Suggested: 0528 Event Related Period -&gt; ClearHl7.Codes.V250.CodeEventRelatedPeriod</para>
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

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] separator = IsSubcomponent ? seps.SubcomponentSeparator : seps.ComponentSeparator;
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(separator, StringSplitOptions.None);

            RepeatPatternCode = segments.Length > 0 && segments[0].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[0], true, seps) : null;
            CalendarAlignment = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            PhaseRangeBeginValue = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDecimal() : null;
            PhaseRangeEndValue = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDecimal() : null;
            PeriodQuantity = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDecimal() : null;
            PeriodUnits = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            InstitutionSpecifiedTime = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            Event = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            EventOffsetQuantity = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDecimal() : null;
            EventOffsetUnits = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            GeneralTimingSpecification = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
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
