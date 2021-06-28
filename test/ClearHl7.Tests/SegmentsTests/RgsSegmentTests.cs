using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class RgsSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new RgsSegment
            {
                SetIdRgs = 1,
                SegmentActionCode = "2",
                ResourceGroupId = new CodedWithExceptions
                {
                    Identifier = "3"
                }
            };
            ISegment actual = new RgsSegment().FromDelimitedString("RGS|1|2|3");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new RgsSegment
            {
                SetIdRgs = 1,
                SegmentActionCode = "2",
                ResourceGroupId = new CodedWithExceptions
                {
                    Identifier = "3"
                }
            };

            string expected = "RGS|1|2|3";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
