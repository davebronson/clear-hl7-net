using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V281.Types
{
    /// <summary>
    /// HL7 Version 2 DR - Date/Time Range.
    /// </summary>
    public class DateTimeRange : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeRange"/> class.
        /// </summary>
        public DateTimeRange()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeRange"/> class.
        /// </summary>
        /// <param name="rangeStartDateTime">DR.1 - Range Start Date/Time.</param>
        public DateTimeRange(DateTime rangeStartDateTime)
        {
            RangeStartDateTime = rangeStartDateTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeRange"/> class.
        /// </summary>
        /// <param name="rangeStartDateTime">DR.1 - Range Start Date/Time.</param>
        /// <param name="rangeEndDateTime">DR.2 - Range End Date/Time.</param>
        public DateTimeRange(DateTime rangeStartDateTime, DateTime rangeEndDateTime)
        {
            RangeStartDateTime = rangeStartDateTime;
            RangeEndDateTime = rangeEndDateTime;
        }

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
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 2, separator),
                                RangeStartDateTime?.ToHl7DateTimeString(typeof(DateTimeRange), nameof(RangeStartDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                RangeEndDateTime?.ToHl7DateTimeString(typeof(DateTimeRange), nameof(RangeEndDateTime), Consts.DateTimeFormatPrecisionSecond, culture)
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
