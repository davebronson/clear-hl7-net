using System;
using ClearHl7.Extensions;
using ClearHl7.V251.Segments;
using ClearHl7.V251.Types;
using Xunit;

namespace ClearHl7.Tests.ConfigurationTests
{
    [Collection("Hl7DateTimeFormatConfig")]
    public class Hl7DateTimeFormatConfigTests : IDisposable
    {
        private readonly DateTime _testDateTime = new DateTime(2024, 3, 15, 14, 30, 45);

        public Hl7DateTimeFormatConfigTests()
        {
            // Clear any existing configurations before each test
            Hl7DateTimeFormatConfig.ClearFieldPrecisions();
            Hl7DateTimeFormatConfig.ClearGlobalOverride();
        }

        public void Dispose()
        {
            // Clean up after each test to prevent affecting other tests
            Hl7DateTimeFormatConfig.ClearFieldPrecisions();
            Hl7DateTimeFormatConfig.ClearGlobalOverride();
        }

        /// <summary>
        /// Validates Scenario 1: If Global Override IS NOT SET, then ALL date/time fields will have the original precision.
        /// </summary>
        [Fact]
        public void Scenario1_NoGlobalOverride_UsesOriginalPrecision()
        {
            // Arrange - No global override set, no field overrides set
            Assert.False(Hl7DateTimeFormatConfig.HasGlobalOverride);
            Assert.Equal(0, Hl7DateTimeFormatConfig.ConfiguredFieldCount);

            // Act
            string mshFormat = Hl7DateTimeFormatConfig.GetFormatForField(typeof(MshSegment), "DateTimeOfMessage", Consts.DateTimeFormatPrecisionSecond);

            // Assert - Should use original precision (second precision for MSH.DateTimeOfMessage)
            Assert.Equal(Consts.DateTimeFormatPrecisionSecond, mshFormat);
        }

        /// <summary>
        /// Validates Scenario 2: If the Global override IS SET, then ALL date/time fields will be changed to that precision.
        /// </summary>
        [Fact]
        public void Scenario2_GlobalOverrideSet_AllFieldsUseGlobalPrecision()
        {
            // Arrange - Set global override
            Hl7DateTimeFormatConfig.GlobalDateTimeFormatOverride = Consts.DateFormatPrecisionDay;
            Assert.True(Hl7DateTimeFormatConfig.HasGlobalOverride);

            // Act
            string mshFormat = Hl7DateTimeFormatConfig.GetFormatForField(typeof(MshSegment), "DateTimeOfMessage", Consts.DateTimeFormatPrecisionSecond);
            string evnFormat = Hl7DateTimeFormatConfig.GetFormatForField(typeof(EvnSegment), "RecordedDateTime", Consts.DateTimeFormatPrecisionSecond);

            // Assert - Both should use global override (day precision)
            Assert.Equal(Consts.DateFormatPrecisionDay, mshFormat);
            Assert.Equal(Consts.DateFormatPrecisionDay, evnFormat);
        }

        /// <summary>
        /// Validates Scenario 3: If the global override is NOT SET, but an individual field override is configured, 
        /// then ONLY that field will change its precision from the original code.
        /// </summary>
        [Fact]
        public void Scenario3_NoGlobalOverride_IndividualFieldOverride_OnlyThatFieldChanges()
        {
            // Arrange - No global override, but individual field override
            Hl7DateTimeFormatConfig.ClearFieldPrecisions(); // Ensure clean state
            Assert.False(Hl7DateTimeFormatConfig.HasGlobalOverride);
            Hl7DateTimeFormatConfig.SetPrecision<MshSegment>(x => x.DateTimeOfMessage, Consts.DateFormatPrecisionDay);
            
            // Act
            string mshFormat = Hl7DateTimeFormatConfig.GetFormatForField(typeof(MshSegment), "DateTimeOfMessage", Consts.DateTimeFormatPrecisionSecond);
            string evnFormat = Hl7DateTimeFormatConfig.GetFormatForField(typeof(EvnSegment), "RecordedDateTime", Consts.DateTimeFormatPrecisionSecond);

            // Assert - MSH field uses override, EVN field uses original precision
            Assert.Equal(Consts.DateFormatPrecisionDay, mshFormat);        // Overridden field
            Assert.Equal(Consts.DateTimeFormatPrecisionSecond, evnFormat); // Original precision
        }

