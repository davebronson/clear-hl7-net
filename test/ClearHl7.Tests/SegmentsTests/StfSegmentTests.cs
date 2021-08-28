using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class StfSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new StfSegment
            {
                PrimaryKeyValueStf = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                StaffIdentifierList = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "2"
                    }
                },
                StaffName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "3"
                        }
                    }
                },
                StaffType = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "4"
                    }
                },
                AdministrativeSex = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                DateTimeOfBirth = new DateTime(2020, 6, 6, 0, 0, 6),
                ActiveInactiveFlag = "7",
                Department = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "8"
                    }
                },
                HospitalServiceStf = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "9"
                    }
                },
                Phone = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "10"
                    }
                },
                OfficeHomeAddressBirthplace = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "11"
                        }
                    }
                },
                InstitutionActivationDate = new DateAndInstitutionName[]
                {
                    new DateAndInstitutionName
                    {
                        Date = new DateTime(2020, 12, 12)
                    }
                },
                InstitutionInactivationDate = new DateAndInstitutionName[]
                {
                    new DateAndInstitutionName
                    {
                        Date = new DateTime(2020, 1, 13)
                    }
                },
                BackupPersonId = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "14"
                    }
                },
                EmailAddress = new string[]
                {
                    "15"
                },
                PreferredMethodOfContact = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                MaritalStatus = new CodedWithExceptions
                {
                    Identifier = "17"
                },
                JobTitle = "18",
                JobCodeClass = new JobCodeClass
                {
                    JobCode = new CodedWithExceptions
                    {
                        Identifier = "19"
                    }
                },
                EmploymentStatusCode = new CodedWithExceptions
                {
                    Identifier = "20"
                },
                AdditionalInsuredOnAuto = "21",
                DriversLicenseNumberStaff = new DriversLicenseNumber
                {
                    LicenseNumber = "22"
                },
                CopyAutoIns = "23",
                AutoInsExpires = new DateTime(2020, 1, 24),
                DateLastDmvReview = new DateTime(2020, 1, 25),
                DateNextDmvReview = new DateTime(2020, 1, 26),
                Race = new CodedWithExceptions
                {
                    Identifier = "27"
                },
                EthnicGroup = new CodedWithExceptions
                {
                    Identifier = "28"
                },
                ReactivationApprovalIndicator = "29",
                Citizenship = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "30"
                    }
                },
                DateTimeOfDeath = new DateTime(2020, 1, 31, 0, 0, 31),
                DeathIndicator = "32",
                InstitutionRelationshipTypeCode = new CodedWithExceptions
                {
                    Identifier = "33"
                },
                InstitutionRelationshipPeriod = new DateTimeRange
                {
                    RangeStartDateTime = new DateTime(2020, 3, 4, 0, 0, 34)
                },
                ExpectedReturnDate = new DateTime(2020, 3, 5),
                CostCenterCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "36"
                    }
                },
                GenericClassificationIndicator = "37",
                InactiveReasonCode = new CodedWithExceptions
                {
                    Identifier = "38"
                },
                GenericResourceTypeOrCategory = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "39"
                    }
                },
                Religion = new CodedWithExceptions
                {
                    Identifier = "40"
                },
                Signature = new EncapsulatedData
                {
                    SourceApplication = new HierarchicDesignator
                    {
                        NamespaceId = "41"
                    }
                }
            };

            ISegment actual = new StfSegment();
            actual.FromDelimitedString("STF|1|2|3|4|5|20200606000006|7|8|9|10|11|20201212|20200113|14|15|16|17|18|19|20|21|22|23|20200124|20200125|20200126|27|28|29|30|20200131000031|32|33|20200304000034|20200305|36|37|38|39|40|41");

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
                ISegment hl7Segment = new StfSegment();
                hl7Segment.FromDelimitedString("STA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new StfSegment
            {
                PrimaryKeyValueStf = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                StaffIdentifierList = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "2"
                    }
                },
                StaffName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "3"
                        }
                    }
                },
                StaffType = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "4"
                    }
                },
                AdministrativeSex = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                DateTimeOfBirth = new DateTime(2020, 6, 6, 0, 0, 6),
                ActiveInactiveFlag = "7",
                Department = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "8"
                    }
                },
                HospitalServiceStf = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "9"
                    }
                },
                Phone = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "10"
                    }
                },
                OfficeHomeAddressBirthplace = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "11"
                        }
                    }
                },
                InstitutionActivationDate = new DateAndInstitutionName[]
                {
                    new DateAndInstitutionName
                    {
                        Date = new DateTime(2020, 12, 12)
                    }
                },
                InstitutionInactivationDate = new DateAndInstitutionName[]
                {
                    new DateAndInstitutionName
                    {
                        Date = new DateTime(2020, 1, 13)
                    }
                },
                BackupPersonId = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "14"
                    }
                },
                EmailAddress = new string[]
                {
                    "15"
                },
                PreferredMethodOfContact = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                MaritalStatus = new CodedWithExceptions
                {
                    Identifier = "17"
                },
                JobTitle = "18",
                JobCodeClass = new JobCodeClass
                {
                    JobCode = new CodedWithExceptions
                    {
                        Identifier = "19"
                    }
                },
                EmploymentStatusCode = new CodedWithExceptions
                {
                    Identifier = "20"
                },
                AdditionalInsuredOnAuto = "21",
                DriversLicenseNumberStaff = new DriversLicenseNumber
                {
                    LicenseNumber = "22"
                },
                CopyAutoIns = "23",
                AutoInsExpires = new DateTime(2020, 1, 24),
                DateLastDmvReview = new DateTime(2020, 1, 25),
                DateNextDmvReview = new DateTime(2020, 1, 26),
                Race = new CodedWithExceptions
                {
                    Identifier = "27"
                },
                EthnicGroup = new CodedWithExceptions
                {
                    Identifier = "28"
                },
                ReactivationApprovalIndicator = "29",
                Citizenship = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "30"
                    }
                },
                DateTimeOfDeath = new DateTime(2020, 1, 31, 0, 0, 31),
                DeathIndicator = "32",
                InstitutionRelationshipTypeCode = new CodedWithExceptions
                {
                    Identifier = "33"
                },
                InstitutionRelationshipPeriod = new DateTimeRange
                {
                    RangeStartDateTime = new DateTime(2020, 3, 4, 0, 0, 34)
                },
                ExpectedReturnDate = new DateTime(2020, 3, 5),
                CostCenterCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "36"
                    }
                },
                GenericClassificationIndicator = "37",
                InactiveReasonCode = new CodedWithExceptions
                {
                    Identifier = "38"
                },
                GenericResourceTypeOrCategory = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "39"
                    }
                },
                Religion = new CodedWithExceptions
                {
                    Identifier = "40"
                },
                Signature = new EncapsulatedData
                {
                    SourceApplication = new HierarchicDesignator
                    {
                        NamespaceId = "41"
                    }
                }
            };

            string expected = "STF|1|2|3|4|5|20200606000006|7|8|9|10|11|20201212|20200113|14|15|16|17|18|19|20|21|22|23|20200124|20200125|20200126|27|28|29|30|20200131000031|32|33|20200304000034|20200305|36|37|38|39|40|41";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
