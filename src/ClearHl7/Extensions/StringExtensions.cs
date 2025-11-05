using System;
using System.Globalization;

namespace ClearHl7.Extensions
{
    /// <summary>
    /// Provides extension methods for safely converting string inputs into other types.
    /// </summary>
    public static class StringExtensions
    {
        private static readonly string[] ValidDateTimeFormats = {
            Consts.DateTimeFormatPrecisionSecond,
            Consts.DateFormatPrecisionDay,
            Consts.DateTimeFormatPrecisionMinute,
            Consts.DateTimeFormatPrecisionHour,
            Consts.DateFormatPrecisionMonth,
            Consts.DateFormatPrecisionYear,
            Consts.TimeFormatPrecisionSecond,
            Consts.TimeFormatPrecisionMinute,
            Consts.TimeFormatPrecisionHour
        };

        /// <summary>
        /// Converts the specified string representation of a date to its DateTime equivalent, if possible.
        /// </summary>
        /// <param name="input">A string containing the value to convert.</param>
        /// <returns>A DateTime.</returns>
        public static DateTime ToDateTime(this string input)
        {
            if (string.IsNullOrEmpty(input)) { return DateTime.MinValue; }

            DateTime.TryParseExact(input, ValidDateTimeFormats, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime returnValue);

            return returnValue;
        }

        /// <summary>
        /// Converts the specified string representation of a date to its nullable DateTime equivalent, if possible.
        /// </summary>
        /// <param name="input">A string containing the value to convert.</param>
        /// <returns>A DateTime, or null if the input provided is cannot be converted to a DateTime that follows the provided format.</returns>
        public static DateTime? ToNullableDateTime(this string input)
        {
            if (string.IsNullOrEmpty(input)) { return null; }

            bool success = DateTime.TryParseExact(input, ValidDateTimeFormats, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime returnValue);

            return success ? returnValue : null;
        }

        /// <summary>
        /// Converts the specified string representation of a number to its 32-bit unsigned integer equivalent, if possible.
        /// </summary>
        /// <param name="input">A string containing the value to convert.</param>
        /// <returns>A uint.</returns>
        public static uint ToUInt(this string input)
        {
            if (string.IsNullOrEmpty(input)) { return 0; }

            uint.TryParse(input, NumberStyles.Integer, CultureInfo.CurrentCulture, out uint returnValue);

            return returnValue;
        }

        /// <summary>
        /// Converts the specified string representation of a number to its nullable 32-bit unsigned integer equivalent, if possible.
        /// </summary>
        /// <param name="input">A string containing the value to convert.</param>
        /// <returns>A uint, or null if the input provided is cannot be converted to a UInt.</returns>
        public static uint? ToNullableUInt(this string input)
        {
            if (string.IsNullOrEmpty(input)) { return null; }

            bool success = uint.TryParse(input, NumberStyles.Integer, CultureInfo.CurrentCulture, out uint returnValue);

            return success ? returnValue : null;
        }

        /// <summary>
        /// Converts the specified string representation of a number to its 32-bit signed integer equivalent, if possible.
        /// </summary>
        /// <param name="input">A string containing the value to convert.</param>
        /// <returns>An int.</returns>
        public static int ToInt(this string input)
        {
            if (string.IsNullOrEmpty(input)) { return 0; }

            int.TryParse(input, NumberStyles.Integer, CultureInfo.CurrentCulture, out int returnValue);

            return returnValue;
        }

        /// <summary>
        /// Converts the specified string representation of a number to its nullable 32-bit signed integer equivalent, if possible.
        /// </summary>
        /// <param name="input">A string containing the value to convert.</param>
        /// <returns>An int, or null if the input provided is cannot be converted to an int.</returns>
        public static int? ToNullableInt(this string input)
        {
            if (string.IsNullOrEmpty(input)) { return null; }

            bool success = int.TryParse(input, NumberStyles.Integer, CultureInfo.CurrentCulture, out int returnValue);

            return success ? returnValue : null;
        }

        /// <summary>
        /// Converts the specified string representation of a number to its decimal equivalent, if possible.
        /// </summary>
        /// <param name="input">A string containing the value to convert.</param>
        /// <returns>A decimal.</returns>
        public static decimal ToDecimal(this string input)
        {
            if (string.IsNullOrEmpty(input)) { return 0M; }

            decimal.TryParse(input, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal returnValue);

            return returnValue;
        }

