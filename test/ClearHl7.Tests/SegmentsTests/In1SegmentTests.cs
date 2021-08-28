using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class In1SegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new In1Segment
            {
                SetIdIn1 = 1,
                HealthPlanId = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                InsuranceCompanyId = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "3"
                    }
                },
                InsuranceCompanyName = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "4"
                    }
                },
                InsuranceCompanyAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "5"
                        }
                    }
                },
                InsuranceCoContactPerson = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "6"
                        }
                    }
                },
                InsuranceCoPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "7"
                    }
                },
                GroupNumber = "8",
                GroupName = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "9"
                    }
                },
                InsuredsGroupEmpId = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "10"
                    }
                },
                InsuredsGroupEmpName = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "11"
                    }
                },
                PlanEffectiveDate = new DateTime(2020, 12, 12),
                PlanExpirationDate = new DateTime(2020, 1, 13),
                AuthorizationInformation = new AuthorizationInformation
                {
                    AuthorizationNumber = "14"
                },
                PlanType = new CodedWithExceptions
                {
                    Identifier = "15"
                },
                NameOfInsured = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "16"
                        }
                    }
                },
                InsuredsRelationshipToPatient = new CodedWithExceptions
                {
                    Identifier = "17"
                },
                InsuredsDateOfBirth = new DateTime(2020, 1, 18, 0, 0, 18),
                InsuredsAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "19"
                        }
                    }
                },
                AssignmentOfBenefits = new CodedWithExceptions
                {
                    Identifier = "20"
                },
                CoordinationOfBenefits = new CodedWithExceptions
                {
                    Identifier = "21"
                },
                CoordOfBenPriority = "22",
                NoticeOfAdmissionFlag = "23",
                NoticeOfAdmissionDate = new DateTime(2020, 1, 24, 0, 0, 24),
                ReportOfEligibilityFlag = "25",
                ReportOfEligibilityDate = new DateTime(2020, 1, 26, 0, 0, 26),
                ReleaseInformationCode = new CodedWithExceptions
                {
                    Identifier = "27"
                },
                PreAdmitCertPac = "28",
                VerificationDateTime = new DateTime(2020, 1, 29, 0, 0, 29),
                VerificationBy = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "30"
                    }
                },
                TypeOfAgreementCode = new CodedWithExceptions
                {
                    Identifier = "31"
                },
                BillingStatus = new CodedWithExceptions
                {
                    Identifier = "32"
                },
                LifetimeReserveDays = 33,
                DelayBeforeLRDay = 34,
                CompanyPlanCode = new CodedWithExceptions
                {
                    Identifier = "35"
                },
                PolicyNumber = "36",
                PolicyDeductible = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 37
                    }
                },
                PolicyLimitAmount = "38",
                PolicyLimitDays = 39,
                RoomRateSemiPrivate = "40",
                RoomRatePrivate = "41",
                InsuredsEmploymentStatus = new CodedWithExceptions
                {
                    Identifier = "42"
                },
                InsuredsAdministrativeSex = new CodedWithExceptions
                {
                    Identifier = "43"
                },
                InsuredsEmployersAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress =  new StreetAddress
                        {
                            StreetOrMailingAddress = "44"
                        }
                    }
                },
                VerificationStatus = "45",
                PriorInsurancePlanId = new CodedWithExceptions
                {
                    Identifier = "46"
                },
                CoverageType = new CodedWithExceptions
                {
                    Identifier = "47"
                },
                Handicap = new CodedWithExceptions
                {
                    Identifier = "48"
                },
                InsuredsIdNumber = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "49"
                    }
                },
                SignatureCode = new CodedWithExceptions
                {
                    Identifier = "50"
                },
                SignatureCodeDate = new DateTime(2020, 5, 1),
                InsuredsBirthPlace = "52",
                VipIndicator = new CodedWithExceptions
                {
                    Identifier = "53"
                },
                ExternalHealthPlanIdentifiers = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "54"
                    }
                },
                InsuranceActionCode = "55"
            };

            ISegment actual = new In1Segment();
            actual.FromDelimitedString("IN1|1|2|3|4|5|6|7|8|9|10|11|20201212|20200113|14|15|16|17|20200118000018|19|20|21|22|23|20200124000024|25|20200126000026|27|28|20200129000029|30|31|32|33|34|35|36|37|38|39|40|41|42|43|44|45|46|47|48|49|50|20200501|52|53|54|55");

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
                ISegment hl7Segment = new In1Segment();
                hl7Segment.FromDelimitedString("INA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new In1Segment
            {
                SetIdIn1 = 1,
                HealthPlanId = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                InsuranceCompanyId = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "3"
                    }
                },
                InsuranceCompanyName = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "4"
                    }
                },
                InsuranceCompanyAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "5"
                        }
                    }
                },
                InsuranceCoContactPerson = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "6"
                        }
                    }
                },
                InsuranceCoPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "7"
                    }
                },
                GroupNumber = "8",
                GroupName = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "9"
                    }
                },
                InsuredsGroupEmpId = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "10"
                    }
                },
                InsuredsGroupEmpName = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "11"
                    }
                },
                PlanEffectiveDate = new DateTime(2020, 12, 12),
                PlanExpirationDate = new DateTime(2020, 1, 13),
                AuthorizationInformation = new AuthorizationInformation
                {
                    AuthorizationNumber = "14"
                },
                PlanType = new CodedWithExceptions
                {
                    Identifier = "15"
                },
                NameOfInsured = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "16"
                        }
                    }
                },
                InsuredsRelationshipToPatient = new CodedWithExceptions
                {
                    Identifier = "17"
                },
                InsuredsDateOfBirth = new DateTime(2020, 1, 18, 0, 0, 18),
                InsuredsAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "19"
                        }
                    }
                },
                AssignmentOfBenefits = new CodedWithExceptions
                {
                    Identifier = "20"
                },
                CoordinationOfBenefits = new CodedWithExceptions
                {
                    Identifier = "21"
                },
                CoordOfBenPriority = "22",
                NoticeOfAdmissionFlag = "23",
                NoticeOfAdmissionDate = new DateTime(2020, 1, 24, 0, 0, 24),
                ReportOfEligibilityFlag = "25",
                ReportOfEligibilityDate = new DateTime(2020, 1, 26, 0, 0, 26),
                ReleaseInformationCode = new CodedWithExceptions
                {
                    Identifier = "27"
                },
                PreAdmitCertPac = "28",
                VerificationDateTime = new DateTime(2020, 1, 29, 0, 0, 29),
                VerificationBy = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "30"
                    }
                },
                TypeOfAgreementCode = new CodedWithExceptions
                {
                    Identifier = "31"
                },
                BillingStatus = new CodedWithExceptions
                {
                    Identifier = "32"
                },
                LifetimeReserveDays = 33,
                DelayBeforeLRDay = 34,
                CompanyPlanCode = new CodedWithExceptions
                {
                    Identifier = "35"
                },
                PolicyNumber = "36",
                PolicyDeductible = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 37
                    }
                },
                PolicyLimitAmount = "38",
                PolicyLimitDays = 39,
                RoomRateSemiPrivate = "40",
                RoomRatePrivate = "41",
                InsuredsEmploymentStatus = new CodedWithExceptions
                {
                    Identifier = "42"
                },
                InsuredsAdministrativeSex = new CodedWithExceptions
                {
                    Identifier = "43"
                },
                InsuredsEmployersAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress =  new StreetAddress
                        {
                            StreetOrMailingAddress = "44"
                        }
                    }
                },
                VerificationStatus = "45",
                PriorInsurancePlanId = new CodedWithExceptions
                {
                    Identifier = "46"
                },
                CoverageType = new CodedWithExceptions
                {
                    Identifier = "47"
                },
                Handicap = new CodedWithExceptions
                {
                    Identifier = "48"
                },
                InsuredsIdNumber = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "49"
                    }
                },
                SignatureCode = new CodedWithExceptions
                {
                    Identifier = "50"
                },
                SignatureCodeDate = new DateTime(2020, 5, 1),
                InsuredsBirthPlace = "52",
                VipIndicator = new CodedWithExceptions
                {
                    Identifier = "53"
                },
                ExternalHealthPlanIdentifiers = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "54"
                    }
                },
                InsuranceActionCode = "55"
            };

            string expected = "IN1|1|2|3|4|5|6|7|8|9|10|11|20201212|20200113|14|15|16|17|20200118000018|19|20|21|22|23|20200124000024|25|20200126000026|27|28|20200129000029|30|31|32|33|34|35|36|37|38|39|40|41|42|43|44|45|46|47|48|49|50|20200501|52|53|54|55";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
