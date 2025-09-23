using System;
using ClearHl7.Extensions;
using ClearHl7.V251.Segments;
using ClearHl7.V251.Types;
using Xunit;

namespace ClearHl7.Tests.ConfigurationTests
{
    public class Hl7DateTimeFormatConfigTests
    {
        private readonly DateTime _testDateTime = new DateTime(2024, 3, 15, 14, 30, 45);

        public Hl7DateTimeFormatConfigTests()
        {
            // Clear any existing field configurations before each test
            Hl7DateTimeFormatConfig.ClearFieldPrecisions();
        }

        /// <summary>
        /// Validates the default DateTime format is used when no per-field configuration exists.
        /// </summary>
        [Fact]
        public void GetFormatForField_WithNoSpecificConfiguration_ReturnsDefault()
        {
            // Arrange
            var originalDefault = Hl7DateTimeFormatConfig.DefaultDateTimeFormat;
            try
            {
                Hl7DateTimeFormatConfig.DefaultDateTimeFormat = Consts.DateTimeFormatPrecisionMinute;

                // Act
                string format = Hl7DateTimeFormatConfig.GetFormatForField(typeof(MshSegment), "DateTimeOfMessage");

                // Assert
                Assert.Equal(Consts.DateTimeFormatPrecisionMinute, format);
            }
            finally
            {
                Hl7DateTimeFormatConfig.DefaultDateTimeFormat = originalDefault;
            }
        }

        /// <summary>
        /// Validates that per-field configuration overrides the default.
        /// </summary>
        [Fact]
        public void SetPrecision_WithFieldSpecificConfiguration_OverridesDefault()
        {
            // Arrange
            var originalDefault = Hl7DateTimeFormatConfig.DefaultDateTimeFormat;
            try
            {
                Hl7DateTimeFormatConfig.DefaultDateTimeFormat = Consts.DateTimeFormatPrecisionSecond;
                
                // Act
                Hl7DateTimeFormatConfig.SetPrecision<MshSegment>(x => x.DateTimeOfMessage, Consts.DateFormatPrecisionDay);
                string format = Hl7DateTimeFormatConfig.GetFormatForField(typeof(MshSegment), "DateTimeOfMessage");

                // Assert
                Assert.Equal(Consts.DateFormatPrecisionDay, format);
                Assert.Equal(1, Hl7DateTimeFormatConfig.ConfiguredFieldCount);
            }
            finally
            {
                Hl7DateTimeFormatConfig.DefaultDateTimeFormat = originalDefault;
                Hl7DateTimeFormatConfig.ClearFieldPrecisions();
            }
        }

        /// <summary>
        /// Validates that different fields can have different configurations.
        /// </summary>
        [Fact]
        public void SetPrecision_WithMultipleFields_AllowsDifferentConfigurations()
        {
            // Arrange & Act
            Hl7DateTimeFormatConfig.SetPrecision<MshSegment>(x => x.DateTimeOfMessage, Consts.DateTimeFormatPrecisionMinute);
            Hl7DateTimeFormatConfig.SetPrecision<EvnSegment>(x => x.RecordedDateTime, Consts.DateFormatPrecisionDay);

            // Assert
            string mshFormat = Hl7DateTimeFormatConfig.GetFormatForField(typeof(MshSegment), "DateTimeOfMessage");
            string evnFormat = Hl7DateTimeFormatConfig.GetFormatForField(typeof(EvnSegment), "RecordedDateTime");

            Assert.Equal(Consts.DateTimeFormatPrecisionMinute, mshFormat);
            Assert.Equal(Consts.DateFormatPrecisionDay, evnFormat);
            Assert.Equal(2, Hl7DateTimeFormatConfig.ConfiguredFieldCount);
        }

        /// <summary>
        /// Validates that the extension method uses per-field configuration.
        /// </summary>
        [Fact]
        public void ToHl7DateTimeString_WithPerFieldConfiguration_UsesFieldSpecificFormat()
        {
            // Arrange
            var originalDefault = Hl7DateTimeFormatConfig.DefaultDateTimeFormat;
            try
            {
                Hl7DateTimeFormatConfig.DefaultDateTimeFormat = Consts.DateTimeFormatPrecisionSecond;
                Hl7DateTimeFormatConfig.SetPrecision<MshSegment>(x => x.DateTimeOfMessage, Consts.DateFormatPrecisionDay);

                // Act
                string defaultFormat = _testDateTime.ToHl7DateTimeString(typeof(EvnSegment), "RecordedDateTime");
                string specificFormat = _testDateTime.ToHl7DateTimeString(typeof(MshSegment), "DateTimeOfMessage");

                // Assert
                Assert.Equal("20240315143045", defaultFormat); // Uses default (second precision)
                Assert.Equal("20240315", specificFormat);      // Uses field-specific (day precision)
            }
            finally
            {
                Hl7DateTimeFormatConfig.DefaultDateTimeFormat = originalDefault;
                Hl7DateTimeFormatConfig.ClearFieldPrecisions();
            }
        }

