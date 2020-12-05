using ClearHl7.Fhir.V282.Segments;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class DscSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new DscSegment
            {
                ContinuationPointer = "1",
                ContinuationStyle = "2"
            };

            string expected = "DSC|1|2";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
