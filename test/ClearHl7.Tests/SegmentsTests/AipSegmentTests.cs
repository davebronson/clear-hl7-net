using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class AipSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new AipSegment
            {
                SetIdAip = 1,
                SegmentActionCode = "2",
                PersonnelResourceId = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "3"
                    }
                },
                ResourceType = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                ResourceGroup = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                StartDateTime = new DateTime(2020, 6, 6, 0, 0, 6),
                StartDateTimeOffset = 7,
                StartDateTimeOffsetUnits = new CodedWithNoExceptions
                {
                    Identifier = "8"
                },
                Duration = 9,
                DurationUnits = new CodedWithNoExceptions
                {
                    Identifier = "10"
                },
                AllowSubstitutionCode = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                FillerStatusCode = new CodedWithExceptions
                {
                    Identifier = "12"
                }
            };

            ISegment actual = new AipSegment();
            actual.FromDelimitedString("AIP|1|2|3|4|5|20200606000006|7|8|9|10|11|12");

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
                ISegment hl7Segment = new AipSegment();
                hl7Segment.FromDelimitedString("AIA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new AipSegment
            {
                SetIdAip = 1,
                SegmentActionCode = "2",
                PersonnelResourceId = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "3"
                    }
                },
                ResourceType = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                ResourceGroup = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                StartDateTime = new DateTime(2020, 6, 6, 0, 0, 6),
                StartDateTimeOffset = 7,
                StartDateTimeOffsetUnits = new CodedWithNoExceptions
                {
                    Identifier = "8"
                },
                Duration = 9,
                DurationUnits = new CodedWithNoExceptions
                {
                    Identifier = "10"
                },
                AllowSubstitutionCode = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                FillerStatusCode = new CodedWithExceptions
                {
                    Identifier = "12"
                }
            };

            string expected = "AIP|1|2|3|4|5|20200606000006|7|8|9|10|11|12";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
