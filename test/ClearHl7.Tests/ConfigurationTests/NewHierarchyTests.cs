using System;
using ClearHl7;
using ClearHl7.Extensions;
using ClearHl7.V251.Segments;
using Xunit;

namespace ClearHl7.Tests.ConfigurationTests
{
    public class NewHierarchyTests
    {
        private readonly DateTime _testDateTime = new DateTime(2024, 3, 15, 14, 30, 45);

        public NewHierarchyTests()
        {
            // Clear any existing configurations to ensure clean test state
            Hl7DateTimeFormatConfig.ClearFieldPrecisions();
            Hl7DateTimeFormatConfig.ClearGlobalOverride();
        }

        [Fact]
        public void NewApproach_NoOverrides_UsesOriginalCodeDefinedPrecision()
        {
            // Arrange - Use new approach with explicit original format
            string originalFormat = Consts.DateTimeFormatPrecisionMinute; // Different from Second to test
            
            // Act - Use new extension method with explicit original format
            string result = _testDateTime.ToHl7DateTimeString(typeof(MshSegment), "TestProperty", originalFormat, System.Globalization.CultureInfo.CurrentCulture);
            
            // Assert - Should use the original format specified in code
            string expected = _testDateTime.ToString(originalFormat, System.Globalization.CultureInfo.CurrentCulture);
            Assert.Equal(expected, result);
            Assert.Equal("202403151430", result); // Minute precision
        }

        [Fact]
        public void NewApproach_WithGlobalOverride_UsesGlobalOverride()
        {
            // Arrange
            string originalFormat = Consts.DateTimeFormatPrecisionMinute;
            Hl7DateTimeFormatConfig.GlobalDateTimeFormatOverride = Consts.DateFormatPrecisionDay;
            
            // Act
            string result = _testDateTime.ToHl7DateTimeString(typeof(MshSegment), "TestProperty", originalFormat, System.Globalization.CultureInfo.CurrentCulture);
            
            // Assert - Should use global override instead of original format
            Assert.Equal("20240315", result); // Day precision from global override
        }

        [Fact]
        public void NewApproach_WithIndividualFieldOverride_UsesFieldOverride()
        {
            // Arrange
            string originalFormat = Consts.DateTimeFormatPrecisionMinute;
            Hl7DateTimeFormatConfig.GlobalDateTimeFormatOverride = Consts.DateFormatPrecisionDay;
            Hl7DateTimeFormatConfig.SetPrecision<MshSegment>(x => x.DateTimeOfMessage, Consts.DateFormatPrecisionYear);
            
            // Act
            string result = _testDateTime.ToHl7DateTimeString(typeof(MshSegment), "DateTimeOfMessage", originalFormat, System.Globalization.CultureInfo.CurrentCulture);
            
            // Assert - Should use individual field override (highest priority)
            Assert.Equal("2024", result); // Year precision from field override
        }

        [Fact]  
        public void NewApproach_DifferentFieldSameSegment_UsesCorrectOverride()
        {
            // Arrange
            Hl7DateTimeFormatConfig.ClearFieldPrecisions(); // Ensure clean state
            string originalFormat = Consts.DateTimeFormatPrecisionSecond;
            Hl7DateTimeFormatConfig.SetPrecision<MshSegment>(x => x.DateTimeOfMessage, Consts.DateFormatPrecisionYear);
            
            // Act - Test field with override
            string resultWithOverride = _testDateTime.ToHl7DateTimeString(typeof(MshSegment), "DateTimeOfMessage", originalFormat, System.Globalization.CultureInfo.CurrentCulture);
            // Act - Test different field without override
            string resultWithoutOverride = _testDateTime.ToHl7DateTimeString(typeof(MshSegment), "OtherProperty", originalFormat, System.Globalization.CultureInfo.CurrentCulture);
            
            // Assert
            Assert.Equal("2024", resultWithOverride); // Uses field override
            Assert.Equal("20240315143045", resultWithoutOverride); // Uses original format
        }
    }
}