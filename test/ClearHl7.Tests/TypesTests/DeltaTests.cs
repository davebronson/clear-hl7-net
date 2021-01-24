using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class DeltaTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new Delta
            {
                NormalRange = new NumericRange
                {
                    LowValue = 1
                },
                NumericThreshold = 2,
                ChangeComputation = "3",
                DaysRetained = 4
            };

            string expected = "1^2^3^4";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
