﻿using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class EvnSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new EvnSegment
            {
                EventTypeCode = "1",
                RecordedDateTime = new DateTime(2020, 2, 2, 0, 0, 2),
                DateTimePlannedEvent = new DateTime(2020, 3, 3, 0, 0, 3),
                EventReasonCode = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                OperatorId = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "5"
                    }
                },
                EventOccurred = new DateTime(2020, 6, 6, 0, 0, 6),
                EventFacility = new HierarchicDesignator
                {
                    NamespaceId = "7"
                }
            };

            string expected = "EVN|1|20200202000002|20200303000003|4|5|20200606000006|7";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
