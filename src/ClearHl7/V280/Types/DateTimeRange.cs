using System;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V280.Types
{
    /// <summary>
    /// HL7 Version 2 DR - Date/Time Range.
    /// </summary>
    public class DateTimeRange : IType
    {
        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// DR.1 - Range Start Date/Time.
        /// </summary>
        public DateTime? RangeStartDateTime { get; set; }

        /// <summary>
        /// DR.2 - Range End Date/Time.
        /// </summary>
        public DateTime? RangeEndDateTime { get; set; }

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

            RangeStartDateTime = segments.Length > 0 && segments[0].Length > 0 ? segments[0].ToNullableDateTime() : null;
            RangeEndDateTime = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDateTime() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 2, separator),
                                RangeStartDateTime.HasValue ? RangeStartDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                RangeEndDateTime.HasValue ? RangeEndDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
