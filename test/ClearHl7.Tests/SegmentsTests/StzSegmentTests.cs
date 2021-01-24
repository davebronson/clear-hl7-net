using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class StzSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new StzSegment
            {
                SterilizationType = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                SterilizationCycle = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                MaintenanceCycle = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                MaintenanceType = new CodedWithExceptions
                {
                    Identifier = "4"
                }
            };

            string expected = "STZ|1|2|3|4";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
