using System;
using ClearHl7.Fhir.V282.Segments;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class PrtSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new PrtSegment
            {
                ParticipationInstanceId = new EntityIdentifier
                {
                    EntityId = "1"
                },
                ActionCode = "2",
                ActionReason = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                Participation = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                ParticipationPerson = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "5"
                    }
                },
                ParticipationPersonProviderType = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                ParticipantOrganizationUnitType = new CodedWithExceptions
                {
                    Identifier = "7"
                },
                ParticipationOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "8"
                    }
                },
                ParticipantLocation = new PersonLocation[]
                {
                    new PersonLocation
                    {
                        PointOfCare = new HierarchicDesignator
                        {
                            NamespaceId = "9"
                        }
                    }
                },
                ParticipationDevice = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "10"
                    }
                },
                ParticipationBeginDateTimeArrivalTime = new DateTime(2020, 11, 11, 0, 0, 11),
                ParticipationEndDateTimeDepartureTime = new DateTime(2020, 12, 12, 0, 0, 12),
                ParticipationQualitativeDuration = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                ParticipationAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "14"
                        }
                    }
                },
                ParticipantTelecommunicationAddress = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "15"
                    }
                },
                ParticipantDeviceIdentifier = new EntityIdentifier
                {
                    EntityId = "16"
                },
                ParticipantDeviceManufactureDate = new DateTime(2020, 1, 17, 0, 0, 17),
                ParticipantDeviceExpiryDate = new DateTime(2020, 1, 18, 0, 0, 18),
                ParticipantDeviceLotNumber = "19",
                ParticipantDeviceSerialNumber = "20",
                ParticipantDeviceDonationIdentification = new EntityIdentifier
                {
                    EntityId = "21"
                },
                ParticipationDeviceType = new CodedWithNoExceptions
                {
                    Identifier = "22"
                }
            };

            string expected = "PRT|1|2|3|4|5|6|7|8|9|10|20201111000011|20201212000012|13|14|15|16|20200117000017|20200118000018|19|20|21|22";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
