using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Om6SegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new Om6Segment
            {
                SequenceNumberTestObservationMasterFile = 1,
                DerivationRule = new Text
                {
                    Value = "2"
                }
            };
            ISegment actual = new Om6Segment().FromDelimitedString("OM6|1|2");

            expected.Should().BeEquivalentTo(actual);
        }
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Om6Segment
            {
                SequenceNumberTestObservationMasterFile = 1,
                DerivationRule = new Text
                {
                    Value = "2"
                }
            };

            string expected = "OM6|1|2";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
