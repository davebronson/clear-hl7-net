using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Pv1SegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new Pv1Segment
            {
                SetIdPv1 = 1,
                PatientClass = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                AssignedPatientLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        IsSubcomponent = true,
                        NamespaceId = "3"
                    }
                },
                AdmissionType = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                PreadmitNumber = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "5"
                },
                PriorPatientLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        IsSubcomponent = true,
                        NamespaceId = "6"
                    }
                },
                AttendingDoctor = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "7"
                    }
                },
                ReferringDoctor = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "8"
                    }
                },
                ConsultingDoctor = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "9"
                    }
                },
                HospitalService = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                TemporaryLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        IsSubcomponent = true,
                        NamespaceId = "11"
                    }
                },
                PreadmitTestIndicator = new CodedWithExceptions
                {
                    Identifier = "12"
                },
                ReadmissionIndicator = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                AdmitSource = new CodedWithExceptions
                {
                    Identifier = "14"
                },
                AmbulatoryStatus = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "15"
                    }
                },
                VipIndicator = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                AdmittingDoctor = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                         PersonIdentifier = "17"
                    }
                },
                PatientType = new CodedWithExceptions
                {
                    Identifier = "18"
                },
                VisitNumber = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "19"
                },
                FinancialClass = new FinancialClass[]
                {
                    new FinancialClass
                    {
                        FinancialClassCode = new CodedWithExceptions
                        {
                            IsSubcomponent = true,
                            Identifier = "20"
                        }
                    }
                },
                ChargePriceIndicator = new CodedWithExceptions
                {
                    Identifier = "21"
                },
                CourtesyCode = new CodedWithExceptions
                {
                    Identifier = "22"
                },
                CreditRating = new CodedWithExceptions
                {
                    Identifier = "23"
                },
                ContractCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "24"
                    }
                },
                ContractEffectiveDate = new DateTime[]
                {
                    new DateTime(2020, 1, 25)
                },
                ContractAmount = new decimal[]
                {
                    26
                },
                ContractPeriod = new decimal[]
                {
                    27
                },
                InterestCode = new CodedWithExceptions
                {
                    Identifier = "28"
                },
                TransferToBadDebtCode = new CodedWithExceptions
                {
                    Identifier = "29"
                },
                TransferToBadDebtDate = new DateTime(2020, 1, 30),
                BadDebtAgencyCode = new CodedWithExceptions
                {
                    Identifier = "31"
                },
                BadDebtTransferAmount = 32,
                BadDebtRecoveryAmount = 33,
                DeleteAccountIndicator = new CodedWithExceptions
                {
                    Identifier = "34"
                },
                DeleteAccountDate = new DateTime(2020, 3, 5),
                DischargeDisposition = new CodedWithExceptions
                {
                    Identifier = "36"
                },
                DischargedToLocation = new DischargeToLocationAndDate
                {
                    DischargeToLocation = new CodedWithExceptions
                    {
                        IsSubcomponent = true,
                        Identifier = "37"
                    }
                },
                DietType = new CodedWithExceptions
                {
                    Identifier = "38"
                },
                ServicingFacility = new CodedWithExceptions
                {
                    Identifier = "39"
                },
                BedStatus = new CodedWithExceptions
                {
                    Identifier = "40"
                },
                AccountStatus = new CodedWithExceptions
                {
                    Identifier = "41"
                },
                PendingLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        IsSubcomponent = true,
                        NamespaceId = "42"
                    }
                },
                PriorTemporaryLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        IsSubcomponent = true,
                        NamespaceId = "43"
                    }
                },
                AdmitDateTime = new DateTime(2020, 4, 4, 0, 0, 4),
                DischargeDateTime = new DateTime(2020, 4, 5, 0, 0, 4),
                CurrentPatientBalance = 46,
                TotalCharges = 47,
                TotalAdjustments = 48,
                TotalPayments = 49,
                AlternateVisitId = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "50"
                    }
                },
                VisitIndicator = new CodedWithExceptions
                {
                    Identifier = "51"
                },
                OtherHealthcareProvider = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "52"
                },
                ServiceEpisodeDescription = "53",
                ServiceEpisodeIdentifier = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "54"
                }
            };

            Pv1Segment actual = new();
            actual.FromDelimitedString("PV1|1|2|3|4|5|6|7|8|9|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|20200125|26|27|28|29|20200130|31|32|33|34|20200305|36|37|38|39|40|41|42|43|20200404000004|20200405000004|46|47|48|49|50|51|52|53|54");

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
                ISegment hl7Segment = new Pv1Segment();
                hl7Segment.FromDelimitedString("PVA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Pv1Segment
            {
                SetIdPv1 = 1,
                PatientClass = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                AssignedPatientLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "3"
                    }
                },
                AdmissionType = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                PreadmitNumber = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "5"
                },
                PriorPatientLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "6"
                    }
                },
                AttendingDoctor = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "7"
                    }
                },
                ReferringDoctor = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "8"
                    }
                },
                ConsultingDoctor = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "9"
                    }
                },
                HospitalService = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                TemporaryLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "11"
                    }
                },
                PreadmitTestIndicator = new CodedWithExceptions
                {
                    Identifier = "12"
                },
                ReadmissionIndicator = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                AdmitSource = new CodedWithExceptions
                {
                    Identifier = "14"
                },
                AmbulatoryStatus = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "15"
                    }
                },
                VipIndicator = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                AdmittingDoctor = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                         PersonIdentifier = "17"
                    }
                },
                PatientType = new CodedWithExceptions
                {
                    Identifier = "18"
                },
                VisitNumber = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "19"
                },
                FinancialClass = new FinancialClass[]
                {
                    new FinancialClass
                    {
                        FinancialClassCode = new CodedWithExceptions
                        {
                            Identifier = "20"
                        }
                    }
                },
                ChargePriceIndicator = new CodedWithExceptions
                {
                    Identifier = "21"
                },
                CourtesyCode = new CodedWithExceptions
                {
                    Identifier = "22"
                },
                CreditRating = new CodedWithExceptions
                {
                    Identifier = "23"
                },
                ContractCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "24"
                    }
                },
                ContractEffectiveDate = new DateTime[]
                {
                    new DateTime(2020, 1, 25)
                },
                ContractAmount = new decimal[]
                {
                    26
                },
                ContractPeriod = new decimal[]
                {
                    27
                },
                InterestCode = new CodedWithExceptions
                {
                    Identifier = "28"
                },
                TransferToBadDebtCode = new CodedWithExceptions
                {
                    Identifier = "29"
                },
                TransferToBadDebtDate = new DateTime(2020, 1, 30),
                BadDebtAgencyCode = new CodedWithExceptions
                {
                    Identifier = "31"
                },
                BadDebtTransferAmount = 32,
                BadDebtRecoveryAmount = 33,
                DeleteAccountIndicator = new CodedWithExceptions
                {
                    Identifier = "34"
                },
                DeleteAccountDate = new DateTime(2020, 3, 5),
                DischargeDisposition = new CodedWithExceptions
                {
                    Identifier = "36"
                },
                DischargedToLocation = new DischargeToLocationAndDate
                {
                    DischargeToLocation = new CodedWithExceptions
                    {
                        Identifier = "37"
                    }
                },
                DietType = new CodedWithExceptions
                {
                    Identifier = "38"
                },
                ServicingFacility = new CodedWithExceptions
                {
                    Identifier = "39"
                },
                BedStatus = new CodedWithExceptions
                {
                    Identifier = "40"
                },
                AccountStatus = new CodedWithExceptions
                {
                    Identifier = "41"
                },
                PendingLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "42"
                    }
                },
                PriorTemporaryLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "43"
                    }
                },
                AdmitDateTime = new DateTime(2020, 4, 4, 0, 0, 4),
                DischargeDateTime = new DateTime(2020, 4, 5, 0, 0, 4),
                CurrentPatientBalance = 46,
                TotalCharges = 47,
                TotalAdjustments = 48,
                TotalPayments = 49,
                AlternateVisitId = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "50"
                    }
                },
                VisitIndicator = new CodedWithExceptions
                {
                    Identifier = "51"
                },
                OtherHealthcareProvider = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "52"
                },
                ServiceEpisodeDescription = "53",
                ServiceEpisodeIdentifier = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "54"
                }
            };

            string expected = "PV1|1|2|3|4|5|6|7|8|9|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|20200125|26|27|28|29|20200130|31|32|33|34|20200305|36|37|38|39|40|41|42|43|20200404000004|20200405000004|46|47|48|49|50|51|52|53|54";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
