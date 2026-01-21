using System;
using ClearHl7.V270.Segments;
using ClearHl7.V270.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class ZxxSegmentV270Tests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new ZxxSegment
            {
                SegmentItems = new IType[]
                {
                    new Text
                    {
                        Value = "1"
                    }
                }
            };

            ISegment actual = new ZxxSegment();
            actual.FromDelimitedString("ZXX|1");

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
                ISegment hl7Segment = new ZxxSegment();
                hl7Segment.FromDelimitedString("AAA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new ZxxSegment
            {
                SegmentItems = new IType[]
                {
                    new Text
                    {
                        Value = "1"
                    }
                }
            };

            string expected = "ZXX|1";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
