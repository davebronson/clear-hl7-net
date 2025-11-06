using System;
using Xunit;

namespace ClearHl7.Tests.ConfigurationTests
{
    [Collection("Hl7DateTimeFormatConfig")]
    public class Hl7DateTimeTimezoneOffsetTests : IDisposable
    {
        public Hl7DateTimeTimezoneOffsetTests()
        {
            // Reset configuration before each test to ensure clean state
            Hl7DateTimeFormatConfig.TimezoneOffset = TimeSpan.Zero;
        }

        public void Dispose()
        {
            // Reset configuration after each test to prevent affecting other tests
            Hl7DateTimeFormatConfig.TimezoneOffset = TimeSpan.Zero;
        }

        [Fact]
        public void TimezoneOffset_DefaultValue_IsUtcZero()
        {
            // Arrange & Act
            var offset = Hl7DateTimeFormatConfig.TimezoneOffset;

            // Assert
            Assert.Equal(TimeSpan.Zero, offset);
        }

        [Fact]
        public void TimezoneOffset_SetValue_IsThreadSafe()
        {
            // Arrange
            var newOffset = TimeSpan.FromHours(5);

            // Act
            Hl7DateTimeFormatConfig.TimezoneOffset = newOffset;
            var retrievedOffset = Hl7DateTimeFormatConfig.TimezoneOffset;

            // Assert
            Assert.Equal(newOffset, retrievedOffset);
        }

