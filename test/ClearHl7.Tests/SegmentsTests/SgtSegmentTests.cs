using ClearHl7.Fhir.V290.Segments;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class SgtSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new SgtSegment
            {
                SetIdSgt = 1,
                SegmentGroupName = "2"
            };

            string expected = "SGT|1|2";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
