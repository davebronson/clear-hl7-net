using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class StzSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new StzSegment
            {
                SterilizationType = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                SterilizationCycle = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                MaintenanceCycle = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                MaintenanceType = new CodedWithExceptions
                {
                    Identifier = "4"
                }
            };

            ISegment actual = new StzSegment();
            actual.FromDelimitedString("STZ|1|2|3|4");

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
                ISegment hl7Segment = new StzSegment();
                hl7Segment.FromDelimitedString("STA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new StzSegment
            {
                SterilizationType = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                SterilizationCycle = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                MaintenanceCycle = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                MaintenanceType = new CodedWithExceptions
                {
                    Identifier = "4"
                }
            };

            string expected = "STZ|1|2|3|4";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