        /// <summary>
        /// Converts the specified string representation of a number to its nullable decimal equivalent, if possible.
        /// </summary>
        /// <param name="input">A string containing the value to convert.</param>
        /// <returns>A decimal, or null if the input provided is cannot be converted to a decimal.</returns>
        public static decimal? ToNullableDecimal(this string input)
        {
            if (string.IsNullOrEmpty(input)) { return null; }

            bool success = decimal.TryParse(input, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal returnValue);

            return success ? returnValue : null;
        }

        /// <summary>
        /// Formats a DateTime value using the specified precision level.
        /// </summary>
        /// <param name="dateTime">The DateTime value to format.</param>
        /// <param name="precision">The precision level to use for formatting.</param>
        /// <returns>A formatted string representation of the DateTime value.</returns>
        public static string ToHl7DateTimeString(this DateTime dateTime, DateTimePrecision precision)
        {
            string format = GetDateTimeFormatString(precision);
            return dateTime.ToString(format, CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Formats a nullable DateTime value using the specified precision level.
        /// </summary>
        /// <param name="dateTime">The nullable DateTime value to format.</param>
        /// <param name="precision">The precision level to use for formatting.</param>
        /// <returns>A formatted string representation of the DateTime value, or null if the input is null.</returns>
        public static string ToHl7DateTimeString(this DateTime? dateTime, DateTimePrecision precision)
        {
            return dateTime.HasValue ? dateTime.Value.ToHl7DateTimeString(precision) : null;
        }

        /// <summary>
        /// Formats a DateTime value using per-field configuration with explicit original precision.
        /// Follows the hierarchy: 1) Individual field override, 2) Global override, 3) Original code-defined precision.
        /// </summary>
        /// <param name="dateTime">The DateTime value to format.</param>
        /// <param name="segmentType">The type of the segment containing this field.</param>
        /// <param name="propertyName">The name of the property being formatted.</param>
        /// <param name="originalFormat">The original format defined in the code for this specific field.</param>
        /// <param name="culture">The culture to use for formatting.</param>
        /// <returns>A formatted string representation of the DateTime value using the configured hierarchy.</returns>
        public static string ToHl7DateTimeString(this DateTime dateTime, Type segmentType, string propertyName, string originalFormat, CultureInfo culture)
        {
            string format = Hl7DateTimeFormatConfig.GetFormatForField(segmentType, propertyName, originalFormat);
            return dateTime.ToString(format, culture);
        }

        /// <summary>
        /// Formats a nullable DateTime value using per-field configuration with explicit original precision.
        /// Follows the hierarchy: 1) Individual field override, 2) Global override, 3) Original code-defined precision.
        /// </summary>
        /// <param name="dateTime">The nullable DateTime value to format.</param>
        /// <param name="segmentType">The type of the segment containing this field.</param>
        /// <param name="propertyName">The name of the property being formatted.</param>
        /// <param name="originalFormat">The original format defined in the code for this specific field.</param>
        /// <param name="culture">The culture to use for formatting.</param>
        /// <returns>A formatted string representation of the DateTime value using the configured hierarchy, or null if the input is null.</returns>
        public static string ToHl7DateTimeString(this DateTime? dateTime, Type segmentType, string propertyName, string originalFormat, CultureInfo culture)
        {
            return dateTime.HasValue ? dateTime.Value.ToHl7DateTimeString(segmentType, propertyName, originalFormat, culture) : null;
        }

        /// <summary>
        /// Gets the appropriate HL7 DateTime format string for the specified precision level.
        /// </summary>
        /// <param name="precision">The precision level.</param>
        /// <returns>The format string corresponding to the precision level.</returns>
        private static string GetDateTimeFormatString(DateTimePrecision precision)
        {
            return precision switch
            {
                DateTimePrecision.Year => Consts.DateFormatPrecisionYear,
                DateTimePrecision.Month => Consts.DateFormatPrecisionMonth,
                DateTimePrecision.Day => Consts.DateFormatPrecisionDay,
                DateTimePrecision.Hour => Consts.DateTimeFormatPrecisionHour,
                DateTimePrecision.Minute => Consts.DateTimeFormatPrecisionMinute,
                DateTimePrecision.Second => Consts.DateTimeFormatPrecisionSecond,
                _ => Consts.DateTimeFormatPrecisionSecond
            };
        }
    }
}
