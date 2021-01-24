using ClearHl7.V240.Types;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class TelephoneNumberTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new TelephoneNumber
            {
                Value = "1"
            };

            string expected = "1";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
