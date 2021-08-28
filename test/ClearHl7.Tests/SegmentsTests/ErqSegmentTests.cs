using System;
using ClearHl7.V251.Segments;
using ClearHl7.V251.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class ErqSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new ErqSegment
            {
                QueryTag = "1",
                EventIdentifier = new CodedElement
                {
                    Identifier = "2"
                },
                InputParameterList = new QueryInputParameterList
                {
                    SegmentFieldName = "3"
                }
            };

            ISegment actual = new ErqSegment();
            actual.FromDelimitedString("ERQ|1|2|3");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that calling FromDelimitedString() with a string input containing an incorrect segment ID results in an ArgumentException being thrown.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithIncorrectSegmentId_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ISegment hl7Segment = new ErqSegment();
                hl7Segment.FromDelimitedString("ERA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new ErqSegment
            {
                QueryTag = "1",
                EventIdentifier = new CodedElement
                {
                    Identifier = "2"
                },
                InputParameterList = new QueryInputParameterList
                {
                    SegmentFieldName = "3"
                }
            };

            string expected = "ERQ|1|2|3";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
