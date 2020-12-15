using ClearHl7.Fhir.V282.Segments;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class PssSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new PssSegment
            {
                ProviderProductServiceSectionNumber = new EntityIdentifier
                {
                    EntityId = "1"
                },
                PayerProductServiceSectionNumber = new EntityIdentifier
                {
                    EntityId = "2"
                },
                ProductServiceSectionSequenceNumber = 3,
                BilledAmount = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 4
                    }
                },
                SectionDescriptionOrHeading = "5"
            };

            string expected = "PSS|1|2|3|4|5";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
