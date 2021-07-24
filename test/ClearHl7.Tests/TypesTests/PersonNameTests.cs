using ClearHl7.V240.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class PersonNameTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new PersonName
            {
                FamilyName = "1",
                GivenName = "2",
                SecondAndFurtherGivenNamesOrInitialsThereof = "3",
                Suffix = "4",
                Prefix = "5",
                Degree = "6"
            };

            IType actual = new PersonName();
            actual.FromDelimitedString("1^2^3^4^5^6");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new PersonName
            {
                FamilyName = "1",
                GivenName = "2",
                SecondAndFurtherGivenNamesOrInitialsThereof = "3",
                Suffix = "4",
                Prefix = "5",
                Degree = "6"
            };

            string expected = "1^2^3^4^5^6";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
