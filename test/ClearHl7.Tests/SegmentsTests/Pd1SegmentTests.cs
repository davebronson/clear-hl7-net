using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Pd1SegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new Pd1Segment
            {
                LivingDependency = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "1"
                    }
                },
                LivingArrangement = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                PatientPrimaryFacility = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "3"
                    }
                },
                PatientPrimaryCareProviderNameIdNo = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "4"
                    }
                },
                StudentIndicator = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                Handicap = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                LivingWillCode = new CodedWithExceptions
                {
                    Identifier = "7"
                },
                OrganDonorCode = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                SeparateBill = "9",
                DuplicatePatient = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "10"
                    }
                },
                PublicityCode = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                ProtectionIndicator = "12",
                ProtectionIndicatorEffectiveDate = new DateTime(2020, 1, 13),
                PlaceOfWorship = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "14"
                    }
                },
                AdvanceDirectiveCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "15"
                    }
                },
                ImmunizationRegistryStatus = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                ImmunizationRegistryStatusEffectiveDate = new DateTime(2020, 1, 17),
                PublicityCodeEffectiveDate = new DateTime(2020, 1, 18),
                MilitaryBranch = new CodedWithExceptions
                {
                    Identifier = "19"
                },
                MilitaryRankGrade = new CodedWithExceptions
                {
                    Identifier = "20"
                },
                MilitaryStatus = new CodedWithExceptions
                {
                    Identifier = "21"
                },
                AdvanceDirectiveLastVerifiedDate = new DateTime(2020, 1, 22),
                RetirementDate = new DateTime(2020, 1, 23)
            };

            ISegment actual = new Pd1Segment();
            actual.FromDelimitedString("PD1|1|2|3|4|5|6|7|8|9|10|11|12|20200113|14|15|16|20200117|20200118|19|20|21|20200122|20200123");

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
                ISegment hl7Segment = new Pd1Segment();
                hl7Segment.FromDelimitedString("PDA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Pd1Segment
            {
                LivingDependency = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "1"
                    }
                },
                LivingArrangement = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                PatientPrimaryFacility = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "3"
                    }
                },
                PatientPrimaryCareProviderNameIdNo = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "4"
                    }
                },
                StudentIndicator = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                Handicap = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                LivingWillCode = new CodedWithExceptions
                {
                    Identifier = "7"
                },
                OrganDonorCode = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                SeparateBill = "9",
                DuplicatePatient = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "10"
                    }
                },
                PublicityCode = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                ProtectionIndicator = "12",
                ProtectionIndicatorEffectiveDate = new DateTime(2020, 1, 13),
                PlaceOfWorship = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "14"
                    }
                },
                AdvanceDirectiveCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "15"
                    }
                },
                ImmunizationRegistryStatus = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                ImmunizationRegistryStatusEffectiveDate = new DateTime(2020, 1, 17),
                PublicityCodeEffectiveDate = new DateTime(2020, 1, 18),
                MilitaryBranch = new CodedWithExceptions
                {
                    Identifier = "19"
                },
                MilitaryRankGrade = new CodedWithExceptions
                {
                    Identifier = "20"
                },
                MilitaryStatus = new CodedWithExceptions
                {
                    Identifier = "21"
                },
                AdvanceDirectiveLastVerifiedDate = new DateTime(2020, 1, 22),
                RetirementDate = new DateTime(2020, 1, 23)
            };

            string expected = "PD1|1|2|3|4|5|6|7|8|9|10|11|12|20200113|14|15|16|20200117|20200118|19|20|21|20200122|20200123";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
