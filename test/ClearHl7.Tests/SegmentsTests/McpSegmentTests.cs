using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class McpSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new McpSegment
            {
                SetIdMcp = 1,
                ProducersServiceTestObservationId = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                UniversalServicePriceRangeLowValue = new Money
                {
                    Quantity = 3
                },
                UniversalServicePriceRangeHighValue = new Money
                {
                    Quantity = 4
                },
                ReasonForUniversalServiceCostRange = "5"
            };

            string expected = "MCP|1|2|3|4|5";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
