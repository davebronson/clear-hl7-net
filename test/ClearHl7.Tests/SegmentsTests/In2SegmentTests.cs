using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class In2SegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new In2Segment
            {
                InsuredsEmployeeId = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "1"
                    }
                },
                InsuredsSocialSecurityNumber = "2",
                InsuredsEmployersNameAndId = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "3"
                    }
                },
                EmployerInformationData = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                MailClaimParty = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "5"
                    }
                },
                MedicareHealthInsCardNumber = "6",
                MedicaidCaseName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "7"
                        }
                    }
                },
                MedicaidCaseNumber = "8",
                MilitarySponsorName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "9"
                        }
                    }
                },
                MilitaryIdNumber = "10",
                DependentOfMilitaryRecipient = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                MilitaryOrganization = "12",
                MilitaryStation = "13",
                MilitaryService = new CodedWithExceptions
                {
                    Identifier = "14"
                },
                MilitaryRankGrade = new CodedWithExceptions
                {
                    Identifier = "15"
                },
                MilitaryStatus = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                MilitaryRetireDate = new DateTime(2020, 1, 17),
                MilitaryNonAvailCertOnFile = "18",
                BabyCoverage = "19",
                CombineBabyBill = "20",
                BloodDeductible = "21",
                SpecialCoverageApprovalName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "22"
                        }
                    }
                },
                SpecialCoverageApprovalTitle = "23",
                NonCoveredInsuranceCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "24"
                    }
                },
                PayorId = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "25"
                    }
                },
                PayorSubscriberId = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "26"
                    }
                },
                EligibilitySource = new CodedWithExceptions
                {
                    Identifier = "27"
                },
                RoomCoverageTypeAmount = new RoomCoverage[]
                {
                    new RoomCoverage
                    {
                        RoomType = new CodedWithExceptions
                        {
                            Identifier = "28"
                        }
                    }
                },
                PolicyTypeAmount = new PolicyTypeAndAmount[]
                {
                    new PolicyTypeAndAmount
                    {
                        PolicyType = new CodedWithExceptions
                        {
                            Identifier = "29"
                        }
                    }
                },
                DailyDeductible = new DailyDeductibleInformation
                {
                    DelayDays = 30
                },
                LivingDependency = new CodedWithExceptions
                {
                    Identifier = "31"
                },
                AmbulatoryStatus = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "32"
                    }
                },
                Citizenship = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "33"
                    }
                },
                PrimaryLanguage = new CodedWithExceptions
                {
                    Identifier = "34"
                },
                LivingArrangement = new CodedWithExceptions
                {
                    Identifier = "35"
                },
                PublicityCode = new CodedWithExceptions
                {
                    Identifier = "36"
                },
                ProtectionIndicator = "37",
                StudentIndicator = new CodedWithExceptions
                {
                    Identifier = "38"
                },
                Religion = new CodedWithExceptions
                {
                    Identifier = "39"
                },
                MothersMaidenName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "40"
                        }
                    }
                },
                Nationality = new CodedWithExceptions
                {
                    Identifier = "41"
                },
                EthnicGroup = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "42"
                    }
                },
                MaritalStatus = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "43"
                    }
                },
                InsuredsEmploymentStartDate = new DateTime(2020, 4, 4),
                EmploymentStopDate = new DateTime(2020, 4, 5),
                JobTitle = "46",
                JobCodeClass = new JobCodeClass
                {
                    JobCode = new CodedWithExceptions
                    {
                        Identifier = "47"
                    }
                },
                JobStatus = new CodedWithExceptions
                {
                    Identifier = "48"
                },
                EmployerContactPersonName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "49"
                        }
                    }
                },
                EmployerContactPersonPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "50"
                    }
                },
                EmployerContactReason = new CodedWithExceptions
                {
                    Identifier = "51"
                },
                InsuredsContactPersonsName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "52"
                        }
                    }
                },
                InsuredsContactPersonPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "53"
                    }
                },
                InsuredsContactPersonReason = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "54"
                    }
                },
                RelationshipToThePatientStartDate = new DateTime(2020, 5, 5),
                RelationshipToThePatientStopDate = new DateTime[]
                {
                    new DateTime(2020,5,6)
                },
                InsuranceCoContactReason = new CodedWithExceptions
                {
                    Identifier = "57"
                },
                InsuranceCoContactPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "58"
                    }
                },
                PolicyScope = new CodedWithExceptions
                {
                    Identifier = "59"
                },
                PolicySource = new CodedWithExceptions
                {
                    Identifier = "60"
                },
                PatientMemberNumber = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "61"
                },
                GuarantorsRelationshipToInsured = new CodedWithExceptions
                {
                    Identifier = "62"
                },
                InsuredsPhoneNumberHome = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "63"
                    }
                },
                InsuredsEmployerPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "64"
                    }
                },
                MilitaryHandicappedProgram = new CodedWithExceptions
                {
                    Identifier = "65"
                },
                SuspendFlag = "66",
                CopayLimitFlag = "67",
                StoplossLimitFlag = "68",
                InsuredOrganizationNameAndId = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "69"
                    }
                },
                InsuredEmployerOrganizationNameAndId = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "70"
                    }
                },
                Race = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "71"
                    }
                },
                PatientsRelationshipToInsured = new CodedWithExceptions
                {
                    Identifier = "72"
                },
                CoPayAmount = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 73
                    }
                }
            };

            ISegment actual = new In2Segment();
            actual.FromDelimitedString("IN2|1|2|3|4|5|6|7|8|9|10|11|12|13|14|15|16|20200117|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41|42|43|20200404|20200405|46|47|48|49|50|51|52|53|54|20200505|20200506|57|58|59|60|61|62|63|64|65|66|67|68|69|70|71|72|73");

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
                ISegment hl7Segment = new In2Segment();
                hl7Segment.FromDelimitedString("INA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new In2Segment
            {
                InsuredsEmployeeId = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "1"
                    }
                },
                InsuredsSocialSecurityNumber = "2",
                InsuredsEmployersNameAndId = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "3"
                    }
                },
                EmployerInformationData = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                MailClaimParty = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "5"
                    }
                },
                MedicareHealthInsCardNumber = "6",
                MedicaidCaseName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "7"
                        }
                    }
                },
                MedicaidCaseNumber = "8",
                MilitarySponsorName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "9"
                        }
                    }
                },
                MilitaryIdNumber = "10",
                DependentOfMilitaryRecipient = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                MilitaryOrganization = "12",
                MilitaryStation = "13",
                MilitaryService = new CodedWithExceptions
                {
                    Identifier = "14"
                },
                MilitaryRankGrade = new CodedWithExceptions
                {
                    Identifier = "15"
                },
                MilitaryStatus = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                MilitaryRetireDate = new DateTime(2020, 1, 17),
                MilitaryNonAvailCertOnFile = "18",
                BabyCoverage = "19",
                CombineBabyBill = "20",
                BloodDeductible = "21",
                SpecialCoverageApprovalName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "22"
                        }
                    }
                },
                SpecialCoverageApprovalTitle = "23",
                NonCoveredInsuranceCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "24"
                    }
                },
                PayorId = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "25"
                    }
                },
                PayorSubscriberId = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "26"
                    }
                },
                EligibilitySource = new CodedWithExceptions
                {
                    Identifier = "27"
                },
                RoomCoverageTypeAmount = new RoomCoverage[]
                {
                    new RoomCoverage
                    {
                        RoomType = new CodedWithExceptions
                        {
                            Identifier = "28"
                        }
                    }
                },
                PolicyTypeAmount = new PolicyTypeAndAmount[]
                {
                    new PolicyTypeAndAmount
                    {
                        PolicyType = new CodedWithExceptions
                        {
                            Identifier = "29"
                        }
                    }
                },
                DailyDeductible = new DailyDeductibleInformation
                {
                    DelayDays = 30
                },
                LivingDependency = new CodedWithExceptions
                {
                    Identifier = "31"
                },
                AmbulatoryStatus = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "32"
                    }
                },
                Citizenship = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "33"
                    }
                },
                PrimaryLanguage = new CodedWithExceptions
                {
                    Identifier = "34"
                },
                LivingArrangement = new CodedWithExceptions
                {
                    Identifier = "35"
                },
                PublicityCode = new CodedWithExceptions
                {
                    Identifier = "36"
                },
                ProtectionIndicator = "37",
                StudentIndicator = new CodedWithExceptions
                {
                    Identifier = "38"
                },
                Religion = new CodedWithExceptions
                {
                    Identifier = "39"
                },
                MothersMaidenName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "40"
                        }
                    }
                },
                Nationality = new CodedWithExceptions
                {
                    Identifier = "41"
                },
                EthnicGroup = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "42"
                    }
                },
                MaritalStatus = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "43"
                    }
                },
                InsuredsEmploymentStartDate = new DateTime(2020, 4, 4),
                EmploymentStopDate = new DateTime(2020, 4, 5),
                JobTitle = "46",
                JobCodeClass = new JobCodeClass
                {
                    JobCode = new CodedWithExceptions
                    {
                        Identifier = "47"
                    }
                },
                JobStatus = new CodedWithExceptions
                {
                    Identifier = "48"
                },
                EmployerContactPersonName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "49"
                        }
                    }
                },
                EmployerContactPersonPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "50"
                    }
                },
                EmployerContactReason = new CodedWithExceptions
                {
                    Identifier = "51"
                },
                InsuredsContactPersonsName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "52"
                        }
                    }
                },
                InsuredsContactPersonPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "53"
                    }
                },
                InsuredsContactPersonReason = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "54"
                    }
                },
                RelationshipToThePatientStartDate = new DateTime(2020, 5, 5),
                RelationshipToThePatientStopDate = new DateTime[]
                {
                    new DateTime(2020,5,6)
                },
                InsuranceCoContactReason = new CodedWithExceptions
                {
                    Identifier = "57"
                },
                InsuranceCoContactPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "58"
                    }
                },
                PolicyScope = new CodedWithExceptions
                {
                    Identifier = "59"
                },
                PolicySource = new CodedWithExceptions
                {
                    Identifier = "60"
                },
                PatientMemberNumber = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "61"
                },
                GuarantorsRelationshipToInsured = new CodedWithExceptions
                {
                    Identifier = "62"
                },
                InsuredsPhoneNumberHome = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "63"
                    }
                },
                InsuredsEmployerPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "64"
                    }
                },
                MilitaryHandicappedProgram = new CodedWithExceptions
                {
                    Identifier = "65"
                },
                SuspendFlag = "66",
                CopayLimitFlag = "67",
                StoplossLimitFlag = "68",
                InsuredOrganizationNameAndId = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "69"
                    }
                },
                InsuredEmployerOrganizationNameAndId = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "70"
                    }
                },
                Race = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "71"
                    }
                },
                PatientsRelationshipToInsured = new CodedWithExceptions
                {
                    Identifier = "72"
                },
                CoPayAmount = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 73
                    }
                }
            };

            string expected = "IN2|1|2|3|4|5|6|7|8|9|10|11|12|13|14|15|16|20200117|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41|42|43|20200404|20200405|46|47|48|49|50|51|52|53|54|20200505|20200506|57|58|59|60|61|62|63|64|65|66|67|68|69|70|71|72|73";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
