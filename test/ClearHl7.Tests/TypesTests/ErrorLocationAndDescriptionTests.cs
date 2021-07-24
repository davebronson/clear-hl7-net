using ClearHl7.V260.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class ErrorLocationAndDescriptionTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new ErrorLocationAndDescription
            {
                SegmentId = "1",
                SegmentSequence = 2,
                FieldPosition = 3,
                CodeIdentifyingError = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "4"
                }
            };

            IType actual = new ErrorLocationAndDescription();
            actual.FromDelimitedString("1^2^3^4");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new ErrorLocationAndDescription
            {
                SegmentId = "1",
                SegmentSequence = 2,
                FieldPosition = 3,
                CodeIdentifyingError = new CodedWithExceptions
                {
                    Identifier = "4"
                }
            };

            string expected = "1^2^3^4";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
