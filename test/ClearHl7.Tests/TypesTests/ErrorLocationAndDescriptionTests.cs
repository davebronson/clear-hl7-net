using ClearHl7.V260.Types;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class ErrorLocationAndDescriptionTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
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
