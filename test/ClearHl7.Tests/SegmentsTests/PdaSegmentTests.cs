using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class PdaSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new PdaSegment
            {
                DeathCauseCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "1"
                    }
                },
                DeathLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "2"
                    }
                },
                DeathCertifiedIndicator = "3",
                DeathCertificateSignedDateTime = new DateTime(2020, 4, 4, 0, 0, 4),
                DeathCertifiedBy = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "5"
                },
                AutopsyIndicator = "6",
                AutopsyStartAndEndDateTime = new DateTimeRange
                {
                    RangeStartDateTime = new DateTime(2020, 7, 7, 0, 0, 7)
                },
                AutopsyPerformedBy = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "8"
                },
                CoronerIndicator = "9"
            };

            ISegment actual = new PdaSegment();
            actual.FromDelimitedString("PDA|1|2|3|20200404000004|5|6|20200707000007|8|9");

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
                ISegment hl7Segment = new PdaSegment();
                hl7Segment.FromDelimitedString("PAA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new PdaSegment
            {
                DeathCauseCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "1"
                    }
                },
                DeathLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "2"
                    }
                },
                DeathCertifiedIndicator = "3",
                DeathCertificateSignedDateTime = new DateTime(2020, 4, 4, 0, 0, 4),
                DeathCertifiedBy = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "5"
                },
                AutopsyIndicator = "6",
                AutopsyStartAndEndDateTime = new DateTimeRange
                {
                    RangeStartDateTime = new DateTime(2020, 7, 7, 0, 0, 7)
                },
                AutopsyPerformedBy = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "8"
                },
                CoronerIndicator = "9"
            };

            string expected = "PDA|1|2|3|20200404000004|5|6|20200707000007|8|9";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
