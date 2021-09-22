using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Pv2SegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new Pv2Segment
            {
                PriorPendingLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        IsSubcomponent = true,
                        NamespaceId = "1"
                    }
                },
                AccommodationCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                AdmitReason = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                TransferReason = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                PatientValuables = new string[]
                {
                    "5"
                },
                PatientValuablesLocation = "6",
                VisitUserCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "7"
                    }
                },
                ExpectedAdmitDateTime = new DateTime(2020, 8, 8, 0, 0, 8),
                ExpectedDischargeDateTime = new DateTime(2020, 9, 9, 0, 0, 9),
                EstimatedLengthOfInpatientStay = 10,
                ActualLengthOfInpatientStay = 11,
                VisitDescription = "12",
                ReferralSourceCode = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "13"
                    }
                },
                PreviousServiceDate = new DateTime(2020, 1, 14),
                EmploymentIllnessRelatedIndicator = "15",
                PurgeStatusCode = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                PurgeStatusDate = new DateTime(2020, 1, 17),
                SpecialProgramCode = new CodedWithExceptions
                {
                    Identifier = "18"
                },
                RetentionIndicator = "19",
                ExpectedNumberOfInsurancePlans = 20,
                VisitPublicityCode = new CodedWithExceptions
                {
                    Identifier = "21"
                },
                VisitProtectionIndicator = "22",
                ClinicOrganizationName = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "23"
                    }
                },
                PatientStatusCode = new CodedWithExceptions
                {
                    Identifier = "24"
                },
                VisitPriorityCode = new CodedWithExceptions
                {
                    Identifier = "25"
                },
                PreviousTreatmentDate = new DateTime(2020, 1, 26),
                ExpectedDischargeDisposition = new CodedWithExceptions
                {
                    Identifier = "27"
                },
                SignatureOnFileDate = new DateTime(2020, 1, 28),
                FirstSimilarIllnessDate = new DateTime(2020, 1, 29),
                PatientChargeAdjustmentCode = new CodedWithExceptions
                {
                    Identifier = "30"
                },
                RecurringServiceCode = new CodedWithExceptions
                {
                    Identifier = "31"
                },
                BillingMediaCode = "32",
                ExpectedSurgeryDateAndTime = new DateTime(2020, 3, 3, 0, 0, 3),
                MilitaryPartnershipCode = "34",
                MilitaryNonAvailabilityCode = "35",
                NewbornBabyIndicator = "36",
                BabyDetainedIndicator = "37",
                ModeOfArrivalCode = new CodedWithExceptions
                {
                    Identifier = "38"
                },
                RecreationalDrugUseCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "39"
                    }
                },
                AdmissionLevelOfCareCode = new CodedWithExceptions
                {
                    Identifier = "40"
                },
                PrecautionCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "41"
                    }
                },
                PatientConditionCode = new CodedWithExceptions
                {
                    Identifier = "42"
                },
                LivingWillCode = new CodedWithExceptions
                {
                    Identifier = "43"
                },
                OrganDonorCode = new CodedWithExceptions
                {
                    Identifier = "44"
                },
                AdvanceDirectiveCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "45"
                    }
                },
                PatientStatusEffectiveDate = new DateTime(2020, 4, 6),
                ExpectedLoaReturnDateTime = new DateTime(2020, 4, 7, 0, 0, 47),
                ExpectedPreAdmissionTestingDateTime = new DateTime(2020, 4, 8, 0, 0, 48),
                NotifyClergyCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "49"
                    }
                },
                AdvanceDirectiveLastVerifiedDate = new DateTime(2020, 5, 1)
            };

            Pv2Segment actual = new();
            actual.FromDelimitedString("PV2|1|2|3|4|5|6|7|20200808000008|20200909000009|10|11|12|13|20200114|15|16|20200117|18|19|20|21|22|23|24|25|20200126|27|20200128|20200129|30|31|32|20200303000003|34|35|36|37|38|39|40|41|42|43|44|45|20200406|20200407000047|20200408000048|49|20200501");

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
                ISegment hl7Segment = new Pv2Segment();
                hl7Segment.FromDelimitedString("PVA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Pv2Segment
            {
                PriorPendingLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "1"
                    }
                },
                AccommodationCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                AdmitReason = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                TransferReason = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                PatientValuables = new string[]
                {
                    "5"
                },
                PatientValuablesLocation = "6",
                VisitUserCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "7"
                    }
                },
                ExpectedAdmitDateTime = new DateTime(2020, 8, 8, 0, 0, 8),
                ExpectedDischargeDateTime = new DateTime(2020, 9, 9, 0, 0, 9),
                EstimatedLengthOfInpatientStay = 10,
                ActualLengthOfInpatientStay = 11,
                VisitDescription = "12",
                ReferralSourceCode = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "13"
                    }
                },
                PreviousServiceDate = new DateTime(2020, 1, 14),
                EmploymentIllnessRelatedIndicator = "15",
                PurgeStatusCode = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                PurgeStatusDate = new DateTime(2020, 1, 17),
                SpecialProgramCode = new CodedWithExceptions
                {
                    Identifier = "18"
                },
                RetentionIndicator = "19",
                ExpectedNumberOfInsurancePlans = 20,
                VisitPublicityCode = new CodedWithExceptions
                {
                    Identifier = "21"
                },
                VisitProtectionIndicator = "22",
                ClinicOrganizationName = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "23"
                    }
                },
                PatientStatusCode = new CodedWithExceptions
                {
                    Identifier = "24"
                },
                VisitPriorityCode = new CodedWithExceptions
                {
                    Identifier = "25"
                },
                PreviousTreatmentDate = new DateTime(2020, 1, 26),
                ExpectedDischargeDisposition = new CodedWithExceptions
                {
                    Identifier = "27"
                },
                SignatureOnFileDate = new DateTime(2020, 1, 28),
                FirstSimilarIllnessDate = new DateTime(2020, 1, 29),
                PatientChargeAdjustmentCode = new CodedWithExceptions
                {
                    Identifier = "30"
                },
                RecurringServiceCode = new CodedWithExceptions
                {
                    Identifier = "31"
                },
                BillingMediaCode = "32",
                ExpectedSurgeryDateAndTime = new DateTime(2020, 3, 3, 0, 0, 3),
                MilitaryPartnershipCode = "34",
                MilitaryNonAvailabilityCode = "35",
                NewbornBabyIndicator = "36",
                BabyDetainedIndicator = "37",
                ModeOfArrivalCode = new CodedWithExceptions
                {
                    Identifier = "38"
                },
                RecreationalDrugUseCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "39"
                    }
                },
                AdmissionLevelOfCareCode = new CodedWithExceptions
                {
                    Identifier = "40"
                },
                PrecautionCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "41"
                    }
                },
                PatientConditionCode = new CodedWithExceptions
                {
                    Identifier = "42"
                },
                LivingWillCode = new CodedWithExceptions
                {
                    Identifier = "43"
                },
                OrganDonorCode = new CodedWithExceptions
                {
                    Identifier = "44"
                },
                AdvanceDirectiveCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "45"
                    }
                },
                PatientStatusEffectiveDate = new DateTime(2020, 4, 6),
                ExpectedLoaReturnDateTime = new DateTime(2020, 4, 7, 0, 0, 47),
                ExpectedPreAdmissionTestingDateTime = new DateTime(2020, 4, 8, 0, 0, 48),
                NotifyClergyCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "49"
                    }
                },
                AdvanceDirectiveLastVerifiedDate = new DateTime(2020, 5, 1)
            };

            string expected = "PV2|1|2|3|4|5|6|7|20200808000008|20200909000009|10|11|12|13|20200114|15|16|20200117|18|19|20|21|22|23|24|25|20200126|27|20200128|20200129|30|31|32|20200303000003|34|35|36|37|38|39|40|41|42|43|44|45|20200406|20200407000047|20200408000048|49|20200501";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
