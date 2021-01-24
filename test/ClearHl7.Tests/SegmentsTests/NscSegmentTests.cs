using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class NscSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new NscSegment
            {
                ApplicationChangeType = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                CurrentCpu = "2",
                CurrentFileserver = "3",
                CurrentApplication = new HierarchicDesignator
                {
                    NamespaceId = "4"
                },
                CurrentFacility = new HierarchicDesignator
                {
                    NamespaceId = "5"
                },
                NewCpu = "6",
                NewFileserver = "7",
                NewApplication = new HierarchicDesignator
                {
                    NamespaceId = "8"
                },
                NewFacility = new HierarchicDesignator
                {
                    NamespaceId = "9"
                }
            };

            string expected = "NSC|1|2|3|4|5|6|7|8|9";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
