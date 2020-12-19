using ClearHl7.Fhir.V282.Segments;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class PsgSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new PsgSegment
            {
                ProviderProductServiceGroupNumber = new EntityIdentifier
                {
                    EntityId = "1"
                },
                PayerProductServiceGroupNumber = new EntityIdentifier
                {
                    EntityId = "2"
                },
                ProductServiceGroupSequenceNumber = 3,
                AdjudicateAsGroup = "4",
                ProductServiceGroupBilledAmount = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 5
                    }
                },
                ProductServiceGroupDescription = "6"
            };

            string expected = "PSG|1|2|3|4|5|6";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
