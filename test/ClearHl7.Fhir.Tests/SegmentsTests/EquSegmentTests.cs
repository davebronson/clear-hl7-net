using System;
using System.Collections.Generic;
using ClearHl7.Fhir.V282.Segments;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class EquSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new EquSegment
            {
                EquipmentInstanceIdentifier = new List<EntityIdentifier>
                {
                    new EntityIdentifier
                    {
                        EntityId = "1"
                    }
                },
                EventDateTime = new DateTime(2020, 2, 2, 0, 0, 2),
                EquipmentState = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                LocalRemoteControlState = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                AlertLevel = new CodedWithExceptions
                {
                    Identifier = "5"
                }
            };

            string expected = "EQU|1|20200202000002|3|4|5";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
