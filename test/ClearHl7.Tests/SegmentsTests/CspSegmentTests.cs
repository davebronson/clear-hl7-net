using System;
using ClearHl7.Fhir.V290.Segments;
using ClearHl7.Fhir.V290.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class CspSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new CspSegment
            {
                StudyPhaseIdentifier = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                DateTimeStudyPhaseBegan = new DateTime(2020, 2, 2, 0, 0, 2),
                DateTimeStudyPhaseEnded = new DateTime(2020, 3, 3, 0, 0, 3),
                StudyPhaseEvaluability = new CodedWithExceptions
                {
                    Identifier = "4"
                }
            };

            string expected = "CSP|1|20200202000002|20200303000003|4";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
