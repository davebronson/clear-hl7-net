using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class RdfSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new RdfSegment
            {
                NumberOfColumnsPerRow = 1,
                ColumnDescription = new RowColumnDefinition[]
                {
                    new RowColumnDefinition
                    {
                        SegmentFieldName = "2"
                    }
                }
            };

            string expected = "RDF|1|2";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
