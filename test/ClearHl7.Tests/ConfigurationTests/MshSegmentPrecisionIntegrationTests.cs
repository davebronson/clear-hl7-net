using System;
using ClearHl7.V251.Segments;
using ClearHl7.V251.Types;
using Xunit;

namespace ClearHl7.Tests.ConfigurationTests
{
    public class MshSegmentPrecisionIntegrationTests
    {
        private readonly DateTime _testDateTime = new DateTime(2020, 1, 15, 10, 3, 55);

        /// <summary>
        /// Validates that MSH segment uses configured DateTime precision for DateTimeOfMessage.
        /// </summary>
        [Fact]
        public void MshSegment_ToDelimitedString_UsesConfiguredDateTimePrecision()
        {
            // Save original configuration
            var originalPrecision = Configuration.DateTimePrecision;

            try
            {
                // Test with Minute precision
                Configuration.DateTimePrecision = DateTimePrecision.Minute;

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

                // The DateTime should be formatted with minute precision (202001151003)
                Assert.Contains("202001151003", result);
                Assert.DoesNotContain("20200115100355", result); // Should not contain full seconds

                // Test with Year precision
                Configuration.DateTimePrecision = DateTimePrecision.Year;

                string resultYear = mshSegment.ToDelimitedString();

                // The DateTime should now be formatted with year precision (2020)
                Assert.Contains("2020|", resultYear); // Looking for year followed by field separator
                Assert.DoesNotContain("202001", resultYear); // Should not contain month information
            }
            finally
            {
                // Restore original configuration
                Configuration.DateTimePrecision = originalPrecision;
            }
        }

        /// <summary>
        /// Validates backward compatibility - default precision should be Second.
        /// </summary>
        [Fact]
        public void MshSegment_ToDelimitedString_DefaultPrecisionIsSecond()
        {
            // Save original configuration
            var originalPrecision = Configuration.DateTimePrecision;

            try
            {
                // Ensure default is Second precision
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

                // The DateTime should be formatted with second precision (20200115100355)
                Assert.Contains("20200115100355", result);
            }
            finally
            {
                // Restore original configuration
                Configuration.DateTimePrecision = originalPrecision;
            }
        }
    }
}