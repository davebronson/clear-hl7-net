using ClearHl7.Fhir.V282.Segments;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class CdoSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new CdoSegment
            {
                SetIdCdo = 1,
                ActionCode = "2",
                CumulativeDosageLimit = new CompositeQuantityWithUnits
                {
                    Quantity = 3
                },
                CumulativeDosageLimitTimeInterval = new CompositeQuantityWithUnits
                {
                    Quantity = 4
                }
            };

            string expected = "CDO|1|2|3|4";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
