using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Oh3SegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Oh3Segment
            {
                SetId = 1,
                ActionCode = "2",
                Occupation = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                Industry = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                UsualOccupationDurationYears = 5,
                StartYear = new DateTime(2020, 6, 6),
                EnteredDate = new DateTime(2020, 7, 7),
                WorkUniqueIdentifier = new EntityIdentifier
                {
                    EntityId = "8"
                }
            };

            string expected = "OH3|1|2|3|4|5|20200606|20200707|8";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
