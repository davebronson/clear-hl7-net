using System;
using ClearHl7.Fhir.V290.Segments;
using ClearHl7.Fhir.V290.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class PdaSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
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
