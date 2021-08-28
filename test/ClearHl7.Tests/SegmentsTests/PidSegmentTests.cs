using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class PidSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new PidSegment
            {
                SetIdPid = 1,
                PatientId = "2",
                PatientIdentifierList = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "3"
                    }
                },
                AlternatePatientIdPid = "4",
                PatientName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "5"
                        }
                    }
                },
                MothersMaidenName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "6"
                        }
                    }
                },
                DateTimeOfBirth = new DateTime(2020, 7, 7, 0, 0, 7),
                AdministrativeSex = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                PatientAlias = "9",
                Race = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "10"
                    }
                },
                PatientAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "11"
                        }
                    }
                },
                CountyCode = "12",
                PhoneNumberHome = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "13"
                    }
                },
                PhoneNumberBusiness = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "14"
                    }
                },
                PrimaryLanguage = new CodedWithExceptions
                {
                    Identifier = "15"
                },
                MaritalStatus = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                Religion = new CodedWithExceptions
                {
                    Identifier = "17"
                },
                PatientAccountNumber = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "18"
                },
                SsnNumberPatient = "19",
                DriversLicenseNumberPatient = "20",
                MothersIdentifier = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "21"
                    }
                },
                EthnicGroup = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "22"
                    }
                },
                BirthPlace = "23",
                MultipleBirthIndicator = "24",
                BirthOrder = 25,
                Citizenship = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "26"
                    }
                },
                VeteransMilitaryStatus = new CodedWithExceptions
                {
                    Identifier = "27"
                },
                Nationality = new CodedWithExceptions
                {
                    Identifier = "28"
                },
                PatientDeathDateAndTime = new DateTime(2020, 1, 29, 0, 0, 29),
                PatientDeathIndicator = "30",
                IdentityUnknownIndicator = "31",
                IdentityReliabilityCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "32"
                    }
                },
                LastUpdateDateTime = new DateTime(2020, 3, 3, 0, 0, 33),
                LastUpdateFacility = new HierarchicDesignator
                {
                    NamespaceId = "34",
                },
                TaxonomicClassificationCode = new CodedWithExceptions
                {
                    Identifier = "35"
                },
                BreedCode = new CodedWithExceptions
                {
                    Identifier = "36"
                },
                Strain = "37",
                ProductionClassCode = new CodedWithExceptions
                {
                    Identifier = "38"
                },
                TribalCitizenship = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "39"
                    }
                },
                PatientTelecommunicationInformation = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "40"
                    }
                }
            };

            ISegment actual = new PidSegment();
            actual.FromDelimitedString("PID|1|2|3|4|5|6|20200707000007|8|9|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|20200129000029|30|31|32|20200303000033|34|35|36|37|38|39|40");

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
                ISegment hl7Segment = new PidSegment();
                hl7Segment.FromDelimitedString("PIA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new PidSegment
            {
                SetIdPid = 1,
                PatientId = "2",
                PatientIdentifierList = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "3"
                    }
                },
                AlternatePatientIdPid = "4",
                PatientName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "5"
                        }
                    }
                },
                MothersMaidenName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "6"
                        }
                    }
                },
                DateTimeOfBirth = new DateTime(2020, 7, 7, 0, 0, 7),
                AdministrativeSex = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                PatientAlias = "9",
                Race = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "10"
                    }
                },
                PatientAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "11"
                        }
                    }
                },
                CountyCode = "12",
                PhoneNumberHome = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "13"
                    }
                },
                PhoneNumberBusiness = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "14"
                    }
                },
                PrimaryLanguage = new CodedWithExceptions
                {
                    Identifier = "15"
                },
                MaritalStatus = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                Religion = new CodedWithExceptions
                {
                    Identifier = "17"
                },
                PatientAccountNumber = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "18"
                },
                SsnNumberPatient = "19",
                DriversLicenseNumberPatient = "20",
                MothersIdentifier = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "21"
                    }
                },
                EthnicGroup = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "22"
                    }
                },
                BirthPlace = "23",
                MultipleBirthIndicator = "24",
                BirthOrder = 25,
                Citizenship = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "26"
                    }
                },
                VeteransMilitaryStatus = new CodedWithExceptions
                {
                    Identifier = "27"
                },
                Nationality = new CodedWithExceptions
                {
                    Identifier = "28"
                },
                PatientDeathDateAndTime = new DateTime(2020, 1, 29, 0, 0, 29),
                PatientDeathIndicator = "30",
                IdentityUnknownIndicator = "31",
                IdentityReliabilityCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "32"
                    }
                },
                LastUpdateDateTime = new DateTime(2020, 3, 3, 0, 0, 33),
                LastUpdateFacility = new HierarchicDesignator
                {
                    NamespaceId = "34",
                },
                TaxonomicClassificationCode = new CodedWithExceptions
                {
                    Identifier = "35"
                },
                BreedCode = new CodedWithExceptions
                {
                    Identifier = "36"
                },
                Strain = "37",
                ProductionClassCode = new CodedWithExceptions
                {
                    Identifier = "38"
                },
                TribalCitizenship = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "39"
                    }
                },
                PatientTelecommunicationInformation = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "40"
                    }
                }
            };

            string expected = "PID|1|2|3|4|5|6|20200707000007|8|9|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|20200129000029|30|31|32|20200303000033|34|35|36|37|38|39|40";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
