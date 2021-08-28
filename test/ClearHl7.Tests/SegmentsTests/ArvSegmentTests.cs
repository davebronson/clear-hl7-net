using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class ArvSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new ArvSegment
            {
                SetId = 1,
                AccessRestrictionActionCode = new CodedWithNoExceptions
                {
                    Identifier = "2"
                },
                AccessRestrictionValue = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                AccessRestrictionReason = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "4"
                    }
                },
                SpecialAccessRestrictionInstructions = new string[]
                {
                    "5"
                },
                AccessRestrictionDateRange = new DateTimeRange
                {
                    RangeStartDateTime = new DateTime(2020, 6, 6, 0, 0, 6)
                },
                SecurityClassificationTag = new CodedWithExceptions
                {
                    Identifier = "7"
                },
                SecurityHandlingInstructions = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "8"
                    }
                },
                AccessRestrictionMessageLocation = new MessageLocation[]
                {
                    new MessageLocation
                    {
                        SegmentId = "9"
                    }
                },
                AccessRestrictionInstanceIdentifier = new EntityIdentifier
                {
                    EntityId = "10"
                }
            };

            ISegment actual = new ArvSegment();
            actual.FromDelimitedString("ARV|1|2|3|4|5|20200606000006|7|8|9|10");

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
                ISegment hl7Segment = new ArvSegment();
                hl7Segment.FromDelimitedString("ARA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new ArvSegment
            {
                SetId = 1,
                AccessRestrictionActionCode = new CodedWithNoExceptions
                {
                    Identifier = "2"
                },
                AccessRestrictionValue = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                AccessRestrictionReason = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "4"
                    }
                },
                SpecialAccessRestrictionInstructions = new string[]
                {
                    "5"
                },
                AccessRestrictionDateRange = new DateTimeRange
                {
                    RangeStartDateTime = new DateTime(2020, 6, 6, 0, 0, 6)
                },
                SecurityClassificationTag = new CodedWithExceptions
                {
                    Identifier = "7"
                },
                SecurityHandlingInstructions = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "8"
                    }
                },
                AccessRestrictionMessageLocation = new MessageLocation[]
                {
                    new MessageLocation
                    {
                        SegmentId = "9"
                    }
                },
                AccessRestrictionInstanceIdentifier = new EntityIdentifier
                {
                    EntityId = "10"
                }
            };

            string expected = "ARV|1|2|3|4|5|20200606000006|7|8|9|10";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
