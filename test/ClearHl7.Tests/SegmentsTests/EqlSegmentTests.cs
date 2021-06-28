using ClearHl7.V251.Segments;
using ClearHl7.V251.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class EqlSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new EqlSegment
            {
                QueryTag = "1",
                QueryResponseFormatCode = "2",
                EqlQueryName = new CodedElement
                {
                    Identifier = "3"
                },
                EqlQueryStatement = "4"
            };
            ISegment actual = new EqlSegment().FromDelimitedString("EQL|1|2|3|4");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new EqlSegment
            {
                QueryTag = "1",
                QueryResponseFormatCode = "2",
                EqlQueryName = new CodedElement
                {
                    Identifier = "3"
                },
                EqlQueryStatement = "4"
            };

            string expected = "EQL|1|2|3|4";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
