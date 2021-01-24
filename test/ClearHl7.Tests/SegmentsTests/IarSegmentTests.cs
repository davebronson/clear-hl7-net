using ClearHl7.Fhir.V290.Segments;
using ClearHl7.Fhir.V290.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class IarSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new IarSegment
            {
                AllergyReactionCode = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                AllergySeverityCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                SensitivityToCausativeAgentCode = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                Management = "4"
            };

            string expected = "IAR|1|2|3|4";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
