using ClearHl7.V251.Segments;
using ClearHl7.V251.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class EqlSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
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
