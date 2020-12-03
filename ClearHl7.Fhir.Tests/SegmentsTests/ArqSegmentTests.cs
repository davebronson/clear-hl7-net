using System;
using System.Collections.Generic;
using ClearHl7.Fhir.V282.Segments;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class ArqSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new ArqSegment
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
                RequestEventReason = new CodedWithExceptions
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
                RequestedStartDateTimeRange = new List<DateTimeRange>
                {
                    new DateTimeRange
                    {
                        RangeStartDateTime = new DateTime(2020, 11, 11, 0, 0, 11)
                    }
                },
                PriorityArq = "12",
                RepeatingInterval = new RepeatInterval
                {
                    RepeatPattern = new CodedWithExceptions
                    {
                        Identifier = "13"
                    }
                },
                RepeatingIntervalDuration = "14",
                PlacerContactPerson = new List<ExtendedCompositeIdNumberAndNameForPersons>
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "15"
                    }
                },
                PlacerContactPhoneNumber = new List<ExtendedTelecommunicationNumber>
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "16"
                    }
                },
                PlacerContactAddress = new List<ExtendedAddress>
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "17"
                        }
                    }
                },
                PlacerContactLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "18"
                    }
                },
                EnteredByPerson = new List<ExtendedCompositeIdNumberAndNameForPersons>
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "19"
                    }
                },
                EnteredByPhoneNumber = new List<ExtendedTelecommunicationNumber>
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "20"
                    }
                },
                EnteredByLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "21"
                    }
                },
                ParentPlacerAppointmentId = new EntityIdentifier
                {
                    EntityId = "22"
                },
                ParentFillerAppointmentId = new EntityIdentifier
                {
                    EntityId = "23"
                },
                PlacerOrderNumber = new List<EntityIdentifier>
                {
                    new EntityIdentifier
                    {
                        EntityId = "24"
                    }
                },
                FillerOrderNumber = new List<EntityIdentifier>
                {
                    new EntityIdentifier
                    {
                        EntityId = "25"
                    }
                }
            };

            string expected = "ARQ|1|2|3|4|5|6|7|8|9|10|20201111000011|12|13|14|15|16|17|18|19|20|21|22|23|24|25";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
