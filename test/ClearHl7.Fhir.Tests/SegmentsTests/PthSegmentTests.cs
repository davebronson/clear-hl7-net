using System;
using ClearHl7.Fhir.V282.Segments;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class PthSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new PthSegment
            {
                ActionCode = "1",
                PathwayId = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                PathwayInstanceId = new EntityIdentifier
                {
                    EntityId = "3"
                },
                PathwayEstablishedDateTime = new DateTime(2020, 4, 4, 0, 0, 4),
                PathwayLifeCycleStatus = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                ChangePathwayLifeCycleStatusDateTime = new DateTime(2020, 6, 6, 0, 0, 6),
                MoodCode = new CodedWithNoExceptions
                {
                    Identifier = "7"
                }
            };

            string expected = "PTH|1|2|3|20200404000004|5|20200606000006|7";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
