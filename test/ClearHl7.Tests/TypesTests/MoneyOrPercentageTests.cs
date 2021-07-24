using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class MoneyOrPercentageTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new MoneyOrPercentage
            {
                MoneyOrPercentageIndicator = "1",
                MoneyOrPercentageQuantity = 2,
                MonetaryDenomination = "3"
            };

            IType actual = new MoneyOrPercentage();
            actual.FromDelimitedString("1^2^3");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
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
