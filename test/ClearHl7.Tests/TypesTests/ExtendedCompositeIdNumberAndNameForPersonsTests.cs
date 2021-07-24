using System;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class ExtendedCompositeIdNumberAndNameForPersonsTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new ExtendedCompositeIdNumberAndNameForPersons
            {
                PersonIdentifier = "1",
                FamilyName = new FamilyName
                {
                    IsSubcomponent = true,
                    Surname = "2"
                },
                GivenName = "3",
                SecondAndFurtherGivenNamesOrInitialsThereof = "4",
                Suffix = "5",
                Prefix = "6",
                Degree = "7",
                SourceTable = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "8"
                },
                AssigningAuthority = new HierarchicDesignator
                {
                    IsSubcomponent = true,
                    NamespaceId = "9"
                },
                NameTypeCode = "10",
                IdentifierCheckDigit = "11",
                CheckDigitScheme = "12",
                IdentifierTypeCode = "13",
                AssigningFacility = new HierarchicDesignator
                {
                    IsSubcomponent = true,
                    NamespaceId = "14"
                },
                NameRepresentationCode = "15",
                NameContext = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "16"
                },
                NameValidityRange = new DateTimeRange
                {
                    IsSubcomponent = true,
                    RangeStartDateTime = new DateTime(2020, 1, 17, 0, 0, 17)
                },
                NameAssemblyOrder = "18",
                EffectiveDate = new DateTime(2020, 1, 19, 0, 0, 19),
                ExpirationDate = new DateTime(2020, 1, 20, 0, 0, 20),
                ProfessionalSuffix = "21",
                AssigningJurisdiction = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "22"
                },
                AssigningAgencyOrDepartment = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "23"
                },
                SecurityCheck = "24",
                SecurityCheckScheme = "25"
            };

            IType actual = new ExtendedCompositeIdNumberAndNameForPersons();
            actual.FromDelimitedString("1^2^3^4^5^6^7^8^9^10^11^12^13^14^15^16^20200117000017^18^20200119000019^20200120000020^21^22^23^24^25");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new ExtendedCompositeIdNumberAndNameForPersons
            {
                PersonIdentifier = "1",
                FamilyName = new FamilyName
                {
                    Surname = "2"
                },
                GivenName = "3",
                SecondAndFurtherGivenNamesOrInitialsThereof = "4",
                Suffix = "5",
                Prefix = "6",
                Degree = "7",
                SourceTable = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                AssigningAuthority = new HierarchicDesignator
                {
                    NamespaceId = "9"
                },
                NameTypeCode = "10",
                IdentifierCheckDigit = "11",
                CheckDigitScheme = "12",
                IdentifierTypeCode = "13",
                AssigningFacility = new HierarchicDesignator
                {
                    NamespaceId = "14"
                },
                NameRepresentationCode = "15",
                NameContext = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                NameValidityRange = new DateTimeRange
                {
                    RangeStartDateTime = new DateTime(2020, 1, 17, 0, 0, 17)
                },
                NameAssemblyOrder = "18",
                EffectiveDate = new DateTime(2020, 1, 19, 0, 0, 19),
                ExpirationDate = new DateTime(2020, 1, 20, 0, 0, 20),
                ProfessionalSuffix = "21",
                AssigningJurisdiction = new CodedWithExceptions
                {
                    Identifier = "22"
                },
                AssigningAgencyOrDepartment = new CodedWithExceptions
                {
                    Identifier = "23"
                },
                SecurityCheck = "24",
                SecurityCheckScheme = "25"
            };

            string expected = "1^2^3^4^5^6^7^8^9^10^11^12^13^14^15^16^20200117000017^18^20200119000019^20200120000020^21^22^23^24^25";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
