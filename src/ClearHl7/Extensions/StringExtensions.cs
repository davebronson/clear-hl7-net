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
    }
}
