using ClearHl7.V251.Segments;
using ClearHl7.V251.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class ErqSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new ErqSegment
            {
                QueryTag = "1",
                EventIdentifier = new CodedElement
                {
                    Identifier = "2"
                },
                InputParameterList = new QueryInputParameterList
                {
                    SegmentFieldName = "3"
                }
            };

            string expected = "ERQ|1|2|3";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
