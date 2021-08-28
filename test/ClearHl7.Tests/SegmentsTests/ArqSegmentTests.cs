using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class ArqSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new ArqSegment
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
                PlacerGroupNumber = new EntityIdentifier
                {
                    EntityId = "4"
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
                RequestedStartDateTimeRange = new DateTimeRange[]
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
                PlacerContactPerson = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "15"
                    }
                },
                PlacerContactPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "16"
                    }
                },
                PlacerContactAddress = new ExtendedAddress[]
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
                EnteredByPerson = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "19"
                    }
                },
                EnteredByPhoneNumber = new ExtendedTelecommunicationNumber[]
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
                PlacerOrderNumber = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "24"
                    }
                },
                FillerOrderNumber = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "25"
                    }
                },
                AlternatePlacerOrderGroupNumber = new EntityIdentifierPair
                {
                    PlacerAssignedIdentifier = new EntityIdentifier
                    {
                        EntityId = "26"
                    }
                }
            };

            ISegment actual = new ArqSegment();
            actual.FromDelimitedString("ARQ|1|2|3|4|5|6|7|8|9|10|20201111000011|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26");

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
                ISegment hl7Segment = new ArqSegment();
                hl7Segment.FromDelimitedString("ARA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
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
                PlacerGroupNumber = new EntityIdentifier
                {
                    EntityId = "4"
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
                RequestedStartDateTimeRange = new DateTimeRange[]
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
                PlacerContactPerson = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "15"
                    }
                },
                PlacerContactPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "16"
                    }
                },
                PlacerContactAddress = new ExtendedAddress[]
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
                EnteredByPerson = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "19"
                    }
                },
                EnteredByPhoneNumber = new ExtendedTelecommunicationNumber[]
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
                PlacerOrderNumber = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "24"
                    }
                },
                FillerOrderNumber = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "25"
                    }
                },
                AlternatePlacerOrderGroupNumber = new EntityIdentifierPair
                {
                    PlacerAssignedIdentifier = new EntityIdentifier
                    {
                        EntityId = "26"
                    }
                }
            };

            string expected = "ARQ|1|2|3|4|5|6|7|8|9|10|20201111000011|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
