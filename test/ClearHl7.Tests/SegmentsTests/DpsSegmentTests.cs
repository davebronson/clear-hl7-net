﻿using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class DpsSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new DpsSegment
            {
                DiagnosisCodeMcp = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                ProcedureCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "2"
                    }
                },
                EffectiveDateTime = new DateTime(2020, 3, 3, 0, 0, 3),
                ExpirationDateTime = new DateTime(2020, 4, 4, 0, 0, 4),
                TypeOfLimitation = new CodedWithNoExceptions
                {
                    Identifier = "5"
                }
            };

            string expected = "DPS|1|2|20200303000003|20200404000004|5";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
