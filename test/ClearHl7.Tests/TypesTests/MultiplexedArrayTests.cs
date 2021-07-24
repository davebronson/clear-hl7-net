using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class MultiplexedArrayTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new MultiplexedArray
            {
                SampleYFromChannel1 = 1,
                SampleYFromChannel2 = 2,
                SampleYFromChannel3 = 3,
                SampleYFromChannel4 = 4
            };

            IType actual = new MultiplexedArray();
            actual.FromDelimitedString("1^2^3^4");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new MultiplexedArray
            {
                SampleYFromChannel1 = 1,
                SampleYFromChannel2 = 2,
                SampleYFromChannel3 = 3,
                SampleYFromChannel4 = 4
            };

            string expected = "1^2^3^4";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
