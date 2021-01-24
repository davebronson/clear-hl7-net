using ClearHl7.V240.Types;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class ChargeToPractiseTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new ChargeToPractise
            {
                DollarAmount = new Money
                {
                    Quantity = 1
                },
                ChargeCode = new CodedElement
                {
                    Identifier = "2"
                }
            };

            string expected = "1^2";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
