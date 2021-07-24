using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class EcdSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new EcdSegment
            {
                ReferenceCommandNumber = 1,
                RemoteControlCommand = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                ResponseRequired = "3",
                RequestedCompletionTime = "4",
                Parameters = new Text[]
                {
                    new Text
                    {
                        Value = "5"
                    }
                }
            };

            ISegment actual = new EcdSegment();
            actual.FromDelimitedString("ECD|1|2|3|4|5");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new EcdSegment
            {
                ReferenceCommandNumber = 1,
                RemoteControlCommand = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                ResponseRequired = "3",
                RequestedCompletionTime = "4",
                Parameters = new Text[]
                {
                    new Text
                    {
                        Value = "5"
                    }
                }
            };

            string expected = "ECD|1|2|3|4|5";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
