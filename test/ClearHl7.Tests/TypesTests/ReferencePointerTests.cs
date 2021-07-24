using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class ReferencePointerTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new ReferencePointer
            {
                Pointer = "1",
                ApplicationId = new HierarchicDesignator
                {
                    IsSubcomponent = true,
                    NamespaceId = "2"
                },
                TypeOfData = "3",
                Subtype = "4"
            };

            IType actual = new ReferencePointer();
            actual.FromDelimitedString("1^2^3^4");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new ReferencePointer
            {
                Pointer = "1",
                ApplicationId = new HierarchicDesignator
                {
                    NamespaceId = "2"
                },
                TypeOfData = "3",
                Subtype = "4"
            };

            string expected = "1^2^3^4";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
