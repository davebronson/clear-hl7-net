using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class ParentResultLinkTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new ParentResultLink
            {
                ParentObservationIdentifier = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "1"
                },
                ParentObservationSubIdentifier = "2",
                ParentObservationValueDescriptor = new Text
                {
                    IsSubcomponent = true,
                    Value = "3"
                }
            };

            IType actual = new ParentResultLink();
            actual.FromDelimitedString("1^2^3");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new ParentResultLink
            {
                ParentObservationIdentifier = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                ParentObservationSubIdentifier = "2",
                ParentObservationValueDescriptor = new Text
                {
                    Value = "3"
                }
            };

            string expected = "1^2^3";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
