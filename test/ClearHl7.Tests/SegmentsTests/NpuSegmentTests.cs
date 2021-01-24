using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class NpuSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new NpuSegment
            {
                BedLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "1"
                    }
                },
                BedStatus = new CodedWithExceptions
                {
                    Identifier = "2"
                }
            };

            string expected = "NPU|1|2";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
