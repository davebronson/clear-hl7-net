using ClearHl7.Fhir.V290.Segments;
using ClearHl7.Fhir.V290.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class SchSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new SchSegment
            {
                PlacerAppointmentId = new EntityIdentifier
                {
                    EntityId = "1"
                },
                FillerAppointmentId = new EntityIdentifier
                {
                    EntityId = "2"
                },
                OccurrenceNumber = 3,
                PlacerGroupNumber = new EntityIdentifierPair
                {
                    PlacerAssignedIdentifier = new EntityIdentifier
                    {
                        EntityId = "4"
                    }
                },
                ScheduleId = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                EventReason = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                AppointmentReason = new CodedWithExceptions
                {
                    Identifier = "7"
                },
                AppointmentType = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                AppointmentDuration = 9,
                AppointmentDurationUnits = new CodedWithNoExceptions
                {
                    Identifier = "10"
                },
                AppointmentTimingQuantity = "11",
                PlacerContactPerson = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "12"
                    }
                },
                PlacerContactPhoneNumber = new ExtendedTelecommunicationNumber
                {
                    TelephoneNumber = "13"
                },
                PlacerContactAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "14"
                        }
                    }
                },
                PlacerContactLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "15"
                    }
                },
                FillerContactPerson = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "16"
                    }
                },
                FillerContactPhoneNumber = new ExtendedTelecommunicationNumber
                {
                    TelephoneNumber = "17"
                },
                FillerContactAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "18"
                        }
                    }
                },
                FillerContactLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "19"
                    }
                },
                EnteredByPerson = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "20"
                    }
                },
                EnteredByPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "21"
                    }
                },
                EnteredByLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "22"
                    }
                },
                ParentPlacerAppointmentId = new EntityIdentifier
                {
                    EntityId = "23"
                },
                ParentFillerAppointmentId = new EntityIdentifier
                {
                    EntityId = "24"
                },
                FillerStatusCode = new CodedWithExceptions
                {
                    Identifier = "25"
                },
                PlacerOrderNumber = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "26"
                    }
                },
                FillerOrderNumber = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "27"
                    }
                },
                AlternatePlacerOrderGroupNumber = new EntityIdentifierPair
                {
                    PlacerAssignedIdentifier = new EntityIdentifier
                    {
                        EntityId = "28"
                    }
                }
            };

            string expected = "SCH|1|2|3|4|5|6|7|8|9|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
