using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class CompositePriceTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new CompositePrice
            {
                Price = new Money
                {
                    IsSubcomponent = true,
                    Quantity = 1
                },
                PriceType = "2",
                FromValue = 3,
                ToValue = 4,
                RangeUnits = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "5"
                },
                RangeType = "6"
            };

            IType actual = new CompositePrice();
            actual.FromDelimitedString("1^2^3^4^5^6");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
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
