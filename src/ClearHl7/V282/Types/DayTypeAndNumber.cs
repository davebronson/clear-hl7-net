using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V282.Types
{
    /// <summary>
    /// HL7 Version 2 DTN - Day Type And Number.
    /// </summary>
    public class DayTypeAndNumber : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DayTypeAndNumber"/> class.
        /// </summary>
        public DayTypeAndNumber()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DayTypeAndNumber"/> class.
        /// </summary>
        /// <param name="dayType">DTN.1 - Day Type.</param>
        /// <param name="numberOfDays">DTN.2 - Number of Days.</param>
        public DayTypeAndNumber(CodedWithExceptions dayType, decimal numberOfDays)
        {
            DayType = dayType;
            NumberOfDays = numberOfDays;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// DTN.1 - Day Type.
        /// <para>Suggested: 0149 Day Type -&gt; ClearHl7.Codes.V282.CodeDayType</para>
        /// </summary>
        public CodedWithExceptions DayType { get; set; }

        /// <summary>
        /// DTN.2 - Number of Days.
        /// </summary>
        public decimal? NumberOfDays { get; set; }

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

            DayType = segments.Length > 0 && segments[0].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[0], true, seps) : null;
            NumberOfDays = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 2, separator),
                                DayType?.ToDelimitedString(),
                                NumberOfDays.HasValue ? NumberOfDays.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
