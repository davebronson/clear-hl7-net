﻿using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class MfaSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new MfaSegment
            {
                RecordLevelEventCode = "1",
                MfnControlId = "2",
                EventCompletionDateTime = new DateTime(2020, 3, 3, 0, 0, 3),
                MfnRecordLevelErrorReturn = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                PrimaryKeyValueMfa = new string[]
                {
                    "5"
                },
                PrimaryKeyValueTypeMfa = new string[]
                {
                    "6"
                }
            };

            string expected = "MFA|1|2|20200303000003|4|5|6";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
