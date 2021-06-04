using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class DailyDeductibleInformationTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            DailyDeductibleInformation expected = new()
            {
                DelayDays = 1,
                MonetaryAmount = new Money
                {
                    IsSubcomponent = true,
                    Quantity = 2
                },
                NumberOfDays = 3
            };
            DailyDeductibleInformation actual = new DailyDeductibleInformation().FromDelimitedString("1^2^3");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new DailyDeductibleInformation
            {
                DelayDays = 1,
                MonetaryAmount = new Money
                {
                    Quantity = 2
                },
                NumberOfDays = 3
            };

            string expected = "1^2^3";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
