using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Om5SegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Om5Segment
            {
                SequenceNumberTestObservationMasterFile = 1,
                TestObservationsIncludedWithinAnOrderedTestBattery = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "2"
                    }
                },
                ObservationIdSuffixes = "3"
            };

            string expected = "OM5|1|2|3";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