        /// <summary>
        /// Validates Scenario 4: If the Global override IS SET, and individual field overrides are configured,
        /// then ALL date/time fields will be changed to the Global Precision Override, 
        /// except for those individual fields that have been overridden.
        /// </summary>
        [Fact]
        public void Scenario4_GlobalOverrideSet_IndividualFieldOverrides_GlobalPlusIndividualOverrides()
        {
            // Arrange - Set global override AND individual field override
            Hl7DateTimeFormatConfig.GlobalDateTimeFormatOverride = Consts.DateTimeFormatPrecisionMinute;
            Hl7DateTimeFormatConfig.SetPrecision<MshSegment>(x => x.DateTimeOfMessage, Consts.DateFormatPrecisionDay);
            
            // Act
            string mshFormat = Hl7DateTimeFormatConfig.GetFormatForField(typeof(MshSegment), "DateTimeOfMessage", Consts.DateTimeFormatPrecisionSecond);
            string evnFormat = Hl7DateTimeFormatConfig.GetFormatForField(typeof(EvnSegment), "RecordedDateTime", Consts.DateTimeFormatPrecisionSecond);

            // Assert 
            Assert.Equal(Consts.DateFormatPrecisionDay, mshFormat);          // Uses individual override
            Assert.Equal(Consts.DateTimeFormatPrecisionMinute, evnFormat);   // Uses global override
        }

        /// <summary>
        /// Validates that segments use the configuration when calling ToDelimitedString.
        /// </summary>
        [Fact]
        public void MshSegment_WithNoOverrides_UsesOriginalPrecision()
        {
            // Arrange - No overrides set
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

            // Assert - Should use original precision (second precision)
            Assert.Contains("20240315143045", result);
        }

        /// <summary>
        /// Validates that segments use global override when set.
        /// </summary>
        [Fact]
        public void MshSegment_WithGlobalOverride_UsesGlobalPrecision()
        {
            // Arrange - Set global override
            Hl7DateTimeFormatConfig.GlobalDateTimeFormatOverride = Consts.DateFormatPrecisionDay;

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

            // Assert - Should use global override (day precision)
            Assert.Contains("20240315", result);
            Assert.DoesNotContain("20240315143045", result); // Should not contain seconds
        }

        /// <summary>
        /// Validates that ClearGlobalOverride works correctly.
        /// </summary>
        [Fact]
        public void ClearGlobalOverride_RemovesGlobalOverride()
        {
            // Arrange
            Hl7DateTimeFormatConfig.GlobalDateTimeFormatOverride = Consts.DateFormatPrecisionDay;
            Assert.True(Hl7DateTimeFormatConfig.HasGlobalOverride);

            // Act
            Hl7DateTimeFormatConfig.ClearGlobalOverride();

            // Assert
            Assert.False(Hl7DateTimeFormatConfig.HasGlobalOverride);
            Assert.Null(Hl7DateTimeFormatConfig.GlobalDateTimeFormatOverride);
        }

        /// <summary>
        /// Validates that extension method with explicit precision still works.
        /// </summary>
        [Fact]
        public void ToHl7DateTimeString_WithExplicitPrecision_WorksRegardlessOfConfiguration()
        {
            // Arrange - Set global override
            Hl7DateTimeFormatConfig.GlobalDateTimeFormatOverride = Consts.DateFormatPrecisionDay;

            // Act - Use explicit precision
            string result = _testDateTime.ToHl7DateTimeString(DateTimePrecision.Minute);

            // Assert - Should use explicit precision, ignoring global override
            Assert.Equal("202403151430", result);
        }
    }
}