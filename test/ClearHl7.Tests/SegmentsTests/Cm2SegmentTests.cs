using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Cm2SegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Cm2Segment
            {
                SetIdCm2 = 1,
                ScheduledTimePoint = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                DescriptionOfTimePoint = "3",
                EventsScheduledThisTimePoint = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "4"
                    }
                }
            };

            string expected = "CM2|1|2|3|4";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
