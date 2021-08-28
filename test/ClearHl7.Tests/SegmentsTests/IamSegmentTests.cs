using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class IamSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new IamSegment
            {
                SetIdIam = 1,
                AllergenTypeCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                AllergenCodeMnemonicDescription = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                AllergySeverityCode = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                AllergyReactionCode = new string[]
                {
                    "5"
                },
                AllergyActionCode = new CodedWithNoExceptions
                {
                    Identifier = "6"
                },
                AllergyUniqueIdentifier = new EntityIdentifier
                {
                    EntityId = "7"
                },
                ActionReason = "8",
                SensitivityToCausativeAgentCode = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                AllergenGroupCodeMnemonicDescription = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                OnsetDate = new DateTime(2020, 11, 11),
                OnsetDateText = "12",
                ReportedDateTime = new DateTime(2020, 1, 13, 0, 0, 13),
                ReportedBy = new ExtendedPersonName
                {
                    FamilyName = new FamilyName
                    {
                        Surname = "14"
                    }
                },
                RelationshipToPatientCode = new CodedWithExceptions
                {
                    Identifier = "15"
                },
                AlertDeviceCode = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                AllergyClinicalStatusCode = new CodedWithExceptions
                {
                    Identifier = "17"
                },
                StatusedByPerson = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "18"
                },
                StatusedByOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "19"
                },
                StatusedAtDateTime = new DateTime(2020, 1, 20, 0, 0, 20),
                InactivatedByPerson = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "21"
                },
                InactivatedDateTime = new DateTime(2020, 1, 22, 0, 0, 22),
                InitiallyRecordedByPerson = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "23"
                },
                InitiallyRecordedDateTime = new DateTime(2020, 1, 24, 0, 0, 24),
                ModifiedByPerson = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "25"
                },
                ModifiedDateTime = new DateTime(2020, 1, 26, 0, 0, 26),
                ClinicianIdentifiedCode = new CodedWithExceptions
                {
                    Identifier = "27"
                },
                InitiallyRecordedByOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "28"
                },
                ModifiedByOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "29"
                },
                InactivatedByOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "30"
                }
            };

            ISegment actual = new IamSegment();
            actual.FromDelimitedString("IAM|1|2|3|4|5|6|7|8|9|10|20201111|12|20200113000013|14|15|16|17|18|19|20200120000020|21|20200122000022|23|20200124000024|25|20200126000026|27|28|29|30");

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
                ISegment hl7Segment = new IamSegment();
                hl7Segment.FromDelimitedString("IAA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new IamSegment
            {
                SetIdIam = 1,
                AllergenTypeCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                AllergenCodeMnemonicDescription = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                AllergySeverityCode = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                AllergyReactionCode = new string[]
                {
                    "5"
                },
                AllergyActionCode = new CodedWithNoExceptions
                {
                    Identifier = "6"
                },
                AllergyUniqueIdentifier = new EntityIdentifier
                {
                    EntityId = "7"
                },
                ActionReason = "8",
                SensitivityToCausativeAgentCode = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                AllergenGroupCodeMnemonicDescription = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                OnsetDate = new DateTime(2020, 11, 11),
                OnsetDateText = "12",
                ReportedDateTime = new DateTime(2020, 1, 13, 0, 0, 13),
                ReportedBy = new ExtendedPersonName
                {
                    FamilyName = new FamilyName
                    {
                        Surname = "14"
                    }
                },
                RelationshipToPatientCode = new CodedWithExceptions
                {
                    Identifier = "15"
                },
                AlertDeviceCode = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                AllergyClinicalStatusCode = new CodedWithExceptions
                {
                    Identifier = "17"
                },
                StatusedByPerson = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "18"
                },
                StatusedByOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "19"
                },
                StatusedAtDateTime = new DateTime(2020, 1, 20, 0, 0, 20),
                InactivatedByPerson = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "21"
                },
                InactivatedDateTime = new DateTime(2020, 1, 22, 0, 0, 22),
                InitiallyRecordedByPerson = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "23"
                },
                InitiallyRecordedDateTime = new DateTime(2020, 1, 24, 0, 0, 24),
                ModifiedByPerson = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "25"
                },
                ModifiedDateTime = new DateTime(2020, 1, 26, 0, 0, 26),
                ClinicianIdentifiedCode = new CodedWithExceptions
                {
                    Identifier = "27"
                },
                InitiallyRecordedByOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "28"
                },
                ModifiedByOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "29"
                },
                InactivatedByOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "30"
                }
            };

            string expected = "IAM|1|2|3|4|5|6|7|8|9|10|20201111|12|20200113000013|14|15|16|17|18|19|20200120000020|21|20200122000022|23|20200124000024|25|20200126000026|27|28|29|30";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
