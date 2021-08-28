using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class AisSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new AisSegment
            {
                SetIdAis = 1,
                SegmentActionCode = "2",
                UniversalServiceIdentifier = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                StartDateTime = new DateTime(2020, 4, 4, 0, 0, 4),
                StartDateTimeOffset = 5,
                StartDateTimeOffsetUnits = new CodedWithNoExceptions
                {
                    Identifier = "6"
                },
                Duration = 7,
                DurationUnits = new CodedWithNoExceptions
                {
                    Identifier = "8"
                },
                AllowSubstitutionCode = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                FillerStatusCode = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                PlacerSupplementalServiceInformation = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "11"
                    }
                },
                FillerSupplementalServiceInformation = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "12"
                    }
                }
            };

            ISegment actual = new AisSegment();
            actual.FromDelimitedString("AIS|1|2|3|20200404000004|5|6|7|8|9|10|11|12");

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
                ISegment hl7Segment = new AisSegment();
                hl7Segment.FromDelimitedString("AIA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new AisSegment
            {
                SetIdAis = 1,
                SegmentActionCode = "2",
                UniversalServiceIdentifier = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                StartDateTime = new DateTime(2020, 4, 4, 0, 0, 4),
                StartDateTimeOffset = 5,
                StartDateTimeOffsetUnits = new CodedWithNoExceptions
                {
                    Identifier = "6"
                },
                Duration = 7,
                DurationUnits = new CodedWithNoExceptions
                {
                    Identifier = "8"
                },
                AllowSubstitutionCode = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                FillerStatusCode = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                PlacerSupplementalServiceInformation = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "11"
                    }
                },
                FillerSupplementalServiceInformation = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "12"
                    }
                }
            };

            string expected = "AIS|1|2|3|20200404000004|5|6|7|8|9|10|11|12";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
