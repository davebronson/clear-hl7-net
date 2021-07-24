using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class RoomCoverageTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new RoomCoverage
            {
                RoomType = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "1"
                },
                AmountType = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "2"
                },
                CoverageAmount = 3,
                MoneyOrPercentage = new MoneyOrPercentage
                {
                    IsSubcomponent = true,
                    MoneyOrPercentageIndicator = "4"
                }
            };

            IType actual = new RoomCoverage();
            actual.FromDelimitedString("1^2^3^4");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new RoomCoverage
            {
                RoomType = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                AmountType = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                CoverageAmount = 3,
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
