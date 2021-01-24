using ClearHl7.Fhir.V240.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.TypesTests
{
    public class CompositeIdWithCheckDigitTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new CompositeIdWithCheckDigit
            {
                IdNumber = 1,
                CheckDigit = "2",
                CodeIdentifyingTheCheckDigitSchemeEmployed = "3",
                AssigningAuthority = new HierarchicDesignator
                {
                    NamespaceId = "4"
                }
            };

            string expected = "1^2^3^4";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
