using System;
using ClearHl7.Fhir.V290.Segments;
using ClearHl7.Fhir.V290.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class AigSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new AigSegment
            {
                SetIdAig = 1,
                SegmentActionCode = "2",
                ResourceId = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                ResourceType = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                ResourceGroup = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "5"
                    }
                },
                ResourceQuantity = 6,
                ResourceQuantityUnits = new CodedWithNoExceptions
                {
                    Identifier = "7"
                },
                StartDateTime = new DateTime(2020, 8, 8, 0, 0, 8),
                StartDateTimeOffset = 9,
                StartDateTimeOffsetUnits = new CodedWithNoExceptions
                {
                    Identifier = "10"
                },
                Duration = 11,
                DurationUnits = new CodedWithNoExceptions
                {
                    Identifier = "12"
                },
                AllowSubstitutionCode = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                FillerStatusCode = new CodedWithExceptions
                {
                    Identifier = "14"
                }
            };

            string expected = "AIG|1|2|3|4|5|6|7|20200808000008|9|10|11|12|13|14";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
