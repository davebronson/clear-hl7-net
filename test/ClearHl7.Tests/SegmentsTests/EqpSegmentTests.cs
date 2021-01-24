using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class EqpSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new EqpSegment
            {
                EventType = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                FileName = "2",
                StartDateTime = new DateTime(2020, 3, 3, 0, 0, 3),
                EndDateTime = new DateTime(2020, 4, 4, 0, 0, 4),
                TransactionData = "5"
            };

            string expected = "EQP|1|2|20200303000003|20200404000004|5";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
