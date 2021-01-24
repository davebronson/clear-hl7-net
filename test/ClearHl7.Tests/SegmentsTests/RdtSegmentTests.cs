using ClearHl7.V290.Segments;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class RdtSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new RdtSegment
            {
                ColumnValue = "1"
            };

            string expected = "RDT|1";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
