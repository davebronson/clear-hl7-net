using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Ft1SegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new Ft1Segment
            {
                SetIdFt1 = 1,
                TransactionId = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "2"
                },
                TransactionBatchId = "3",
                TransactionDate = new DateTimeRange
                {
                    RangeStartDateTime = new DateTime(2020, 4, 4, 0, 0, 4)
                },
                TransactionPostingDate = new DateTime(2020, 5, 5, 0, 0, 5),
                TransactionType = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                TransactionCode = new CodedWithExceptions
                {
                    Identifier = "7"
                },
                TransactionDescription = "8",
                TransactionDescriptionAlt = "9",
                TransactionQuantity = 10,
                TransactionAmountExtended = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 11
                    }
                },
                TransactionAmountUnit = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 12
                    }
                },
                DepartmentCode = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                HealthPlanId = new CodedWithExceptions
                {
                    Identifier = "14"
                },
                InsuranceAmount = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 15
                    }
                },
                AssignedPatientLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "16"
                    }
                },
                FeeSchedule = new CodedWithExceptions
                {
                    Identifier = "17"
                },
                PatientType = new CodedWithExceptions
                {
                    Identifier = "18"
                },
                DiagnosisCodeFt1 = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "19"
                    }
                },
                PerformedByCode = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "20"
                    }
                },
                OrderedByCode = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "21"
                    }
                },
                UnitCost = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 22
                    }
                },
                FillerOrderNumber = new EntityIdentifier
                {
                    EntityId = "23"
                },
                EnteredByCode = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "24"
                    }
                },
                ProcedureCode = new CodedWithNoExceptions
                {
                    Identifier = "25"
                },
                ProcedureCodeModifier = new CodedWithNoExceptions[]
                {
                    new CodedWithNoExceptions
                    {
                        Identifier = "26"
                    }
                },
                AdvancedBeneficiaryNoticeCode = new CodedWithExceptions
                {
                    Identifier = "27"
                },
                MedicallyNecessaryDuplicateProcedureReason = new CodedWithExceptions
                {
                    Identifier = "28"
                },
                NdcCode = new CodedWithExceptions
                {
                    Identifier = "29"
                },
                PaymentReferenceId = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "30"
                },
                TransactionReferenceKey = new uint[]
                {
                    31
                },
                PerformingFacility = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "32"
                    }
                },
                OrderingFacility = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "33"
                },
                ItemNumber = new CodedWithExceptions
                {
                    Identifier = "34"
                },
                ModelNumber = "35",
                SpecialProcessingCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "36"
                    }
                },
                ClinicCode = new CodedWithExceptions
                {
                    Identifier = "37"
                },
                ReferralNumber = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "38"
                },
                AuthorizationNumber = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "39"
                },
                ServiceProviderTaxonomyCode = new CodedWithExceptions
                {
                    Identifier = "40"
                },
                RevenueCode = new CodedWithExceptions
                {
                    Identifier = "41"
                },
                PrescriptionNumber = "42",
                NdcQtyAndUom = new CompositeQuantityWithUnits
                {
                    Quantity = 43
                },
                DmeCertificateOfMedicalNecessityTransmissionCode = new CodedWithExceptions
                {
                    Identifier = "44"
                },
                DmeCertificationTypeCode = new CodedWithExceptions
                {
                    Identifier = "45"
                },
                DmeDurationValue = 46,
                DmeCertificationRevisionDate = new DateTime(2020, 4, 7),
                DmeInitialCertificationDate = new DateTime(2020, 4, 8),
                DmeLastCertificationDate = new DateTime(2020, 4, 9),
                DmeLengthOfMedicalNecessityDays = 50,
                DmeRentalPrice = new Money
                {
                    Quantity = 51
                },
                DmePurchasePrice = new Money
                {
                    Quantity = 52
                },
                DmeFrequencyCode = new CodedWithExceptions
                {
                    Identifier = "53"
                },
                DmeCertificationConditionIndicator = "54",
                DmeConditionIndicatorCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "55"
                    }
                },
                ServiceReasonCode = new CodedWithExceptions
                {
                    Identifier = "56"
                }
            };

            ISegment actual = new Ft1Segment();
            actual.FromDelimitedString("FT1|1|2|3|20200404000004|20200505000005|6|7|8|9|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41|42|43|44|45|46|20200407|20200408|20200409|50|51|52|53|54|55|56");

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
                ISegment hl7Segment = new Ft1Segment();
                hl7Segment.FromDelimitedString("FTA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Ft1Segment
            {
                SetIdFt1 = 1,
                TransactionId = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "2"
                },
                TransactionBatchId = "3",
                TransactionDate = new DateTimeRange
                {
                    RangeStartDateTime = new DateTime(2020, 4, 4, 0, 0, 4)
                },
                TransactionPostingDate = new DateTime(2020, 5, 5, 0, 0, 5),
                TransactionType = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                TransactionCode = new CodedWithExceptions
                {
                    Identifier = "7"
                },
                TransactionDescription = "8",
                TransactionDescriptionAlt = "9",
                TransactionQuantity = 10,
                TransactionAmountExtended = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 11
                    }
                },
                TransactionAmountUnit = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 12
                    }
                },
                DepartmentCode = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                HealthPlanId = new CodedWithExceptions
                {
                    Identifier = "14"
                },
                InsuranceAmount = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 15
                    }
                },
                AssignedPatientLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "16"
                    }
                },
                FeeSchedule = new CodedWithExceptions
                {
                    Identifier = "17"
                },
                PatientType = new CodedWithExceptions
                {
                    Identifier = "18"
                },
                DiagnosisCodeFt1 = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "19"
                    }
                },
                PerformedByCode = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "20"
                    }
                },
                OrderedByCode = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "21"
                    }
                },
                UnitCost = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 22
                    }
                },
                FillerOrderNumber = new EntityIdentifier
                {
                    EntityId = "23"
                },
                EnteredByCode = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "24"
                    }
                },
                ProcedureCode = new CodedWithNoExceptions
                {
                    Identifier = "25"
                },
                ProcedureCodeModifier = new CodedWithNoExceptions[]
                {
                    new CodedWithNoExceptions
                    {
                        Identifier = "26"
                    }
                },
                AdvancedBeneficiaryNoticeCode = new CodedWithExceptions
                {
                    Identifier = "27"
                },
                MedicallyNecessaryDuplicateProcedureReason = new CodedWithExceptions
                {
                    Identifier = "28"
                },
                NdcCode = new CodedWithExceptions
                {
                    Identifier = "29"
                },
                PaymentReferenceId = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "30"
                },
                TransactionReferenceKey = new uint[]
                {
                    31
                },
                PerformingFacility = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "32"
                    }
                },
                OrderingFacility = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "33"
                },
                ItemNumber = new CodedWithExceptions
                {
                    Identifier = "34"
                },
                ModelNumber = "35",
                SpecialProcessingCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "36"
                    }
                },
                ClinicCode = new CodedWithExceptions
                {
                    Identifier = "37"
                },
                ReferralNumber = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "38"
                },
                AuthorizationNumber = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "39"
                },
                ServiceProviderTaxonomyCode = new CodedWithExceptions
                {
                    Identifier = "40"
                },
                RevenueCode = new CodedWithExceptions
                {
                    Identifier = "41"
                },
                PrescriptionNumber = "42",
                NdcQtyAndUom = new CompositeQuantityWithUnits
                {
                    Quantity = 43
                },
                DmeCertificateOfMedicalNecessityTransmissionCode = new CodedWithExceptions
                {
                    Identifier = "44"
                },
                DmeCertificationTypeCode = new CodedWithExceptions
                {
                    Identifier = "45"
                },
                DmeDurationValue = 46,
                DmeCertificationRevisionDate = new DateTime(2020, 4, 7),
                DmeInitialCertificationDate = new DateTime(2020, 4, 8),
                DmeLastCertificationDate = new DateTime(2020, 4, 9),
                DmeLengthOfMedicalNecessityDays = 50,
                DmeRentalPrice = new Money
                {
                    Quantity = 51
                },
                DmePurchasePrice = new Money
                {
                    Quantity = 52
                },
                DmeFrequencyCode = new CodedWithExceptions
                {
                    Identifier = "53"
                },
                DmeCertificationConditionIndicator = "54",
                DmeConditionIndicatorCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "55"
                    }
                },
                ServiceReasonCode = new CodedWithExceptions
                {
                    Identifier = "56"
                }
            };

            string expected = "FT1|1|2|3|20200404000004|20200505000005|6|7|8|9|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41|42|43|44|45|46|20200407|20200408|20200409|50|51|52|53|54|55|56";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
