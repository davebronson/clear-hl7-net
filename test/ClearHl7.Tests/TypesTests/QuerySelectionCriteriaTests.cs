using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class QuerySelectionCriteriaTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new QuerySelectionCriteria
            {
                SegmentFieldName = "1",
                RelationalOperator = "2",
                Value = "3",
                RelationalConjunction = "4"
            };

            IType actual = new QuerySelectionCriteria();
            actual.FromDelimitedString("1^2^3^4");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new QuerySelectionCriteria
            {
                SegmentFieldName = "1",
                RelationalOperator = "2",
                Value = "3",
                RelationalConjunction = "4"
            };

            string expected = "1^2^3^4";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
