using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class PsgSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new PsgSegment
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

            ISegment actual = new PsgSegment();
            actual.FromDelimitedString("PSG|1|2|3|4|5|6");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
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
