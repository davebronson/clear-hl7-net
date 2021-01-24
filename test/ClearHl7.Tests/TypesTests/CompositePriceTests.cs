using ClearHl7.Fhir.V290.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.TypesTests
{
    public class CompositePriceTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new CompositePrice
            {
                Price = new Money
                {
                    Quantity = 1
                },
                PriceType = "2",
                FromValue = 3,
                ToValue = 4,
                RangeUnits = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                RangeType = "6"
            };

            string expected = "1^2^3^4^5^6";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
