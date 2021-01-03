using ClearHl7.Fhir.V290.Segments;
using ClearHl7.Fhir.V290.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class Gp1SegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Gp1Segment
            {
                TypeOfBillCode = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                RevenueCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "2"
                    }
                },
                OverallClaimDispositionCode = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                OceEditsPerVisitCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "4"
                    }
                },
                OutlierCost = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 5
                    }
                }
            };

            string expected = "GP1|1|2|3|4|5";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
