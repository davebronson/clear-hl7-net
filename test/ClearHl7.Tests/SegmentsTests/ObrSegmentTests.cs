using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class ObrSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new ObrSegment
            {
                SetIdObr = 1,
                PlacerOrderNumber = new EntityIdentifier
                {
                    EntityId = "2"
                },
                FillerOrderNumber = new EntityIdentifier
                {
                    EntityId = "3"
                },
                UniversalServiceIdentifier = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                Priority = "5",
                RequestedDateTime = new DateTime(2020, 6, 6, 0, 0, 6),
                ObservationDateTime = new DateTime(2020, 7, 7, 0, 0, 7),
                ObservationEndDateTime = new DateTime(2020, 8, 8, 0, 0, 8),
                CollectionVolume = new CompositeQuantityWithUnits
                {
                    Quantity = 9
                },
                CollectorIdentifier = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "10"
                    }
                },
                SpecimenActionCode = "11",
                DangerCode = new CodedWithExceptions
                {
                    Identifier = "12"
                },
                RelevantClinicalInformation = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "13"
                    }
                },
                SpecimenReceivedDateTime = new DateTime(2020, 1, 14, 0, 0, 14),
                SpecimenSource = "15",
                OrderingProvider = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "16"
                    }
                },
                OrderCallbackPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "17"
                    }
                },
                PlacerField1 = "18",
                PlacerField2 = "19",
                FillerField1 = "20",
                FillerField2 = "21",
                ResultsRptStatusChngDateTime = new DateTime(2020, 1, 22, 0, 0, 22),
                ChargeToPractice = new MoneyAndChargeCode
                {
                    MonetaryAmount = new Money
                    {
                        Quantity = 23
                    }
                },
                DiagnosticServSectId = "24",
                ResultStatus = "25",
                ParentResult = new ParentResultLink
                {
                    ParentObservationIdentifier = new CodedWithExceptions
                    {
                        Identifier = "26"
                    }
                },
                QuantityTiming = new string[]
                {
                    "27"
                },
                ResultCopiesTo = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "28"
                    }
                },
                ParentResultsObservationIdentifier = new EntityIdentifierPair
                {
                    PlacerAssignedIdentifier = new EntityIdentifier
                    {
                        EntityId = "29"
                    }
                },
                TransportationMode = "30",
                ReasonForStudy = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "31"
                    }
                },
                PrincipalResultInterpreter = new NameWithDateAndLocation
                {
                    Name = new CompositeIdNumberAndNameSimplified
                    {
                        IdNumber = "32"
                    }
                },
                AssistantResultInterpreter = new NameWithDateAndLocation[]
                {
                    new NameWithDateAndLocation
                    {
                        Name = new CompositeIdNumberAndNameSimplified
                        {
                            IdNumber = "33"
                        }
                    }
                },
                Technician = new NameWithDateAndLocation[]
                {
                    new NameWithDateAndLocation
                    {
                        Name = new CompositeIdNumberAndNameSimplified
                        {
                            IdNumber = "34"
                        }
                    }
                },
                Transcriptionist = new NameWithDateAndLocation[]
                {
                    new NameWithDateAndLocation
                    {
                        Name = new CompositeIdNumberAndNameSimplified
                        {
                            IdNumber = "35"
                        }
                    }
                },
                ScheduledDateTime = new DateTime(2020, 3, 6, 0, 0, 36),
                NumberOfSampleContainers = 37,
                TransportLogisticsOfCollectedSample = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "38"
                    }
                },
                CollectorsComment = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "39"
                    }
                },
                TransportArrangementResponsibility = new CodedWithExceptions
                {
                    Identifier = "40"
                },
                TransportArranged = "41",
                EscortRequired = "42",
                PlannedPatientTransportComment = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "43"
                    }
                },
                ProcedureCode = new CodedWithNoExceptions
                {
                    Identifier = "44"
                },
                ProcedureCodeModifier = new CodedWithNoExceptions[]
                {
                    new CodedWithNoExceptions
                    {
                        Identifier = "45"
                    }
                },
                PlacerSupplementalServiceInformation = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "46"
                    }
                },
                FillerSupplementalServiceInformation = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "47"
                    }
                },
                MedicallyNecessaryDuplicateProcedureReason = new CodedWithExceptions
                {
                    Identifier = "48"
                },
                ResultHandling = new CodedWithExceptions
                {
                    Identifier = "49"
                },
                ParentUniversalServiceIdentifier = new CodedWithExceptions
                {
                    Identifier = "50"
                },
                ObservationGroupId = new EntityIdentifier
                {
                    EntityId = "51"
                },
                ParentObservationGroupId = new EntityIdentifier
                {
                    EntityId = "52"
                },
                AlternatePlacerOrderNumber = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "53"
                    }
                },
                ParentOrder = new EntityIdentifierPair[]
                {
                    new EntityIdentifierPair
                    {
                        PlacerAssignedIdentifier = new EntityIdentifier
                        {
                            EntityId = "54"
                        }
                    }
                },
                ActionCode = "55"
            };

            ISegment actual = new ObrSegment();
            actual.FromDelimitedString("OBR|1|2|3|4|5|20200606000006|20200707000007|20200808000008|9|10|11|12|13|20200114000014|15|16|17|18|19|20|21|20200122000022|23|24|25|26|27|28|29|30|31|32|33|34|35|20200306000036|37|38|39|40|41|42|43|44|45|46|47|48|49|50|51|52|53|54|55");

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
                ISegment hl7Segment = new ObrSegment();
                hl7Segment.FromDelimitedString("OBA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new ObrSegment
            {
                SetIdObr = 1,
                PlacerOrderNumber = new EntityIdentifier
                {
                    EntityId = "2"
                },
                FillerOrderNumber = new EntityIdentifier
                {
                    EntityId = "3"
                },
                UniversalServiceIdentifier = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                Priority = "5",
                RequestedDateTime = new DateTime(2020, 6, 6, 0, 0, 6),
                ObservationDateTime = new DateTime(2020, 7, 7, 0, 0, 7),
                ObservationEndDateTime = new DateTime(2020, 8, 8, 0, 0, 8),
                CollectionVolume = new CompositeQuantityWithUnits
                {
                    Quantity = 9
                },
                CollectorIdentifier = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "10"
                    }
                },
                SpecimenActionCode = "11",
                DangerCode = new CodedWithExceptions
                {
                    Identifier = "12"
                },
                RelevantClinicalInformation = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "13"
                    }
                },
                SpecimenReceivedDateTime = new DateTime(2020, 1, 14, 0, 0, 14),
                SpecimenSource = "15",
                OrderingProvider = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "16"
                    }
                },
                OrderCallbackPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "17"
                    }
                },
                PlacerField1 = "18",
                PlacerField2 = "19",
                FillerField1 = "20",
                FillerField2 = "21",
                ResultsRptStatusChngDateTime = new DateTime(2020, 1, 22, 0, 0, 22),
                ChargeToPractice = new MoneyAndChargeCode
                {
                    MonetaryAmount = new Money
                    {
                        Quantity = 23
                    }
                },
                DiagnosticServSectId = "24",
                ResultStatus = "25",
                ParentResult = new ParentResultLink
                {
                    ParentObservationIdentifier = new CodedWithExceptions
                    {
                        Identifier = "26"
                    }
                },
                QuantityTiming = new string[]
                {
                    "27"
                },
                ResultCopiesTo = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "28"
                    }
                },
                ParentResultsObservationIdentifier = new EntityIdentifierPair
                {
                    PlacerAssignedIdentifier = new EntityIdentifier
                    {
                        EntityId = "29"
                    }
                },
                TransportationMode = "30",
                ReasonForStudy = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "31"
                    }
                },
                PrincipalResultInterpreter = new NameWithDateAndLocation
                {
                    Name = new CompositeIdNumberAndNameSimplified
                    {
                        IdNumber = "32"
                    }
                },
                AssistantResultInterpreter = new NameWithDateAndLocation[]
                {
                    new NameWithDateAndLocation
                    {
                        Name = new CompositeIdNumberAndNameSimplified
                        {
                            IdNumber = "33"
                        }
                    }
                },
                Technician = new NameWithDateAndLocation[]
                {
                    new NameWithDateAndLocation
                    {
                        Name = new CompositeIdNumberAndNameSimplified
                        {
                            IdNumber = "34"
                        }
                    }
                },
                Transcriptionist = new NameWithDateAndLocation[]
                {
                    new NameWithDateAndLocation
                    {
                        Name = new CompositeIdNumberAndNameSimplified
                        {
                            IdNumber = "35"
                        }
                    }
                },
                ScheduledDateTime = new DateTime(2020, 3, 6, 0, 0, 36),
                NumberOfSampleContainers = 37,
                TransportLogisticsOfCollectedSample = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "38"
                    }
                },
                CollectorsComment = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "39"
                    }
                },
                TransportArrangementResponsibility = new CodedWithExceptions
                {
                    Identifier = "40"
                },
                TransportArranged = "41",
                EscortRequired = "42",
                PlannedPatientTransportComment = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "43"
                    }
                },
                ProcedureCode = new CodedWithNoExceptions
                {
                    Identifier = "44"
                },
                ProcedureCodeModifier = new CodedWithNoExceptions[]
                {
                    new CodedWithNoExceptions
                    {
                        Identifier = "45"
                    }
                },
                PlacerSupplementalServiceInformation = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "46"
                    }
                },
                FillerSupplementalServiceInformation = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "47"
                    }
                },
                MedicallyNecessaryDuplicateProcedureReason = new CodedWithExceptions
                {
                    Identifier = "48"
                },
                ResultHandling = new CodedWithExceptions
                {
                    Identifier = "49"
                },
                ParentUniversalServiceIdentifier = new CodedWithExceptions
                {
                    Identifier = "50"
                },
                ObservationGroupId = new EntityIdentifier
                {
                    EntityId = "51"
                },
                ParentObservationGroupId = new EntityIdentifier
                {
                    EntityId = "52"
                },
                AlternatePlacerOrderNumber = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "53"
                    }
                },
                ParentOrder = new EntityIdentifierPair[]
                {
                    new EntityIdentifierPair
                    {
                        PlacerAssignedIdentifier = new EntityIdentifier
                        {
                            EntityId = "54"
                        }
                    }
                },
                ActionCode = "55"
            };

            string expected = "OBR|1|2|3|4|5|20200606000006|20200707000007|20200808000008|9|10|11|12|13|20200114000014|15|16|17|18|19|20|21|20200122000022|23|24|25|26|27|28|29|30|31|32|33|34|35|20200306000036|37|38|39|40|41|42|43|44|45|46|47|48|49|50|51|52|53|54|55";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
