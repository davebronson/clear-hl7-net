using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Om1SegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new Om1Segment
            {
                SequenceNumberTestObservationMasterFile = 1,
                ProducersServiceTestObservationId = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                PermittedDataTypes = new string[]
                {
                    "3"
                },
                SpecimenRequired = "4",
                ProducerId = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                ObservationDescription = new Text
                {
                    Value = "6"
                },
                OtherServiceTestObservationIdsForTheObservation = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "7"
                    }
                },
                OtherNames = new string[]
                {
                    "8"
                },
                PreferredReportNameForTheObservation = "9",
                PreferredShortNameOrMnemonicForTheObservation = "10",
                PreferredLongNameForTheObservation = "11",
                Orderability = "12",
                IdentityOfInstrumentUsedToPerformThisStudy = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "13"
                    }
                },
                CodedRepresentationOfMethod = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "14"
                    }
                },
                PortableDeviceIndicator = "15",
                ObservationProducingDepartmentSection = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "16"
                    }
                },
                TelephoneNumberOfSection = new ExtendedTelecommunicationNumber
                {
                    TelephoneNumber = "17"
                },
                NatureOfServiceTestObservation = new CodedWithExceptions
                {
                    Identifier = "18"
                },
                ReportSubheader = new CodedWithExceptions
                {
                    Identifier = "19"
                },
                ReportDisplayOrder = "20",
                DateTimeStampForAnyChangeInDefinitionForTheObservation = new DateTime(2020, 1, 21, 0, 0, 21),
                EffectiveDateTimeOfChange = new DateTime(2020, 1, 22, 0, 0, 22),
                TypicalTurnAroundTime = 23,
                ProcessingTime = 24,
                ProcessingPriority = new string[]
                {
                    "25"
                },
                ReportingPriority = "26",
                OutsideSitesWhereObservationMayBePerformed = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "27"
                    }
                },
                AddressOfOutsideSites = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "28"
                        }
                    }
                },
                PhoneNumberOfOutsideSite = new ExtendedTelecommunicationNumber
                {
                    TelephoneNumber = "29"
                },
                ConfidentialityCode = new CodedWithExceptions
                {
                    Identifier = "30"
                },
                ObservationsRequiredToInterpretThisObservation = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "31"
                    }
                },
                InterpretationOfObservations = new Text
                {
                    Value = "32"
                },
                ContraindicationsToObservations = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "33"
                    }
                },
                ReflexTestsObservations = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "34"
                    }
                },
                RulesThatTriggerReflexTesting = new Text[]
                {
                    new Text
                    {
                        Value = "35"
                    }
                },
                FixedCannedMessage = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "36"
                    }
                },
                PatientPreparation = new Text[]
                {
                    new Text
                    {
                        Value = "37"
                    }
                },
                ProcedureMedication = new CodedWithExceptions
                {
                    Identifier = "38"
                },
                FactorsThatMayAffectTheObservation = new Text
                {
                    Value = "39"
                },
                ServiceTestObservationPerformanceSchedule = new string[]
                {
                    "40"
                },
                DescriptionOfTestMethods = new Text
                {
                    Value = "41"
                },
                KindOfQuantityObserved = new CodedWithExceptions
                {
                    Identifier = "42"
                },
                PointVersusInterval = new CodedWithExceptions
                {
                    Identifier = "43"
                },
                ChallengeInformation = new Text
                {
                    Value = "44"
                },
                RelationshipModifier = new CodedWithExceptions
                {
                    Identifier = "45"
                },
                TargetAnatomicSiteOfTest = new CodedWithExceptions
                {
                    Identifier = "46"
                },
                ModalityOfImagingMeasurement = new CodedWithExceptions
                {
                    Identifier = "47"
                },
                ExclusiveTest = "48",
                DiagnosticServSectId = "49",
                TaxonomicClassificationCode = new CodedWithExceptions
                {
                    Identifier = "50"
                },
                OtherNamesB = new string[]
                {
                    "51"
                },
                ReplacementProducersServiceTestObservationId = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "52"
                    }
                },
                PriorResultsInstructions = new Text[]
                {
                    new Text
                    {
                        Value = "53"
                    }
                },
                SpecialInstructions = new Text
                {
                    Value = "54"
                },
                TestCategory = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "55"
                    }
                },
                ObservationIdAssociatedWithProducersServiceTestObservationId = new CodedWithExceptions
                {
                    Identifier = "56"
                },
                TypicalTurnAroundTimeWithUnits = new CompositeQuantityWithUnits
                {
                    Quantity = 57
                },
                GenderRestriction = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "58"
                    }
                },
                AgeRestriction = new NumericRange[]
                {
                    new NumericRange
                    {
                        LowValue = 59
                    }
                }
            };

            ISegment actual = new Om1Segment();
            actual.FromDelimitedString("OM1|1|2|3|4|5|6|7|8|9|10|11|12|13|14|15|16|17|18|19|20|20200121000021|20200122000022|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41|42|43|44|45|46|47|48|49|50|51|52|53|54|55|56|57|58|59");

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
                ISegment hl7Segment = new Om1Segment();
                hl7Segment.FromDelimitedString("OMA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Om1Segment
            {
                SequenceNumberTestObservationMasterFile = 1,
                ProducersServiceTestObservationId = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                PermittedDataTypes = new string[]
                {
                    "3"
                },
                SpecimenRequired = "4",
                ProducerId = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                ObservationDescription = new Text
                {
                    Value = "6"
                },
                OtherServiceTestObservationIdsForTheObservation = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "7"
                    }
                },
                OtherNames = new string[]
                {
                    "8"
                },
                PreferredReportNameForTheObservation = "9",
                PreferredShortNameOrMnemonicForTheObservation = "10",
                PreferredLongNameForTheObservation = "11",
                Orderability = "12",
                IdentityOfInstrumentUsedToPerformThisStudy = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "13"
                    }
                },
                CodedRepresentationOfMethod = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "14"
                    }
                },
                PortableDeviceIndicator = "15",
                ObservationProducingDepartmentSection = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "16"
                    }
                },
                TelephoneNumberOfSection = new ExtendedTelecommunicationNumber
                {
                    TelephoneNumber = "17"
                },
                NatureOfServiceTestObservation = new CodedWithExceptions
                {
                    Identifier = "18"
                },
                ReportSubheader = new CodedWithExceptions
                {
                    Identifier = "19"
                },
                ReportDisplayOrder = "20",
                DateTimeStampForAnyChangeInDefinitionForTheObservation = new DateTime(2020, 1, 21, 0, 0, 21),
                EffectiveDateTimeOfChange = new DateTime(2020, 1, 22, 0, 0, 22),
                TypicalTurnAroundTime = 23,
                ProcessingTime = 24,
                ProcessingPriority = new string[]
                {
                    "25"
                },
                ReportingPriority = "26",
                OutsideSitesWhereObservationMayBePerformed = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "27"
                    }
                },
                AddressOfOutsideSites = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "28"
                        }
                    }
                },
                PhoneNumberOfOutsideSite = new ExtendedTelecommunicationNumber
                {
                    TelephoneNumber = "29"
                },
                ConfidentialityCode = new CodedWithExceptions
                {
                    Identifier = "30"
                },
                ObservationsRequiredToInterpretThisObservation = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "31"
                    }
                },
                InterpretationOfObservations = new Text
                {
                    Value = "32"
                },
                ContraindicationsToObservations = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "33"
                    }
                },
                ReflexTestsObservations = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "34"
                    }
                },
                RulesThatTriggerReflexTesting = new Text[]
                {
                    new Text
                    {
                        Value = "35"
                    }
                },
                FixedCannedMessage = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "36"
                    }
                },
                PatientPreparation = new Text[]
                {
                    new Text
                    {
                        Value = "37"
                    }
                },
                ProcedureMedication = new CodedWithExceptions
                {
                    Identifier = "38"
                },
                FactorsThatMayAffectTheObservation = new Text
                {
                    Value = "39"
                },
                ServiceTestObservationPerformanceSchedule = new string[]
                {
                    "40"
                },
                DescriptionOfTestMethods = new Text
                {
                    Value = "41"
                },
                KindOfQuantityObserved = new CodedWithExceptions
                {
                    Identifier = "42"
                },
                PointVersusInterval = new CodedWithExceptions
                {
                    Identifier = "43"
                },
                ChallengeInformation = new Text
                {
                    Value = "44"
                },
                RelationshipModifier = new CodedWithExceptions
                {
                    Identifier = "45"
                },
                TargetAnatomicSiteOfTest = new CodedWithExceptions
                {
                    Identifier = "46"
                },
                ModalityOfImagingMeasurement = new CodedWithExceptions
                {
                    Identifier = "47"
                },
                ExclusiveTest = "48",
                DiagnosticServSectId = "49",
                TaxonomicClassificationCode = new CodedWithExceptions
                {
                    Identifier = "50"
                },
                OtherNamesB = new string[]
                {
                    "51"
                },
                ReplacementProducersServiceTestObservationId = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "52"
                    }
                },
                PriorResultsInstructions = new Text[]
                {
                    new Text
                    {
                        Value = "53"
                    }
                },
                SpecialInstructions = new Text
                {
                    Value = "54"
                },
                TestCategory = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "55"
                    }
                },
                ObservationIdAssociatedWithProducersServiceTestObservationId = new CodedWithExceptions
                {
                    Identifier = "56"
                },
                TypicalTurnAroundTimeWithUnits = new CompositeQuantityWithUnits
                {
                    Quantity = 57
                },
                GenderRestriction = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "58"
                    }
                },
                AgeRestriction = new NumericRange[]
                {
                    new NumericRange
                    {
                        LowValue = 59
                    }
                }
            };

            string expected = "OM1|1|2|3|4|5|6|7|8|9|10|11|12|13|14|15|16|17|18|19|20|20200121000021|20200122000022|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41|42|43|44|45|46|47|48|49|50|51|52|53|54|55|56|57|58|59";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
