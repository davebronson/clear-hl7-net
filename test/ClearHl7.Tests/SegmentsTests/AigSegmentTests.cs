using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class AigSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new AigSegment
            {
                SetIdAig = 1,
                SegmentActionCode = "2",
                ResourceId = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                ResourceType = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                ResourceGroup = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "5"
                    }
                },
                ResourceQuantity = 6,
                ResourceQuantityUnits = new CodedWithNoExceptions
                {
                    Identifier = "7"
                },
                StartDateTime = new DateTime(2020, 8, 8, 0, 0, 8),
                StartDateTimeOffset = 9,
                StartDateTimeOffsetUnits = new CodedWithNoExceptions
                {
                    Identifier = "10"
                },
                Duration = 11,
                DurationUnits = new CodedWithNoExceptions
                {
                    Identifier = "12"
                },
                AllowSubstitutionCode = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                FillerStatusCode = new CodedWithExceptions
                {
                    Identifier = "14"
                }
            };

            ISegment actual = new AigSegment();
            actual.FromDelimitedString("AIG|1|2|3|4|5|6|7|20200808000008|9|10|11|12|13|14");

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
                ISegment hl7Segment = new AigSegment();
                hl7Segment.FromDelimitedString("AIA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new AigSegment
            {
                SetIdAig = 1,
                SegmentActionCode = "2",
                ResourceId = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                ResourceType = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                ResourceGroup = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "5"
                    }
                },
                ResourceQuantity = 6,
                ResourceQuantityUnits = new CodedWithNoExceptions
                {
                    Identifier = "7"
                },
                StartDateTime = new DateTime(2020, 8, 8, 0, 0, 8),
                StartDateTimeOffset = 9,
                StartDateTimeOffsetUnits = new CodedWithNoExceptions
                {
                    Identifier = "10"
                },
                Duration = 11,
                DurationUnits = new CodedWithNoExceptions
                {
                    Identifier = "12"
                },
                AllowSubstitutionCode = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                FillerStatusCode = new CodedWithExceptions
                {
                    Identifier = "14"
                }
            };

            string expected = "AIG|1|2|3|4|5|6|7|20200808000008|9|10|11|12|13|14";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
