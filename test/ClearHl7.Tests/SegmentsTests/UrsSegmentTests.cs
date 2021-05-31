using ClearHl7.V282.Segments;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class UrsSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new UrsSegment
            {
                SegmentString = "1"
            };

            string expected = "URS|1";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
