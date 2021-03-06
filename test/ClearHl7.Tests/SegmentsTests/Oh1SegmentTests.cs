﻿using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Oh1SegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Oh1Segment
            {
                SetId = 1,
                ActionCode = "2",
                EmploymentStatus = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                EmploymentStatusStartDate = new DateTime(2020, 4, 4),
                EmploymentStatusEndDate = new DateTime(2020, 5, 5),
                EnteredDate = new DateTime(2020, 6, 6),
                EmploymentStatusUniqueIdentifier = new EntityIdentifier
                {
                    EntityId = "7"
                }
            };

            string expected = "OH1|1|2|3|20200404|20200505|20200606|7";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
