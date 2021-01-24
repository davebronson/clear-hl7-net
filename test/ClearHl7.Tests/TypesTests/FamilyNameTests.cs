using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class FamilyNameTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
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
