using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Tq2SegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Tq2Segment
            {
                SetIdTq2 = 1,
                SequenceResultsFlag = "2",
                RelatedPlacerNumber = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "3"
                    }
                },
                RelatedFillerNumber = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "4"
                    }
                },
                RelatedPlacerGroupNumber = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "5"
                    }
                },
                SequenceConditionCode = "6",
                CyclicEntryExitIndicator = "7",
                SequenceConditionTimeInterval = new CompositeQuantityWithUnits
                {
                    Quantity = 8
                },
                CyclicGroupMaximumNumberOfRepeats = 9,
                SpecialServiceRequestRelationship = "10"
            };

            string expected = "TQ2|1|2|3|4|5|6|7|8|9|10";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
