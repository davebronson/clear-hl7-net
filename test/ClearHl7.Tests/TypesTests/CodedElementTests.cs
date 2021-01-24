using ClearHl7.Fhir.V260.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.TypesTests
{
    public class CodedElementTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new CodedElement
            {
                Identifier = "1",
                Text = "2",
                NameOfCodingSystem = "3",
                AlternateIdentifier = "4",
                AlternateText = "5",
                NameOfAlternateCodingSystem = "6"
            };

            string expected = "1^2^3^4^5^6";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
