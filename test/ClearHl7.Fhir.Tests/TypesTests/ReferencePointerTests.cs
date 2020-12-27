using ClearHl7.Fhir.V290.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.TypesTests
{
    public class ReferencePointerTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new ReferencePointer
            {
                Pointer = "1",
                ApplicationId = new HierarchicDesignator
                {
                    NamespaceId = "2"
                },
                TypeOfData = "3",
                Subtype = "4"
            };

            string expected = "1^2^3^4";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
