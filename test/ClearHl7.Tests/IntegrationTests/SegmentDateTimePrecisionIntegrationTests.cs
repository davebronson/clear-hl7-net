using System;
using ClearHl7;
using ClearHl7.V251.Segments;
using ClearHl7.V251.Types;
using Xunit;

namespace ClearHl7.Tests.IntegrationTests
{
    /// <summary>
    /// Integration tests to verify that the new DateTime precision hierarchy works correctly in real segments.
    /// </summary>
    [Collection("Hl7DateTimeFormatConfig")]
    public class SegmentDateTimePrecisionIntegrationTests : IDisposable
    {
        public SegmentDateTimePrecisionIntegrationTests()
        {
            // Ensure clean test state
            Hl7DateTimeFormatConfig.ClearFieldPrecisions();
            Hl7DateTimeFormatConfig.ClearGlobalOverride();
        }

        public void Dispose()
        {
            // Clean up after each test to prevent affecting other tests
            Hl7DateTimeFormatConfig.ClearFieldPrecisions();
            Hl7DateTimeFormatConfig.ClearGlobalOverride();
        }

        [Fact]
        public void MshSegment_WithNoConfiguration_UsesOriginalCodeDefinedPrecision()
        {
            // Arrange
            var dateTime = new DateTime(2024, 3, 15, 14, 30, 45);
            var messageType = new MessageType { MessageCode = "ADT", TriggerEvent = "A01", MessageStructure = "ADT_A01" };
            var processingType = new ProcessingType { ProcessingId = "P" };
            
            var segment = new MshSegment(dateTime, messageType, "MSG001", processingType);
            
            // Act
            string delimitedString = segment.ToDelimitedString();
            
            // Assert - DateTimeOfMessage should use second precision (the original code-defined precision)
            // The delimited string contains: MSH|^~\&|||||20240315143045||...
            Assert.Contains("20240315143045", delimitedString); // Second precision format
        }

        [Fact]
        public void MshSegment_WithGlobalOverride_UsesGlobalPrecision()
        {
            // Arrange
            var dateTime = new DateTime(2024, 3, 15, 14, 30, 45);
            var messageType = new MessageType { MessageCode = "ADT", TriggerEvent = "A01", MessageStructure = "ADT_A01" };
            var processingType = new ProcessingType { ProcessingId = "P" };
            
            // Set global override to day precision
            Hl7DateTimeFormatConfig.GlobalDateTimeFormatOverride = Consts.DateFormatPrecisionDay;
            
            var segment = new MshSegment(dateTime, messageType, "MSG001", processingType);
            
            // Act
            string delimitedString = segment.ToDelimitedString();
            
            // Assert - Should use global override (day precision) instead of original (second precision)
            Assert.Contains("20240315", delimitedString); // Day precision format
            Assert.DoesNotContain("20240315143045", delimitedString); // Should not contain second precision
        }

        [Fact]
        public void MshSegment_WithIndividualFieldOverride_UsesFieldOverride()
        {
            // Arrange
            var dateTime = new DateTime(2024, 3, 15, 14, 30, 45);
            var messageType = new MessageType { MessageCode = "ADT", TriggerEvent = "A01", MessageStructure = "ADT_A01" };
            var processingType = new ProcessingType { ProcessingId = "P" };
            
            // Set global override AND individual field override
            Hl7DateTimeFormatConfig.GlobalDateTimeFormatOverride = Consts.DateFormatPrecisionDay;
            Hl7DateTimeFormatConfig.SetPrecision<MshSegment>(x => x.DateTimeOfMessage, Consts.DateFormatPrecisionYear);
            
            var segment = new MshSegment(dateTime, messageType, "MSG001", processingType);
            
            // Act
            string delimitedString = segment.ToDelimitedString();
            
            // Assert - Should use individual field override (year precision) despite global override
            Assert.Contains("2024", delimitedString); // Year precision format
            Assert.DoesNotContain("20240315", delimitedString); // Should not contain day precision
            Assert.DoesNotContain("20240315143045", delimitedString); // Should not contain second precision
        }

        [Fact]
        public void EvnSegment_WithMixedConfiguration_UsesCorrectPrecisions()
        {
            // Arrange
            var dateTime = new DateTime(2024, 3, 15, 14, 30, 45);
            
            // Set individual override for one field, leave others to use original code precision
            Hl7DateTimeFormatConfig.SetPrecision<EvnSegment>(x => x.RecordedDateTime, Consts.DateTimeFormatPrecisionMinute);
            
            var segment = new EvnSegment
            {
                EventTypeCode = "A01",
                RecordedDateTime = dateTime,
                DateTimePlannedEvent = dateTime,
                EventOccurred = dateTime
            };
            
            // Act
            string delimitedString = segment.ToDelimitedString();
            
            // Assert
            // RecordedDateTime should use the individual field override (minute precision)
            // DateTimePlannedEvent and EventOccurred should use original code precision (second precision)
            
            string[] fields = delimitedString.Split('|');
            
            // EVN|A01|202403151430|20240315143045||20240315143045|
            // Field 2 (RecordedDateTime) should be minute precision
            Assert.Equal("202403151430", fields[2]); // Minute precision
            
            // Field 3 (DateTimePlannedEvent) should be second precision (original)
            Assert.Equal("20240315143045", fields[3]); // Second precision
            
            // Field 6 (EventOccurred) should be second precision (original)  
            Assert.Equal("20240315143045", fields[6]); // Second precision
        }
    }
}