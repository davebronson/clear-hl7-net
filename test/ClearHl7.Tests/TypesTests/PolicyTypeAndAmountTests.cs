using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class PolicyTypeAndAmountTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new PolicyTypeAndAmount
            {
                PolicyType = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                AmountClass = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                MoneyOrPercentageQuantity = 3,
                MoneyOrPercentage = new MoneyOrPercentage
                {
                    MoneyOrPercentageIndicator = "4"
                }
            };

            string expected = "1^2^3^4";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
