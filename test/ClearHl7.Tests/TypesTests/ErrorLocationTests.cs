using ClearHl7.V282.Types;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class ErrorLocationTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new ErrorLocation
            {
                SegmentId = "1",
                SegmentSequence = 2,
                FieldPosition = 3,
                FieldRepetition = 4,
                ComponentNumber = 5,
                SubComponentNumber = 6
            };

            string expected = "1^2^3^4^5^6";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
