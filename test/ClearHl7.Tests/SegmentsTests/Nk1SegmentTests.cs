using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Nk1SegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new Nk1Segment
            {
                SetIdNk1 = 1,
                Name = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "2"
                        }
                    }
                },
                Relationship = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                Address = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "4"
                        }
                    }
                },
                PhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "5"
                    }
                },
                BusinessPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "6"
                    }
                },
                ContactRole = new CodedWithExceptions
                {
                    Identifier = "7"
                },
                StartDate = new DateTime(2020, 8, 8),
                EndDate = new DateTime(2020, 9, 9),
                NextOfKinAssociatedPartiesJobTitle = "10",
                NextOfKinAssociatedPartiesJobCodeClass = new JobCodeClass
                {
                    JobCode = new CodedWithExceptions
                    {
                        Identifier = "11"
                    }
                },
                NextOfKinAssociatedPartiesEmployeeNumber = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "12"
                },
                OrganizationNameNk1 = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "13"
                    }
                },
                MaritalStatus = new CodedWithExceptions
                {
                    Identifier = "14"
                },
                AdministrativeSex = new CodedWithExceptions
                {
                    Identifier = "15"
                },
                DateTimeOfBirth = new DateTime(2020, 1, 16, 0, 0, 16),
                LivingDependency = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "17"
                    }
                },
                AmbulatoryStatus = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "18"
                    }
                },
                Citizenship = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "19"
                    }
                },
                PrimaryLanguage = new CodedWithExceptions
                {
                    Identifier = "20"
                },
                LivingArrangement = new CodedWithExceptions
                {
                    Identifier = "21"
                },
                PublicityCode = new CodedWithExceptions
                {
                    Identifier = "22"
                },
                ProtectionIndicator = "23",
                StudentIndicator = new CodedWithExceptions
                {
                    Identifier = "24"
                },
                Religion = new CodedWithExceptions
                {
                    Identifier = "25"
                },
                MothersMaidenName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "26"
                        }
                    }
                },
                Nationality = new CodedWithExceptions
                {
                    Identifier = "27"
                },
                EthnicGroup = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "28"
                    }
                },
                ContactReason = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "29"
                    }
                },
                ContactPersonsName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "30"
                        }
                    }
                },
                ContactPersonsTelephoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "31"
                    }
                },
                ContactPersonsAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "32"
                        }
                    }
                },
                NextOfKinAssociatedPartysIdentifiers = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "33"
                    }
                },
                JobStatus = new CodedWithExceptions
                {
                    Identifier = "34"
                },
                Race = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "35"
                    }
                },
                Handicap = new CodedWithExceptions
                {
                    Identifier = "36"
                },
                ContactPersonSocialSecurityNumber = "37",
                NextOfKinBirthPlace = "38",
                VipIndicator = new CodedWithExceptions
                {
                    Identifier = "39"
                },
                NextOfKinTelecommunicationInformation = new ExtendedTelecommunicationNumber
                {
                    TelephoneNumber = "40"
                },
                ContactPersonsTelecommunicationInformation = new ExtendedTelecommunicationNumber
                {
                    TelephoneNumber = "41"
                }
            };

            ISegment actual = new Nk1Segment();
            actual.FromDelimitedString("NK1|1|2|3|4|5|6|7|20200808|20200909|10|11|12|13|14|15|20200116000016|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41");

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
                ISegment hl7Segment = new Nk1Segment();
                hl7Segment.FromDelimitedString("NKA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Nk1Segment
            {
                SetIdNk1 = 1,
                Name = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "2"
                        }
                    }
                },
                Relationship = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                Address = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "4"
                        }
                    }
                },
                PhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "5"
                    }
                },
                BusinessPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "6"
                    }
                },
                ContactRole = new CodedWithExceptions
                {
                    Identifier = "7"
                },
                StartDate = new DateTime(2020, 8, 8),
                EndDate = new DateTime(2020, 9, 9),
                NextOfKinAssociatedPartiesJobTitle = "10",
                NextOfKinAssociatedPartiesJobCodeClass = new JobCodeClass
                {
                    JobCode = new CodedWithExceptions
                    {
                        Identifier = "11"
                    }
                },
                NextOfKinAssociatedPartiesEmployeeNumber = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "12"
                },
                OrganizationNameNk1 = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "13"
                    }
                },
                MaritalStatus = new CodedWithExceptions
                {
                    Identifier = "14"
                },
                AdministrativeSex = new CodedWithExceptions
                {
                    Identifier = "15"
                },
                DateTimeOfBirth = new DateTime(2020, 1, 16, 0, 0, 16),
                LivingDependency = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "17"
                    }
                },
                AmbulatoryStatus = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "18"
                    }
                },
                Citizenship = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "19"
                    }
                },
                PrimaryLanguage = new CodedWithExceptions
                {
                    Identifier = "20"
                },
                LivingArrangement = new CodedWithExceptions
                {
                    Identifier = "21"
                },
                PublicityCode = new CodedWithExceptions
                {
                    Identifier = "22"
                },
                ProtectionIndicator = "23",
                StudentIndicator = new CodedWithExceptions
                {
                    Identifier = "24"
                },
                Religion = new CodedWithExceptions
                {
                    Identifier = "25"
                },
                MothersMaidenName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "26"
                        }
                    }
                },
                Nationality = new CodedWithExceptions
                {
                    Identifier = "27"
                },
                EthnicGroup = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "28"
                    }
                },
                ContactReason = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "29"
                    }
                },
                ContactPersonsName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "30"
                        }
                    }
                },
                ContactPersonsTelephoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "31"
                    }
                },
                ContactPersonsAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "32"
                        }
                    }
                },
                NextOfKinAssociatedPartysIdentifiers = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "33"
                    }
                },
                JobStatus = new CodedWithExceptions
                {
                    Identifier = "34"
                },
                Race = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "35"
                    }
                },
                Handicap = new CodedWithExceptions
                {
                    Identifier = "36"
                },
                ContactPersonSocialSecurityNumber = "37",
                NextOfKinBirthPlace = "38",
                VipIndicator = new CodedWithExceptions
                {
                    Identifier = "39"
                },
                NextOfKinTelecommunicationInformation = new ExtendedTelecommunicationNumber
                {
                    TelephoneNumber = "40"
                },
                ContactPersonsTelecommunicationInformation = new ExtendedTelecommunicationNumber
                {
                    TelephoneNumber = "41"
                }
            };

            string expected = "NK1|1|2|3|4|5|6|7|20200808|20200909|10|11|12|13|14|15|20200116000016|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
