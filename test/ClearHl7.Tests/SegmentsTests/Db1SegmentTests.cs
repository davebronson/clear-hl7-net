using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Db1SegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new Db1Segment
            {
                SetIdDb1 = 1,
                DisabledPersonCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                DisabledPersonIdentifier = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "3"
                    }
                },
                DisabilityIndicator = "4",
                DisabilityStartDate = new DateTime(2020, 5, 5),
                DisabilityEndDate = new DateTime(2020, 6, 6),
                DisabilityReturnToWorkDate = new DateTime(2020, 7, 7),
                DisabilityUnableToWorkDate = new DateTime(2020, 8, 8)
            };

            ISegment actual = new Db1Segment();
            actual.FromDelimitedString("DB1|1|2|3|4|20200505|20200606|20200707|20200808");

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
                ISegment hl7Segment = new Db1Segment();
                hl7Segment.FromDelimitedString("DBA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Db1Segment
            {
                SetIdDb1 = 1,
                DisabledPersonCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                DisabledPersonIdentifier = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "3"
                    }
                },
                DisabilityIndicator = "4",
                DisabilityStartDate = new DateTime(2020, 5, 5),
                DisabilityEndDate = new DateTime(2020, 6, 6),
                DisabilityReturnToWorkDate = new DateTime(2020, 7, 7),
                DisabilityUnableToWorkDate = new DateTime(2020, 8, 8)
            };

            string expected = "DB1|1|2|3|4|20200505|20200606|20200707|20200808";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
