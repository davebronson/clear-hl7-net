using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class ExtendedCompositeNameAndIdNumberForOrganizationsTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new ExtendedCompositeNameAndIdNumberForOrganizations
            {
                OrganizationName = "1",
                OrganizationNameTypeCode = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "2"
                },
                IdNumber = 3,
                IdentifierCheckDigit = 4,
                CheckDigitScheme = "5",
                AssigningAuthority = new HierarchicDesignator
                {
                    IsSubcomponent = true,
                    NamespaceId = "6"
                },
                IdentifierTypeCode = "7",
                AssigningFacility = new HierarchicDesignator
                {
                    IsSubcomponent = true,
                    NamespaceId = "8"
                },
                NameRepresentationCode = "9",
                OrganizationIdentifier = "10"
            };

            IType actual = new ExtendedCompositeNameAndIdNumberForOrganizations();
            actual.FromDelimitedString("1^2^3^4^5^6^7^8^9^10");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new ExtendedCompositeNameAndIdNumberForOrganizations
            {
                OrganizationName = "1",
                OrganizationNameTypeCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                IdNumber = 3,
                IdentifierCheckDigit = 4,
                CheckDigitScheme = "5",
                AssigningAuthority = new HierarchicDesignator
                {
                    NamespaceId = "6"
                },
                IdentifierTypeCode = "7",
                AssigningFacility = new HierarchicDesignator
                {
                    NamespaceId = "8"
                },
                NameRepresentationCode = "9",
                OrganizationIdentifier = "10"
            };

            string expected = "1^2^3^4^5^6^7^8^9^10";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
