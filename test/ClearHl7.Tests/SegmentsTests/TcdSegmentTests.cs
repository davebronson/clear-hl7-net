using ClearHl7.Fhir.V290.Segments;
using ClearHl7.Fhir.V290.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class TcdSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new TcdSegment
            {
                UniversalServiceIdentifier = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                AutoDilutionFactor = new StructuredNumeric
                {
                    Comparator = "2"
                },
                RerunDilutionFactor = new StructuredNumeric
                {
                    Comparator = "3"
                },
                PreDilutionFactor = new StructuredNumeric
                {
                    Comparator = "4"
                },
                EndogenousContentOfPreDilutionDiluent = new StructuredNumeric
                {
                    Comparator = "5"
                },
                AutomaticRepeatAllowed = "6",
                ReflexAllowed = "7",
                AnalyteRepeatStatus = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                SpecimenConsumptionQuantity = new CompositeQuantityWithUnits
                {
                    Quantity = 9
                },
                PoolSize = 10,
                AutoDilutionType = new CodedWithExceptions
                {
                    Identifier = "11"
                }
            };

            string expected = "TCD|1|2|3|4|5|6|7|8|9|10|11";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
