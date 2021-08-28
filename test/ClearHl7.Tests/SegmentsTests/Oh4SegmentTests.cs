using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Oh4SegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new Oh4Segment
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

            ISegment actual = new Oh4Segment();
            actual.FromDelimitedString("OH4|1|2|20200303|20200404|20200505|6");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that calling FromDelimitedString() with a string input containing an incorrect segment ID results in an ArgumentException being thrown.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithIncorrectSegmentId_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ISegment hl7Segment = new Oh4Segment();
                hl7Segment.FromDelimitedString("OHA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
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
