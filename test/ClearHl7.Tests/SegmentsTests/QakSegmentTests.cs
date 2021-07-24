using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class QakSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new QakSegment
            {
                QueryTag = "1",
                QueryResponseStatus = "2",
                MessageQueryName = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                HitCountTotal = 4,
                ThisPayload = 5,
                HitsRemaining = 6
            };

            ISegment actual = new QakSegment();
            actual.FromDelimitedString("QAK|1|2|3|4|5|6");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new QakSegment
            {
                QueryTag = "1",
                QueryResponseStatus = "2",
                MessageQueryName = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                HitCountTotal = 4,
                ThisPayload = 5,
                HitsRemaining = 6
            };

            string expected = "QAK|1|2|3|4|5|6";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
