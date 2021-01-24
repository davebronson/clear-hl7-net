using ClearHl7.V282.Segments;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class UrdSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new UrdSegment
            {
                SegmentString = "1"
            };

            string expected = "URD|1";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
