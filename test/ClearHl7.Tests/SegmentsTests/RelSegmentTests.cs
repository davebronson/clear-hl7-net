using System;
using ClearHl7.Fhir.V290.Segments;
using ClearHl7.Fhir.V290.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class RelSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new RelSegment
            {
                SetIdRel = 1,
                RelationshipType = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                ThisRelationshipInstanceIdentifier = new EntityIdentifier
                {
                    EntityId = "3"
                },
                SourceInformationInstanceIdentifier = new EntityIdentifier
                {
                    EntityId = "4"
                },
                TargetInformationInstanceIdentifier = new EntityIdentifier
                {
                    EntityId = "5"
                },
                AssertingEntityInstanceId = new EntityIdentifier
                {
                    EntityId = "6"
                },
                AssertingPerson = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "7"
                },
                AssertingOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "8"
                },
                AssertorAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "9"
                    }
                },
                AssertorContact = new ExtendedTelecommunicationNumber
                {
                    TelephoneNumber = "10"
                },
                AssertionDateRange = new DateTimeRange
                {
                    RangeStartDateTime = new DateTime(2020, 11, 11, 0, 0, 11)
                },
                NegationIndicator = "12",
                CertaintyOfRelationship = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                PriorityNo = 14,
                PrioritySequenceNoRelPreferenceForConsideration = 15,
                SeparabilityIndicator = "16",
                SourceInformationInstanceObjectType = "17",
                TargetInformationInstanceObjectType = "18"
            };

            string expected = "REL|1|2|3|4|5|6|7|8|9|10|20201111000011|12|13|14|15|16|17|18";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
