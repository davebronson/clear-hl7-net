using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Oh4SegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Oh4Segment
            {
                SetId = 1,
                ActionCode = "2",
                CombatZoneStartDate = new DateTime(2020, 3, 3),
                CombatZoneEndDate = new DateTime(2020, 4, 4),
                EnteredDate = new DateTime(2020, 5, 5),
                CombatZoneUniqueIdentifier = new EntityIdentifier
                {
                    EntityId = "6"
                }
            };

            string expected = "OH4|1|2|20200303|20200404|20200505|6";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
