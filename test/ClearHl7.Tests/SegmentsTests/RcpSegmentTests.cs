using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class RcpSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new RcpSegment
            {
                QueryPriority = "1",
                QuantityLimitedRequest = new CompositeQuantityWithUnits
                {
                    Quantity = 2
                },
                ResponseModality = new CodedWithNoExceptions
                {
                    Identifier = "3"
                },
                ExecutionAndDeliveryTime = new DateTime(2020, 4, 4, 0, 0, 4),
                ModifyIndicator = "5",
                SortByField = new SortOrder[]
                {
                    new SortOrder
                    {
                        SortByField = "6"
                    }
                },
                SegmentGroupInclusion = new string[]
                {
                    "7"
                }
            };

            string expected = "RCP|1|2|3|20200404000004|5|6|7";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
