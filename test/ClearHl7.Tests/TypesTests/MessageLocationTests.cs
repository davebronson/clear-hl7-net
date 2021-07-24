using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class MessageLocationTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new MessageLocation
            {
                SegmentId = "1",
                SegmentSequence = 2,
                FieldPosition = 3,
                FieldRepetition = 4,
                ComponentNumber = 5,
                SubComponentNumber = 6
            };

            IType actual = new MessageLocation();
            actual.FromDelimitedString("1^2^3^4^5^6");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new MessageLocation
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
