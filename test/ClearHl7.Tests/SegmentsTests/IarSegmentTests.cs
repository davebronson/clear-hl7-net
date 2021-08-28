using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class IarSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new IarSegment
            {
                AllergyReactionCode = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                AllergySeverityCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                SensitivityToCausativeAgentCode = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                Management = "4"
            };

            ISegment actual = new IarSegment();
            actual.FromDelimitedString("IAR|1|2|3|4");

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
                ISegment hl7Segment = new IarSegment();
                hl7Segment.FromDelimitedString("IAA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new IarSegment
            {
                AllergyReactionCode = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                AllergySeverityCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                SensitivityToCausativeAgentCode = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                Management = "4"
            };

            string expected = "IAR|1|2|3|4";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
