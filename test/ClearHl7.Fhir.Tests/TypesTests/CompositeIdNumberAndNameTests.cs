using ClearHl7.Fhir.V240.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.TypesTests
{
    public class CompositeIdNumberAndNameTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new CompositeIdNumberAndName
            {
                IdNumber = "1",
                FamilyName = "2",
                GivenName = "3",
                SecondAndFurtherGivenNamesOrInitialsThereof = "4",
                Suffix = "5",
                Prefix = "6",
                Degree = "7",
                SourceTable = "8",
                AssigningAuthority = new HierarchicDesignator
                {
                    NamespaceId = "9"
                }
            };

            string expected = "1^2^3^4^5^6^7^8^9";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
