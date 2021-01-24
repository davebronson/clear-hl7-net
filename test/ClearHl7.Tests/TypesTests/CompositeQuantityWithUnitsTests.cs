using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class CompositeQuantityWithUnitsTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new CompositeQuantityWithUnits
            {
                Quantity = 1,
                Units = new CodedWithExceptions
                {
                    Identifier = "2"
                }
            };

            string expected = "1^2";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
