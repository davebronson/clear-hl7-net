using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class DspSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new DspSegment
            {
                SetIdDsp = 1,
                DisplayLevel = 2,
                DataLine = new Text
                {
                    Value = "3"
                },
                LogicalBreakPoint = "4",
                ResultId = new Text
                {
                    Value = "5"
                }
            };

            ISegment actual = new DspSegment();
            actual.FromDelimitedString("DSP|1|2|3|4|5");

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
                ISegment hl7Segment = new DspSegment();
                hl7Segment.FromDelimitedString("DSA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new DspSegment
            {
                SetIdDsp = 1,
                DisplayLevel = 2,
                DataLine = new Text
                {
                    Value = "3"
                },
                LogicalBreakPoint = "4",
                ResultId = new Text
                {
                    Value = "5"
                }
            };

            string expected = "DSP|1|2|3|4|5";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
