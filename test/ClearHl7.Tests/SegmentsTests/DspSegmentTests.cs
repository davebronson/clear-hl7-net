using ClearHl7.Fhir.V290.Segments;
using ClearHl7.Fhir.V290.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class DspSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new DspSegment
            {
                SetIdDsp = 1,
                DisplayLevel = 2,
                DataLine = new Text
                {
                    Value = "3"
                },
                LogicalBreakPoint = "4",
                ResultId = new Text
                {
                    Value = "5"
                }
            };

            string expected = "DSP|1|2|3|4|5";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
