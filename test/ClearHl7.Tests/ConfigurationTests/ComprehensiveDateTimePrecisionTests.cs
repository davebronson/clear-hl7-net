using System;
using ClearHl7.V251.Segments;
using ClearHl7.V251.Types;
using Xunit;

namespace ClearHl7.Tests.ConfigurationTests
{
    public class ComprehensiveDateTimePrecisionTests
    {
        private readonly DateTime _testDateTime = new DateTime(2024, 3, 15, 14, 30, 45);

        /// <summary>
        /// Validates that multiple segments use the configured DateTime precision consistently.
        /// </summary>
        [Fact]
        public void MultipleSegments_UseSameConfiguredPrecision()
        {
            // Save original configuration
            var originalPrecision = Configuration.DateTimePrecision;

            try
            {
                // Test with Hour precision
                Configuration.DateTimePrecision = DateTimePrecision.Hour;

                // Create MSH segment
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

                var mshSegment = new MshSegment(_testDateTime, messageType, "12345", processingType);

                // Create EVN segment
                var evnSegment = new EvnSegment
                {
                    EventTypeCode = "A01",
                    RecordedDateTime = _testDateTime,
                    DateTimePlannedEvent = _testDateTime,
                    EventOccurred = _testDateTime
                };

                string mshResult = mshSegment.ToDelimitedString();
                string evnResult = evnSegment.ToDelimitedString();

                // Both segments should use hour precision (2024031514)
                string expectedDateTime = "2024031514";

                Assert.Contains(expectedDateTime, mshResult);
                Assert.Contains(expectedDateTime, evnResult);

                // Verify they don't contain minute-level precision
                Assert.DoesNotContain("202403151430", mshResult);
                Assert.DoesNotContain("202403151430", evnResult);
            }
            finally
            {
                // Restore original configuration
                Configuration.DateTimePrecision = originalPrecision;
            }
        }

        /// <summary>
        /// Validates that changing precision during runtime affects all subsequent formatting.
        /// </summary>
        [Fact]
        public void RuntimePrecisionChange_AffectsAllSubsequentFormatting()
        {
            // Save original configuration
            var originalPrecision = Configuration.DateTimePrecision;

            try
            {
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

                // Start with Day precision
                Configuration.DateTimePrecision = DateTimePrecision.Day;
                var mshSegment1 = new MshSegment(_testDateTime, messageType, "MSG001", processingType);
                string result1 = mshSegment1.ToDelimitedString();

                // Change to Year precision
                Configuration.DateTimePrecision = DateTimePrecision.Year;
                var mshSegment2 = new MshSegment(_testDateTime, messageType, "MSG002", processingType);
                string result2 = mshSegment2.ToDelimitedString();

                // Verify different precisions were applied
                Assert.Contains("20240315", result1); // Day precision
                Assert.Contains("2024|", result2);     // Year precision followed by field separator
                Assert.DoesNotContain("20240315", result2); // Should not contain day info in year precision
            }
            finally
            {
                // Restore original configuration
                Configuration.DateTimePrecision = originalPrecision;
            }
        }

        /// <summary>
        /// Validates backward compatibility - default precision should produce same results as before.
        /// </summary>
        [Fact]
        public void BackwardCompatibility_DefaultPrecisionMatchesOriginalBehavior()
        {
            // Save original configuration
            var originalPrecision = Configuration.DateTimePrecision;

            try
            {
                // Ensure we're using default (Second) precision
                Configuration.DateTimePrecision = DateTimePrecision.Second;

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

                var mshSegment = new MshSegment(_testDateTime, messageType, "12345", processingType);
                string result = mshSegment.ToDelimitedString();

                // Should contain full second precision (20240315143045)
                Assert.Contains("20240315143045", result);
            }
            finally
            {
                // Restore original configuration
                Configuration.DateTimePrecision = originalPrecision;
            }
        }

        /// <summary>
        /// Validates that null DateTime values are handled correctly regardless of precision.
        /// </summary>
        [Fact]
        public void NullDateTimeValues_HandledCorrectlyWithAnyPrecision()
        {
            // Save original configuration
            var originalPrecision = Configuration.DateTimePrecision;

            try
            {
                Configuration.DateTimePrecision = DateTimePrecision.Minute;

                var evnSegment = new EvnSegment
                {
                    EventTypeCode = "A01",
                    RecordedDateTime = null, // null DateTime
                    DateTimePlannedEvent = _testDateTime, // non-null DateTime
                    EventOccurred = null // null DateTime
                };

                string result = evnSegment.ToDelimitedString();

                // Should contain the formatted non-null DateTime with minute precision
                Assert.Contains("202403151430", result);
                
                // The result should still be properly formatted even with null values
                Assert.Contains("EVN|A01|", result);
            }
            finally
            {
                // Restore original configuration
                Configuration.DateTimePrecision = originalPrecision;
            }
        }

        /// <summary>
        /// Validates that extreme precision levels work correctly.
        /// </summary>
        [Theory]
        [InlineData(DateTimePrecision.Year, "2024")]
        [InlineData(DateTimePrecision.Month, "202403")]
        [InlineData(DateTimePrecision.Day, "20240315")]
        [InlineData(DateTimePrecision.Hour, "2024031514")]
        [InlineData(DateTimePrecision.Minute, "202403151430")]
        [InlineData(DateTimePrecision.Second, "20240315143045")]
        public void AllPrecisionLevels_ProduceExpectedFormats(DateTimePrecision precision, string expectedFormat)
        {
            // Save original configuration
            var originalPrecision = Configuration.DateTimePrecision;

            try
            {
                Configuration.DateTimePrecision = precision;

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

                var mshSegment = new MshSegment(_testDateTime, messageType, "12345", processingType);
                string result = mshSegment.ToDelimitedString();

                Assert.Contains(expectedFormat, result);
            }
            finally
            {
                // Restore original configuration
                Configuration.DateTimePrecision = originalPrecision;
            }
        }
    }
}