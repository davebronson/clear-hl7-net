using ClearHl7.V290.Segments;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class MsaSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new MsaSegment
            {
                AcknowledgmentCode = "1",
                MessageControlId = "2",
                TextMessage = "3",
                ExpectedSequenceNumber = 4,
                DelayedAcknowledgmentType = "5",
                ErrorCondition = "6",
                MessageWaitingNumber = 7,
                MessageWaitingPriority = "8"
            };

            ISegment actual = new MsaSegment();
            actual.FromDelimitedString("MSA|1|2|3|4|5|6|7|8");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new MsaSegment
            {
                AcknowledgmentCode = "1",
                MessageControlId = "2",
                TextMessage = "3",
                ExpectedSequenceNumber = 4,
                DelayedAcknowledgmentType = "5",
                ErrorCondition = "6",
                MessageWaitingNumber = 7,
                MessageWaitingPriority = "8"
            };

            string expected = "MSA|1|2|3|4|5|6|7|8";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
