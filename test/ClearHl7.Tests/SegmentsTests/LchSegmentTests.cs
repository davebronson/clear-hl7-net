using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class LchSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new LchSegment
            {
                PrimaryKeyValueLch = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "1"
                    }
                },
                SegmentActionCode = "2",
                SegmentUniqueKey = new EntityIdentifier
                {
                    EntityId = "3"
                },
                LocationCharacteristicId = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                LocationCharacteristicValueLch = new CodedWithExceptions
                {
                    Identifier = "5"
                }
            };

            string expected = "LCH|1|2|3|4|5";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
