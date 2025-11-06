using System;
using Xunit;

namespace ClearHl7.Tests.FormatTests
{
    public class DateFormatTests
    {
        /// <summary>
        /// Validates that passing the Consts.DateFormat string to DateTime.ToString() results in the expected output.
        /// </summary>
        [Fact]
        public void ToString_WithDateFormat_ReturnsCorrectlyFormattedString()
        {
            string expected = "20200115";
            string actual = new DateTime(2020, 1, 15, 10, 3, 55).ToString(Consts.DateFormat, System.Globalization.CultureInfo.CurrentCulture);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Validates that passing the Consts.DateFormatPrecisionDay string to DateTime.ToString() results in the expected output.
        /// </summary>
        [Fact]
        public void ToString_WithDateFormatPrecisionDay_ReturnsCorrectlyFormattedString()
        {
            string expected = "20200115";
            string actual = new DateTime(2020, 1, 15, 10, 3, 55).ToString(Consts.DateFormatPrecisionDay, System.Globalization.CultureInfo.CurrentCulture);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Validates that passing the Consts.DateFormatPrecisionMonth string to DateTime.ToString() results in the expected output.
        /// </summary>
        [Fact]
        public void ToString_WithDateFormatPrecisionMonth_ReturnsCorrectlyFormattedString()
        {
            string expected = "202001";
            string actual = new DateTime(2020, 1, 15, 10, 3, 55).ToString(Consts.DateFormatPrecisionMonth, System.Globalization.CultureInfo.CurrentCulture);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Validates that passing the Consts.DateFormatPrecisionYear string to DateTime.ToString() results in the expected output.
        /// </summary>
        [Fact]
        public void ToString_WithDateFormatPrecisionYear_ReturnsCorrectlyFormattedString()
        {
            string expected = "2020";
            string actual = new DateTime(2020, 1, 15, 10, 3, 55).ToString(Consts.DateFormatPrecisionYear, System.Globalization.CultureInfo.CurrentCulture);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Validates that passing the Consts.DateTimeFormat string to DateTime.ToString() results in the expected output.
        /// </summary>
        [Fact]
        public void ToString_WithDateTimeFormat_ReturnsCorrectlyFormattedString()
        {
            string expected = "20200115100355";
            string actual = new DateTime(2020, 1, 15, 10, 3, 55).ToString(Consts.DateTimeFormat, System.Globalization.CultureInfo.CurrentCulture);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Validates that passing the Consts.DateTimeFormatPrecisionSecond string to DateTime.ToString() results in the expected output.
        /// </summary>
        [Fact]
        public void ToString_WithDateTimeFormatPrecisionSecond_ReturnsCorrectlyFormattedString()
        {
            string expected = "20200115100355";
            string actual = new DateTime(2020, 1, 15, 10, 3, 55).ToString(Consts.DateTimeFormatPrecisionSecond, System.Globalization.CultureInfo.CurrentCulture);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Validates that passing the Consts.DateTimeFormatPrecisionMinute string to DateTime.ToString() results in the expected output.
        /// </summary>
        [Fact]
        public void ToString_WithDateTimeFormatPrecisionMinute_ReturnsCorrectlyFormattedString()
        {
            string expected = "202001151003";
            string actual = new DateTime(2020, 1, 15, 10, 3, 55).ToString(Consts.DateTimeFormatPrecisionMinute, System.Globalization.CultureInfo.CurrentCulture);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Validates that passing the Consts.DateTimeFormatPrecisionHour string to DateTime.ToString() results in the expected output.
        /// </summary>
        [Fact]
        public void ToString_WithDateTimeFormatPrecisionHour_ReturnsCorrectlyFormattedString()
        {
            string expected = "2020011510";
            string actual = new DateTime(2020, 1, 15, 10, 3, 55).ToString(Consts.DateTimeFormatPrecisionHour, System.Globalization.CultureInfo.CurrentCulture);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Validates that passing the Consts.TimeFormat string to DateTime.ToString() results in the expected output.
        /// </summary>
        [Fact]
        public void ToString_WithTimeFormat_ReturnsCorrectlyFormattedString()
        {
            string expected = "100355";
            string actual = new DateTime(2020, 1, 15, 10, 3, 55).ToString(Consts.TimeFormat, System.Globalization.CultureInfo.CurrentCulture);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Validates that passing the Consts.TimeFormatPrecisionSecond string to DateTime.ToString() results in the expected output.
        /// </summary>
        [Fact]
        public void ToString_WithTimeFormatPrecisionSecond_ReturnsCorrectlyFormattedString()
        {
            string expected = "100355";
            string actual = new DateTime(2020, 1, 15, 10, 3, 55).ToString(Consts.TimeFormatPrecisionSecond, System.Globalization.CultureInfo.CurrentCulture);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Validates that passing the Consts.TimeFormatPrecisionMinute string to DateTime.ToString() results in the expected output.
        /// </summary>
        [Fact]
        public void ToString_WithTimeFormatPrecisionMinute_ReturnsCorrectlyFormattedString()
        {
            string expected = "1003";
            string actual = new DateTime(2020, 1, 15, 10, 3, 55).ToString(Consts.TimeFormatPrecisionMinute, System.Globalization.CultureInfo.CurrentCulture);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Validates that passing the Consts.TimeFormatPrecisionHour string to DateTime.ToString() results in the expected output.
        /// </summary>
        [Fact]
        public void ToString_WithTimeFormatPrecisionHour_ReturnsCorrectlyFormattedString()
        {
            string expected = "10";
            string actual = new DateTime(2020, 1, 15, 10, 3, 55).ToString(Consts.TimeFormatPrecisionHour, System.Globalization.CultureInfo.CurrentCulture);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Validates that the DateTimeFormatPrecisionSecondWithTimezoneOffset constant is documented correctly.
        /// Note: This constant documents the format but the offset must be appended manually using helper methods
        /// because .NET's standard format tokens produce "+HH:mm" with a colon, not HL7's "±HHMM" without colon.
        /// </summary>
        [Fact]
        public void Constant_DateTimeFormatPrecisionSecondWithTimezoneOffset_HasCorrectValue()
        {
            string expected = "yyyyMMddHHmmss±HHMM";
            string actual = Consts.DateTimeFormatPrecisionSecondWithTimezoneOffset;

            Assert.Equal(expected, actual);
        }
    }
}
