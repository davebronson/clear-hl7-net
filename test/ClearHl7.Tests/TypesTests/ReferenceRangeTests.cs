using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class ReferenceRangeTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new ReferenceRange
            {
                NumericRange = new NumericRange
                {
                    LowValue = 1
                },
                AdministrativeSex = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                AgeRange = new NumericRange
                {
                    LowValue = 3
                },
                GestationalAgeRange = new NumericRange
                {
                    LowValue = 4
                },
                Species = "5",
                RaceSubspecies = "6",
                Conditions = new Text
                {
                    Value = "7"
                }
            };

            string expected = "1^2^3^4^5^6^7";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