        /// <summary>
        /// Validates that nullable DateTime works with per-field configuration.
        /// </summary>
        [Fact]
        public void ToHl7DateTimeString_WithNullableDateTime_WorksCorrectly()
        {
            // Arrange
            DateTime? nullableDateTime = _testDateTime;
            DateTime? nullDateTime = null;

            Hl7DateTimeFormatConfig.SetPrecision<MshSegment>(x => x.DateTimeOfMessage, Consts.DateFormatPrecisionDay);

            // Act
            string result1 = nullableDateTime.ToHl7DateTimeString(typeof(MshSegment), "DateTimeOfMessage");
            string result2 = nullDateTime.ToHl7DateTimeString(typeof(MshSegment), "DateTimeOfMessage");

            // Assert
            Assert.Equal("20240315", result1);
            Assert.Null(result2);
        }

        /// <summary>
        /// Validates that segments use the per-field configuration when calling ToDelimitedString.
        /// </summary>
        [Fact]
        public void MshSegment_WithFieldConfiguration_UsesConfiguredPrecision()
        {
            // Arrange
            var originalDefault = Hl7DateTimeFormatConfig.DefaultDateTimeFormat;
            try
            {
                Hl7DateTimeFormatConfig.DefaultDateTimeFormat = Consts.DateTimeFormatPrecisionSecond;
                Hl7DateTimeFormatConfig.SetPrecision<MshSegment>(x => x.DateTimeOfMessage, Consts.DateFormatPrecisionDay);

                var messageType = new MessageType
                {
                    MessageCode = "ADT",
                    TriggerEvent = "A01",
                    MessageStructure = "ADT_A01"
                };

                var processingType = new ProcessingType
                {
                    ProcessingId = "P"
                };

                var mshSegment = new MshSegment(_testDateTime, messageType, "MSG001", processingType);

                // Act
                string result = mshSegment.ToDelimitedString();

                // Assert
                Assert.Contains("20240315", result);          // Should use day precision
                Assert.DoesNotContain("20240315143045", result); // Should not use second precision
            }
            finally
            {
                Hl7DateTimeFormatConfig.DefaultDateTimeFormat = originalDefault;
                Hl7DateTimeFormatConfig.ClearFieldPrecisions();
            }
        }

        /// <summary>
        /// Validates backward compatibility - without configuration, existing behavior is preserved.
        /// </summary>
        [Fact]
        public void MshSegment_WithoutConfiguration_UsesDefaultSecondPrecision()
        {
            // Arrange
            var originalDefault = Hl7DateTimeFormatConfig.DefaultDateTimeFormat;
            try
            {
                // Ensure default is second precision (existing behavior)
                Hl7DateTimeFormatConfig.DefaultDateTimeFormat = Consts.DateTimeFormatPrecisionSecond;

                var messageType = new MessageType
                {
                    MessageCode = "ADT",
                    TriggerEvent = "A01",
                    MessageStructure = "ADT_A01"
                };

                var processingType = new ProcessingType
                {
                    ProcessingId = "P"
                };

                var mshSegment = new MshSegment(_testDateTime, messageType, "MSG001", processingType);

                // Act
                string result = mshSegment.ToDelimitedString();

                // Assert
                Assert.Contains("20240315143045", result); // Should use second precision by default
            }
            finally
            {
                Hl7DateTimeFormatConfig.DefaultDateTimeFormat = originalDefault;
            }
        }

        /// <summary>
        /// Validates that expression-based configuration handles nullable types correctly.
        /// </summary>
        [Fact]
        public void SetPrecision_WithNullableProperty_ConfiguresCorrectly()
        {
            // Act & Assert - Should not throw exception
            Hl7DateTimeFormatConfig.SetPrecision<EvnSegment>(x => x.RecordedDateTime, Consts.DateFormatPrecisionDay);
            
            string format = Hl7DateTimeFormatConfig.GetFormatForField(typeof(EvnSegment), "RecordedDateTime");
            Assert.Equal(Consts.DateFormatPrecisionDay, format);
        }

        /// <summary>
        /// Validates that ClearFieldPrecisions works correctly.
        /// </summary>
        [Fact]
        public void ClearFieldPrecisions_RemovesAllConfigurations()
        {
            // Arrange
            Hl7DateTimeFormatConfig.SetPrecision<MshSegment>(x => x.DateTimeOfMessage, Consts.DateFormatPrecisionDay);
            Hl7DateTimeFormatConfig.SetPrecision<EvnSegment>(x => x.RecordedDateTime, Consts.DateFormatPrecisionMonth);
            Assert.Equal(2, Hl7DateTimeFormatConfig.ConfiguredFieldCount);

            // Act
            Hl7DateTimeFormatConfig.ClearFieldPrecisions();

            // Assert
            Assert.Equal(0, Hl7DateTimeFormatConfig.ConfiguredFieldCount);
        }
    }
}