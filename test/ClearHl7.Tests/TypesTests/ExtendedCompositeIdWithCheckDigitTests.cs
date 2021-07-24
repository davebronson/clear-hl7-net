using System;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class ExtendedCompositeIdWithCheckDigitTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new ExtendedCompositeIdWithCheckDigit
            {
                IdNumber = "1",
                IdentifierCheckDigit = "2",
                CheckDigitScheme = "3",
                AssigningAuthority = new HierarchicDesignator
                {
                    IsSubcomponent = true,
                    NamespaceId = "4"
                },
                IdentifierTypeCode = "5",
                AssigningFacility = new HierarchicDesignator
                {
                    IsSubcomponent = true,
                    NamespaceId = "6"
                },
                EffectiveDate = new DateTime(2020, 7, 7),
                ExpirationDate = new DateTime(2020, 8, 8),
                AssigningJurisdiction = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "9"
                },
                AssigningAgencyOrDepartment = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "10"
                },
                SecurityCheck = "11",
                SecurityCheckScheme = "12"
            };

            IType actual = new ExtendedCompositeIdWithCheckDigit();
            actual.FromDelimitedString("1^2^3^4^5^6^20200707^20200808^9^10^11^12");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new ExtendedCompositeIdWithCheckDigit
            {
                IdNumber = "1",
                IdentifierCheckDigit = "2",
                CheckDigitScheme = "3",
                AssigningAuthority = new HierarchicDesignator
                {
                    NamespaceId = "4"
                },
                IdentifierTypeCode = "5",
                AssigningFacility = new HierarchicDesignator
                {
                    NamespaceId = "6"
                },
                EffectiveDate = new DateTime(2020, 7, 7),
                ExpirationDate = new DateTime(2020, 8, 8),
                AssigningJurisdiction = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                AssigningAgencyOrDepartment = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                SecurityCheck = "11",
                SecurityCheckScheme = "12"
            };

            string expected = "1^2^3^4^5^6^20200707^20200808^9^10^11^12";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
