using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class RowColumnDefinitionTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            RowColumnDefinition expected = new()
            {
                SegmentFieldName = "1",
                Hl7DataType = "2",
                MaximumColumnWidth = 3
            };
            RowColumnDefinition actual = new RowColumnDefinition().FromDelimitedString("1^2^3");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new RowColumnDefinition
            {
                SegmentFieldName = "1",
                Hl7DataType = "2",
                MaximumColumnWidth = 3
            };

            string expected = "1^2^3";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
