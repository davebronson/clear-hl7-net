using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class MoneyOrPercentageTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new MoneyOrPercentage
            {
                MoneyOrPercentageIndicator = "1",
                MoneyOrPercentageQuantity = 2,
                MonetaryDenomination = "3"
            };

            string expected = "1^2^3";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
