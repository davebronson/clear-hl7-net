using ClearHl7.Fhir.V290.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.TypesTests
{
    public class ExtendedCompositeNameAndIdNumberForOrganizationsTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
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
