using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class CtiSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new CtiSegment
            {
                SponsorStudyId = new EntityIdentifier
                {
                    EntityId = "1"
                },
                StudyPhaseIdentifier = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                StudyScheduledTimePoint = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                ActionCode = "4"
            };

            string expected = "CTI|1|2|3|4";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
