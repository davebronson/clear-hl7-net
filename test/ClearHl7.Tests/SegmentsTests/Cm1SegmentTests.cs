using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Cm1SegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new Cm1Segment
            {
                SetIdCm1 = 1,
                StudyPhaseIdentifier = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                DescriptionOfStudyPhase = "3"
            };
            ISegment actual = new Cm1Segment().FromDelimitedString("CM1|1|2|3");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Cm1Segment
            {
                SetIdCm1 = 1,
                StudyPhaseIdentifier = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                DescriptionOfStudyPhase = "3"
            };

            string expected = "CM1|1|2|3";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
