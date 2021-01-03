using System;
using ClearHl7.Fhir.V290.Segments;
using ClearHl7.Fhir.V290.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class CssSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new CssSegment
            {
                StudyScheduledTimePoint = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                StudyScheduledPatientTimePoint = new DateTime(2020, 2, 2, 0, 0, 2),
                StudyQualityControlCodes = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "3"
                    }
                }
            };

            string expected = "CSS|1|20200202000002|3";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
