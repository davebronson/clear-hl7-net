using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class FamilyNameTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new FamilyName
            {
                Surname = "1",
                OwnSurnamePrefix = "2",
                OwnSurname = "3",
                SurnamePrefixFromPartnerSpouse = "4",
                SurnameFromPartnerSpouse = "5"
            };

            IType actual = new FamilyName();
            actual.FromDelimitedString("1^2^3^4^5");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new FamilyName
            {
                Surname = "1",
                OwnSurnamePrefix = "2",
                OwnSurname = "3",
                SurnamePrefixFromPartnerSpouse = "4",
                SurnameFromPartnerSpouse = "5"
            };

            string expected = "1^2^3^4^5";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
