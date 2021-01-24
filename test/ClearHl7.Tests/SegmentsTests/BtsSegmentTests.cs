using ClearHl7.V290.Segments;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class BtsSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new BtsSegment
            {
                BatchMessageCount = "1",
                BatchComment = "2",
                BatchTotals = new decimal[]
                {
                    3
                }
            };

            string expected = "BTS|1|2|3";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
