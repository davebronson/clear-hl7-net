using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class PssSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new PssSegment
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
            ISegment actual = new PssSegment().FromDelimitedString("PSS|1|2|3|4|5");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
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
