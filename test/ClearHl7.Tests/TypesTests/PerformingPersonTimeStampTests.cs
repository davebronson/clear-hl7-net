using System;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class PerformingPersonTimeStampTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new PerformingPersonTimeStamp
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
                DateTimeActionPerformed = new DateTime(2020, 1, 15, 1, 15, 15),
                NameRepresentationCode = "16",
                NameContext = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "17"
                },
                NameValidityRange = "18",
                NameAssemblyOrder = "19",
                EffectiveDate = new DateTime(2020, 1, 20, 1, 20, 0),
                ExpirationDate = new DateTime(2020, 1, 21, 1, 21, 10),
                ProfessionalSuffix = "22",
                AssigningJurisdiction = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "23"
                },
                AssigningAgencyOrDepartment = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "24"
                },
                SecurityCheck = "25",
                SecurityCheckScheme = "26"
            };

            IType actual = new PerformingPersonTimeStamp();
            actual.FromDelimitedString("1^2^3^4^5^6^7^8^9^10^11^12^13^14^20200115011515^16^17^18^19^20200120012000^20200121012110^22^23^24^25^26");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new PerformingPersonTimeStamp
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
                DateTimeActionPerformed = new DateTime(2020, 1, 15, 1, 15, 15),
                NameRepresentationCode = "16",
                NameContext = new CodedWithExceptions
                {
                    Identifier = "17"
                },
                NameValidityRange = "18",
                NameAssemblyOrder = "19",
                EffectiveDate = new DateTime(2020, 1, 20, 1, 20, 0),
                ExpirationDate = new DateTime(2020, 1, 21, 1, 21, 10),
                ProfessionalSuffix = "22",
                AssigningJurisdiction = new CodedWithExceptions
                {
                    Identifier = "23"
                },
                AssigningAgencyOrDepartment = new CodedWithExceptions
                {
                    Identifier = "24"
                },
                SecurityCheck = "25",
                SecurityCheckScheme = "26"
            };

            string expected = "1^2^3^4^5^6^7^8^9^10^11^12^13^14^20200115011515^16^17^18^19^20200120012000^20200121012110^22^23^24^25^26";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
