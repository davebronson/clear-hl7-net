using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Gt1SegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new Gt1Segment
            {
                SetIdGt1 = 1,
                GuarantorNumber = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "2"
                    }
                },
                GuarantorName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "3"
                        }
                    }
                },
                GuarantorSpouseName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "4"
                        }
                    }
                },
                GuarantorAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "5"
                        }
                    }
                },
                GuarantorPhNumHome = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "6"
                    }
                },
                GuarantorPhNumBusiness = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "7"
                    }
                },
                GuarantorDateTimeOfBirth = new DateTime(2020, 8, 8, 0, 0, 8),
                GuarantorAdministrativeSex = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                GuarantorType = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                GuarantorRelationship = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                GuarantorSsn = "12",
                GuarantorDateBegin = new DateTime(2020, 1, 13),
                GuarantorDateEnd = new DateTime(2020, 1, 14),
                GuarantorPriority = 15,
                GuarantorEmployerName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "16"
                        }
                    }
                },
                GuarantorEmployerAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "17"
                        }
                    }
                },
                GuarantorEmployerPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "18"
                    }
                },
                GuarantorEmployeeIdNumber = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "19"
                    }
                },
                GuarantorEmploymentStatus = new CodedWithExceptions
                {
                    Identifier = "20"
                },
                GuarantorOrganizationName = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "21"
                    }
                },
                GuarantorBillingHoldFlag = "22",
                GuarantorCreditRatingCode = new CodedWithExceptions
                {
                    Identifier = "23"
                },
                GuarantorDeathDateAndTime = new DateTime(2020, 1, 24, 0, 0, 24),
                GuarantorDeathFlag = "25",
                GuarantorChargeAdjustmentCode = new CodedWithExceptions
                {
                    Identifier = "26"
                },
                GuarantorHouseholdAnnualIncome = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 27
                    }
                },
                GuarantorHouseholdSize = 28,
                GuarantorEmployerIdNumber = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "29"
                    }
                },
                GuarantorMaritalStatusCode = new CodedWithExceptions
                {
                    Identifier = "30"
                },
                GuarantorHireEffectiveDate = new DateTime(2020, 1, 31),
                EmploymentStopDate = new DateTime(2020, 3, 2),
                LivingDependency = new CodedWithExceptions
                {
                    Identifier = "33"
                },
                AmbulatoryStatus = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "34"
                    }
                },
                Citizenship = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "35"
                    }
                },
                PrimaryLanguage = new CodedWithExceptions
                {
                    Identifier = "36"
                },
                LivingArrangement = new CodedWithExceptions
                {
                    Identifier = "37"
                },
                PublicityCode = new CodedWithExceptions
                {
                    Identifier = "38"
                },
                ProtectionIndicator = "39",
                StudentIndicator = new CodedWithExceptions
                {
                    Identifier = "40"
                },
                Religion = new CodedWithExceptions
                {
                    Identifier = "41"
                },
                MothersMaidenName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "42"
                        }
                    }
                },
                Nationality = new CodedWithExceptions
                {
                    Identifier = "43"
                },
                EthnicGroup = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "44"
                    }
                },
                ContactPersonsName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "45"
                        }
                    }
                },
                ContactPersonsTelephoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "46"
                    }
                },
                ContactReason = new CodedWithExceptions
                {
                    Identifier = "47"
                },
                ContactRelationship = new CodedWithExceptions
                {
                    Identifier = "48"
                },
                JobTitle = "49",
                JobCodeClass = new JobCodeClass
                {
                    JobCode = new CodedWithExceptions
                    {
                        Identifier = "50"
                    }
                },
                GuarantorEmployersOrganizationName = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "51"
                    }
                },
                Handicap = new CodedWithExceptions
                {
                    Identifier = "52"
                },
                JobStatus = new CodedWithExceptions
                {
                    Identifier = "53"
                },
                GuarantorFinancialClass = new FinancialClass
                {
                    FinancialClassCode = new CodedWithExceptions
                    {
                        Identifier = "54"
                    }
                },
                GuarantorRace = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "55"
                    }
                },
                GuarantorBirthPlace = "56",
                VipIndicator = new CodedWithExceptions
                {
                    Identifier = "57"
                }
            };

            ISegment actual = new Gt1Segment();
            actual.FromDelimitedString("GT1|1|2|3|4|5|6|7|20200808000008|9|10|11|12|20200113|20200114|15|16|17|18|19|20|21|22|23|20200124000024|25|26|27|28|29|30|20200131|20200302|33|34|35|36|37|38|39|40|41|42|43|44|45|46|47|48|49|50|51|52|53|54|55|56|57");

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
                ISegment hl7Segment = new Gt1Segment();
                hl7Segment.FromDelimitedString("GTA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Gt1Segment
            {
                SetIdGt1 = 1,
                GuarantorNumber = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "2"
                    }
                },
                GuarantorName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "3"
                        }
                    }
                },
                GuarantorSpouseName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "4"
                        }
                    }
                },
                GuarantorAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "5"
                        }
                    }
                },
                GuarantorPhNumHome = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "6"
                    }
                },
                GuarantorPhNumBusiness = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "7"
                    }
                },
                GuarantorDateTimeOfBirth = new DateTime(2020, 8, 8, 0, 0, 8),
                GuarantorAdministrativeSex = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                GuarantorType = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                GuarantorRelationship = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                GuarantorSsn = "12",
                GuarantorDateBegin = new DateTime(2020, 1, 13),
                GuarantorDateEnd = new DateTime(2020, 1, 14),
                GuarantorPriority = 15,
                GuarantorEmployerName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "16"
                        }
                    }
                },
                GuarantorEmployerAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "17"
                        }
                    }
                },
                GuarantorEmployerPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "18"
                    }
                },
                GuarantorEmployeeIdNumber = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "19"
                    }
                },
                GuarantorEmploymentStatus = new CodedWithExceptions
                {
                    Identifier = "20"
                },
                GuarantorOrganizationName = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "21"
                    }
                },
                GuarantorBillingHoldFlag = "22",
                GuarantorCreditRatingCode = new CodedWithExceptions
                {
                    Identifier = "23"
                },
                GuarantorDeathDateAndTime = new DateTime(2020, 1, 24, 0, 0, 24),
                GuarantorDeathFlag = "25",
                GuarantorChargeAdjustmentCode = new CodedWithExceptions
                {
                    Identifier = "26"
                },
                GuarantorHouseholdAnnualIncome = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 27
                    }
                },
                GuarantorHouseholdSize = 28,
                GuarantorEmployerIdNumber = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "29"
                    }
                },
                GuarantorMaritalStatusCode = new CodedWithExceptions
                {
                    Identifier = "30"
                },
                GuarantorHireEffectiveDate = new DateTime(2020, 1, 31),
                EmploymentStopDate = new DateTime(2020, 3, 2),
                LivingDependency = new CodedWithExceptions
                {
                    Identifier = "33"
                },
                AmbulatoryStatus = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "34"
                    }
                },
                Citizenship = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "35"
                    }
                },
                PrimaryLanguage = new CodedWithExceptions
                {
                    Identifier = "36"
                },
                LivingArrangement = new CodedWithExceptions
                {
                    Identifier = "37"
                },
                PublicityCode = new CodedWithExceptions
                {
                    Identifier = "38"
                },
                ProtectionIndicator = "39",
                StudentIndicator = new CodedWithExceptions
                {
                    Identifier = "40"
                },
                Religion = new CodedWithExceptions
                {
                    Identifier = "41"
                },
                MothersMaidenName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "42"
                        }
                    }
                },
                Nationality = new CodedWithExceptions
                {
                    Identifier = "43"
                },
                EthnicGroup = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "44"
                    }
                },
                ContactPersonsName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "45"
                        }
                    }
                },
                ContactPersonsTelephoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "46"
                    }
                },
                ContactReason = new CodedWithExceptions
                {
                    Identifier = "47"
                },
                ContactRelationship = new CodedWithExceptions
                {
                    Identifier = "48"
                },
                JobTitle = "49",
                JobCodeClass = new JobCodeClass
                {
                    JobCode = new CodedWithExceptions
                    {
                        Identifier = "50"
                    }
                },
                GuarantorEmployersOrganizationName = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "51"
                    }
                },
                Handicap = new CodedWithExceptions
                {
                    Identifier = "52"
                },
                JobStatus = new CodedWithExceptions
                {
                    Identifier = "53"
                },
                GuarantorFinancialClass = new FinancialClass
                {
                    FinancialClassCode = new CodedWithExceptions
                    {
                        Identifier = "54"
                    }
                },
                GuarantorRace = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "55"
                    }
                },
                GuarantorBirthPlace = "56",
                VipIndicator = new CodedWithExceptions
                {
                    Identifier = "57"
                }
            };

            string expected = "GT1|1|2|3|4|5|6|7|20200808000008|9|10|11|12|20200113|20200114|15|16|17|18|19|20|21|22|23|20200124000024|25|26|27|28|29|30|20200131|20200302|33|34|35|36|37|38|39|40|41|42|43|44|45|46|47|48|49|50|51|52|53|54|55|56|57";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