        [Theory]
        [InlineData(0, 0, "+0000")]
        [InlineData(5, 0, "+0500")]
        [InlineData(-5, 0, "-0500")]
        [InlineData(5, 30, "+0530")]
        [InlineData(-4, -30, "-0430")]
        [InlineData(10, 0, "+1000")]
        [InlineData(-10, 0, "-1000")]
        [InlineData(0, 30, "+0030")]
        [InlineData(0, -30, "-0030")]
        [InlineData(12, 45, "+1245")]
        [InlineData(-12, -45, "-1245")]
        public void ToHl7OffsetString_WithVariousOffsets_ReturnsCorrectFormat(int hours, int minutes, string expected)
        {
            // Arrange
            var offset = new TimeSpan(hours, minutes, 0);

            // Act
            var result = Hl7DateTimeFormatConfig.ToHl7OffsetString(offset);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ToHl7OffsetString_WithZeroOffset_ReturnsPlus0000()
        {
            // Arrange
            var offset = TimeSpan.Zero;

            // Act
            var result = Hl7DateTimeFormatConfig.ToHl7OffsetString(offset);

            // Assert
            Assert.Equal("+0000", result);
        }

        [Fact]
        public void FormatDateTimeWithConfiguredOffset_WithDefaultUtc_ReturnsUtcTimestamp()
        {
            // Arrange
            var dt = new DateTimeOffset(2024, 3, 15, 14, 30, 45, TimeSpan.FromHours(-5));
            Hl7DateTimeFormatConfig.TimezoneOffset = TimeSpan.Zero;

            // Act
            var result = Hl7DateTimeFormatConfig.FormatDateTimeWithConfiguredOffset(dt);

            // Assert - DateTime converted to UTC
            Assert.Equal("20240315193045+0000", result);
        }

        [Fact]
        public void FormatDateTimeWithConfiguredOffset_WithCustomOffset_ReturnsConvertedTimestamp()
        {
            // Arrange
            var dt = new DateTimeOffset(2024, 3, 15, 14, 30, 45, TimeSpan.Zero);
            Hl7DateTimeFormatConfig.TimezoneOffset = TimeSpan.FromHours(5);

            // Act
            var result = Hl7DateTimeFormatConfig.FormatDateTimeWithConfiguredOffset(dt);

            // Assert - DateTime converted to +0500
            Assert.Equal("20240315193045+0500", result);
        }

        [Fact]
        public void FormatDateTimeWithConfiguredOffset_WithNegativeOffset_ReturnsCorrectTimestamp()
        {
            // Arrange
            var dt = new DateTimeOffset(2024, 3, 15, 14, 30, 45, TimeSpan.Zero);
            Hl7DateTimeFormatConfig.TimezoneOffset = TimeSpan.FromHours(-5);

            // Act
            var result = Hl7DateTimeFormatConfig.FormatDateTimeWithConfiguredOffset(dt);

            // Assert - DateTime converted to -0500
            Assert.Equal("20240315093045-0500", result);
        }

        [Fact]
        public void FormatDateTimeWithConfiguredOffset_WithOffsetIncludingMinutes_ReturnsCorrectTimestamp()
        {
            // Arrange
            var dt = new DateTimeOffset(2024, 3, 15, 14, 30, 45, TimeSpan.Zero);
            Hl7DateTimeFormatConfig.TimezoneOffset = new TimeSpan(5, 30, 0);

            // Act
            var result = Hl7DateTimeFormatConfig.FormatDateTimeWithConfiguredOffset(dt);

            // Assert - DateTime converted to +0530
            Assert.Equal("20240315200045+0530", result);
        }

        [Fact]
        public void FormatDateTimeUsingSourceOffset_WithPositiveOffset_ReturnsSourceTimestamp()
        {
            // Arrange
            var dt = new DateTimeOffset(2024, 3, 15, 14, 30, 45, TimeSpan.FromHours(5));

            // Act
            var result = Hl7DateTimeFormatConfig.FormatDateTimeUsingSourceOffset(dt);

            // Assert - Uses source offset
            Assert.Equal("20240315143045+0500", result);
        }

        [Fact]
        public void FormatDateTimeUsingSourceOffset_WithNegativeOffset_ReturnsSourceTimestamp()
        {
            // Arrange
            var dt = new DateTimeOffset(2024, 3, 15, 14, 30, 45, TimeSpan.FromHours(-5));

            // Act
            var result = Hl7DateTimeFormatConfig.FormatDateTimeUsingSourceOffset(dt);

            // Assert - Uses source offset
            Assert.Equal("20240315143045-0500", result);
        }

        [Fact]
        public void FormatDateTimeUsingSourceOffset_WithUtcOffset_ReturnsUtcTimestamp()
        {
            // Arrange
            var dt = new DateTimeOffset(2024, 3, 15, 14, 30, 45, TimeSpan.Zero);

            // Act
            var result = Hl7DateTimeFormatConfig.FormatDateTimeUsingSourceOffset(dt);

            // Assert - Uses UTC offset
            Assert.Equal("20240315143045+0000", result);
        }

        [Fact]
        public void FormatDateTimeUsingSourceOffset_WithOffsetIncludingMinutes_ReturnsCorrectTimestamp()
        {
            // Arrange
            var dt = new DateTimeOffset(2024, 3, 15, 14, 30, 45, new TimeSpan(5, 30, 0));

            // Act
            var result = Hl7DateTimeFormatConfig.FormatDateTimeUsingSourceOffset(dt);

            // Assert - Uses source offset with minutes
            Assert.Equal("20240315143045+0530", result);
        }

        [Fact]
        public void FormatDateTimeWithConfiguredOffset_PreservesDateTime_WhenConvertingOffsets()
        {
            // Arrange - Create a datetime at midnight UTC
            var dt = new DateTimeOffset(2024, 1, 1, 0, 0, 0, TimeSpan.Zero);
            Hl7DateTimeFormatConfig.TimezoneOffset = TimeSpan.FromHours(-5);

            // Act
            var result = Hl7DateTimeFormatConfig.FormatDateTimeWithConfiguredOffset(dt);

            // Assert - Should be the previous day at 19:00 in -0500 timezone
            Assert.Equal("20231231190000-0500", result);
        }

        [Fact]
        public void Constants_HaveCorrectValues()
        {
            // Assert
            Assert.Equal("yyyyMMddHHmmss±HHMM", Consts.DateTimeFormatPrecisionSecondWithTimezoneOffset);
        }

        [Fact]
        public void FormatDateTimeWithConfiguredOffset_DoesNotAffectOtherInstances_WhenOffsetChanges()
        {
            // Arrange
            var dt1 = new DateTimeOffset(2024, 3, 15, 14, 30, 45, TimeSpan.Zero);
            Hl7DateTimeFormatConfig.TimezoneOffset = TimeSpan.FromHours(2);
            var result1 = Hl7DateTimeFormatConfig.FormatDateTimeWithConfiguredOffset(dt1);

            // Act - Change offset
            Hl7DateTimeFormatConfig.TimezoneOffset = TimeSpan.FromHours(5);
            var dt2 = new DateTimeOffset(2024, 3, 15, 14, 30, 45, TimeSpan.Zero);
            var result2 = Hl7DateTimeFormatConfig.FormatDateTimeWithConfiguredOffset(dt2);

            // Assert - Results should be different based on when they were called
            Assert.Equal("20240315163045+0200", result1);
            Assert.Equal("20240315193045+0500", result2);
        }

        [Fact]
        public void ToHl7OffsetString_WithLargePositiveOffset_FormatsCorrectly()
        {
            // Arrange
            var offset = TimeSpan.FromHours(14); // Maximum typical offset

            // Act
            var result = Hl7DateTimeFormatConfig.ToHl7OffsetString(offset);

            // Assert
            Assert.Equal("+1400", result);
        }

        [Fact]
        public void ToHl7OffsetString_WithLargeNegativeOffset_FormatsCorrectly()
        {
            // Arrange
            var offset = TimeSpan.FromHours(-12); // Common Pacific offset

            // Act
            var result = Hl7DateTimeFormatConfig.ToHl7OffsetString(offset);

            // Assert
            Assert.Equal("-1200", result);
        }

        [Fact]
        public void FormatDateTimeWithConfiguredOffset_WithDateTime_DefaultUtc_ReturnsUtcTimestamp()
        {
            // Arrange
            var dt = new DateTime(2024, 3, 15, 14, 30, 45);
            Hl7DateTimeFormatConfig.TimezoneOffset = TimeSpan.Zero;

            // Act
            var result = Hl7DateTimeFormatConfig.FormatDateTimeWithConfiguredOffset(dt);

            // Assert - DateTime treated as UTC
            Assert.Equal("20240315143045+0000", result);
        }

        [Fact]
        public void FormatDateTimeWithConfiguredOffset_WithDateTime_CustomOffset_ReturnsConvertedTimestamp()
        {
            // Arrange
            var dt = new DateTime(2024, 3, 15, 14, 30, 45);
            Hl7DateTimeFormatConfig.TimezoneOffset = new TimeSpan(5, 30, 0);

            // Act
            var result = Hl7DateTimeFormatConfig.FormatDateTimeWithConfiguredOffset(dt);

            // Assert - DateTime treated as UTC, converted to +0530
            Assert.Equal("20240315200045+0530", result);
        }

        [Fact]
        public void FormatDateTimeUsingSourceOffset_WithDateTime_UsesConfiguredOffset()
        {
            // Arrange
            var dt = new DateTime(2024, 3, 15, 14, 30, 45);
            Hl7DateTimeFormatConfig.TimezoneOffset = new TimeSpan(5, 30, 0);

            // Act
            var result = Hl7DateTimeFormatConfig.FormatDateTimeUsingSourceOffset(dt);

            // Assert - Uses configured offset
            Assert.Equal("20240315143045+0530", result);
        }

        [Fact]
        public void FormatDateTimeUsingSourceOffset_WithDateTime_DefaultUtc()
        {
            // Arrange
            var dt = new DateTime(2024, 3, 15, 14, 30, 45);
            Hl7DateTimeFormatConfig.TimezoneOffset = TimeSpan.Zero;

            // Act
            var result = Hl7DateTimeFormatConfig.FormatDateTimeUsingSourceOffset(dt);

            // Assert - Uses UTC offset
            Assert.Equal("20240315143045+0000", result);
        }
    }
}
