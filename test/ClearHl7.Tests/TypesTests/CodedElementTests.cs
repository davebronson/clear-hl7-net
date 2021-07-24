using ClearHl7.V260.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class CodedElementTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new CodedElement
            {
                Identifier = "1",
                Text = "2",
                NameOfCodingSystem = "3",
                AlternateIdentifier = "4",
                AlternateText = "5",
                NameOfAlternateCodingSystem = "6"
            };

            IType actual = new CodedElement();
            actual.FromDelimitedString("1^2^3^4^5^6");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new CodedElement
            {
                Identifier = "1",
                Text = "2",
                NameOfCodingSystem = "3",
                AlternateIdentifier = "4",
                AlternateText = "5",
                NameOfAlternateCodingSystem = "6"
            };

            string expected = "1^2^3^4^5^6";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
