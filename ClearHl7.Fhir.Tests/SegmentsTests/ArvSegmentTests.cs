using System;
using System.Collections.Generic;
using ClearHl7.Fhir.V282.Segments;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class ArvSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new ArvSegment
            {
                SetId = 1,
                AccessRestrictionActionCode = new CodedWithNoExceptions
                {
                    Identifier = "2"
                },
                AccessRestrictionValue = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                AccessRestrictionReason = new List<CodedWithExceptions>
                {
                    new CodedWithExceptions
                    {
                        Identifier = "4"
                    }
                },
                SpecialAccessRestrictionInstructions = new List<string>
                {
                    "5"
                },
                AccessRestrictionDateRange = new DateTimeRange
                {
                    RangeStartDateTime = new DateTime(2020, 6, 6, 0, 0, 6)
                }
            };

            string expected = "ARV|1|2|3|4|5|20200606000006";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
