using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class LanSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new LanSegment
            {
                SetIdLan = 1,
                LanguageCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                LanguageAbilityCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "3"
                    }
                },
                LanguageProficiencyCode = new CodedWithExceptions
                {
                    Identifier = "4"
                }
            };

            ISegment actual = new LanSegment();
            actual.FromDelimitedString("LAN|1|2|3|4");

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
                ISegment hl7Segment = new LanSegment();
                hl7Segment.FromDelimitedString("LAA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new LanSegment
            {
                SetIdLan = 1,
                LanguageCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                LanguageAbilityCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "3"
                    }
                },
                LanguageProficiencyCode = new CodedWithExceptions
                {
                    Identifier = "4"
                }
            };

            string expected = "LAN|1|2|3|4";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
