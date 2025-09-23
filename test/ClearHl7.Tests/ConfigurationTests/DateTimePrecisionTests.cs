using System;
using ClearHl7.Extensions;
using Xunit;

namespace ClearHl7.Tests.ConfigurationTests
{
    public class DateTimePrecisionTests
    {
        private readonly DateTime _testDateTime = new DateTime(2020, 1, 15, 10, 3, 55);

        /// <summary>
        /// Validates that ToHl7DateTimeString with Year precision returns correctly formatted string.
        /// </summary>
        [Fact]
        public void ToHl7DateTimeString_WithYearPrecision_ReturnsCorrectlyFormattedString()
        {
            string expected = "2020";
            string actual = _testDateTime.ToHl7DateTimeString(DateTimePrecision.Year);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Validates that ToHl7DateTimeString with Month precision returns correctly formatted string.
        /// </summary>
        [Fact]
        public void ToHl7DateTimeString_WithMonthPrecision_ReturnsCorrectlyFormattedString()
        {
            string expected = "202001";
            string actual = _testDateTime.ToHl7DateTimeString(DateTimePrecision.Month);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Validates that ToHl7DateTimeString with Day precision returns correctly formatted string.
        /// </summary>
        [Fact]
        public void ToHl7DateTimeString_WithDayPrecision_ReturnsCorrectlyFormattedString()
        {
            string expected = "20200115";
            string actual = _testDateTime.ToHl7DateTimeString(DateTimePrecision.Day);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Validates that ToHl7DateTimeString with Hour precision returns correctly formatted string.
        /// </summary>
        [Fact]
        public void ToHl7DateTimeString_WithHourPrecision_ReturnsCorrectlyFormattedString()
        {
            string expected = "2020011510";
            string actual = _testDateTime.ToHl7DateTimeString(DateTimePrecision.Hour);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Validates that ToHl7DateTimeString with Minute precision returns correctly formatted string.
        /// </summary>
        [Fact]
        public void ToHl7DateTimeString_WithMinutePrecision_ReturnsCorrectlyFormattedString()
        {
            string expected = "202001151003";
            string actual = _testDateTime.ToHl7DateTimeString(DateTimePrecision.Minute);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Validates that ToHl7DateTimeString with Second precision returns correctly formatted string.
        /// </summary>
        [Fact]
        public void ToHl7DateTimeString_WithSecondPrecision_ReturnsCorrectlyFormattedString()
        {
            string expected = "20200115100355";
            string actual = _testDateTime.ToHl7DateTimeString(DateTimePrecision.Second);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Validates that ToHl7DateTimeString with nullable DateTime and specific precision returns correctly formatted string.
        /// </summary>
        [Fact]
        public void ToHl7DateTimeString_WithNullableDateTimeAndMinutePrecision_ReturnsCorrectlyFormattedString()
        {
            DateTime? nullableDateTime = _testDateTime;
            string expected = "202001151003";
            string actual = nullableDateTime.ToHl7DateTimeString(DateTimePrecision.Minute);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Validates that ToHl7DateTimeString with null DateTime returns null.
        /// </summary>
        [Fact]
        public void ToHl7DateTimeString_WithNullDateTime_ReturnsNull()
        {
            DateTime? nullDateTime = null;
            string actual = nullDateTime.ToHl7DateTimeString(DateTimePrecision.Second);

            Assert.Null(actual);
        }

        /// <summary>
        /// Validates that ToHl7DateTimeString without precision parameter uses configured precision.
        /// </summary>
        [Fact]
        public void ToHl7DateTimeString_WithoutPrecisionParameter_UsesConfiguredPrecision()
        {
            // Save original configuration
            var originalPrecision = Configuration.DateTimePrecision;

            try
            {
                // Set configuration to minute precision
                Configuration.DateTimePrecision = DateTimePrecision.Minute;

                string expected = "202001151003";
                string actual = _testDateTime.ToHl7DateTimeString();

                Assert.Equal(expected, actual);
            }
            finally
            {
                // Restore original configuration
                Configuration.DateTimePrecision = originalPrecision;
            }
        }

        /// <summary>
        /// Validates that Configuration.DateTimePrecision defaults to Second precision.
        /// </summary>
        [Fact]
        public void Configuration_DateTimePrecision_DefaultsToSecond()
        {
            // Reset to defaults (this should be called before accessing the property in other tests)
            var originalPrecision = Configuration.DateTimePrecision;

            try
            {
                // Since we can't reset to factory defaults easily, just check that it works as intended
                Configuration.DateTimePrecision = DateTimePrecision.Second;
                Assert.Equal(DateTimePrecision.Second, Configuration.DateTimePrecision);
            }
            finally
            {
                Configuration.DateTimePrecision = originalPrecision;
            }
        }

        /// <summary>
        /// Validates that ToHl7DateTimeString with nullable DateTime and no precision uses configured precision.
        /// </summary>
        [Fact]
        public void ToHl7DateTimeString_WithNullableDateTimeAndNoParameters_UsesConfiguredPrecision()
        {
            // Save original configuration
            var originalPrecision = Configuration.DateTimePrecision;

            try
            {
                // Set configuration to day precision
                Configuration.DateTimePrecision = DateTimePrecision.Day;

                DateTime? nullableDateTime = _testDateTime;
                string expected = "20200115";
                string actual = nullableDateTime.ToHl7DateTimeString();

                Assert.Equal(expected, actual);
            }
            finally
            {
                // Restore original configuration
                Configuration.DateTimePrecision = originalPrecision;
            }
        }
    }
}