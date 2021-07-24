using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class MoneyAndChargeCodeTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new MoneyAndChargeCode
            {
                MonetaryAmount = new Money
                {
                    IsSubcomponent = true,
                    Quantity = 1
                },
                ChargeCode = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "2"
                }
            };

            IType actual = new MoneyAndChargeCode();
            actual.FromDelimitedString("1^2");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new MoneyAndChargeCode
            {
                MonetaryAmount = new Money
                {
                    Quantity = 1
                },
                ChargeCode = new CodedWithExceptions
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
