using ClearHl7.Fhir.V251.Segments;
using ClearHl7.Fhir.V251.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class SprSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new SprSegment
            {
                QueryTag = "1",
                QueryResponseFormatCode = "2",
                StoredProcedureName = new CodedElement
                {
                    Identifier = "3"
                },
                InputParameterList = new QueryInputParameterList[]
                {
                    new QueryInputParameterList
                    {
                        SegmentFieldName = "4"
                    }
                }
            };

            string expected = "SPR|1|2|3|4";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
