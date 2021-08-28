using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class AdjSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new AdjSegment
            {
                ProviderAdjustmentNumber = new EntityIdentifier
                {
                    EntityId = "1"
                },
                PayerAdjustmentNumber = new EntityIdentifier
                {
                    EntityId = "2"
                },
                AdjustmentSequenceNumber = 3,
                AdjustmentCategory = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                AdjustmentAmount = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 5
                    }
                },
                AdjustmentQuantity = new CompositeQuantityWithUnits
                {
                    Quantity = 6
                },
                AdjustmentReasonPa = new CodedWithExceptions
                {
                    Identifier = "7"
                },
                AdjustmentDescription = "8",
                OriginalValue = 9,
                SubstituteValue = 10,
                AdjustmentAction = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                ProviderAdjustmentNumberCrossReference = new EntityIdentifier
                {
                    EntityId = "12"
                },
                ProviderProductServiceLineItemNumberCrossReference = new EntityIdentifier
                {
                    EntityId = "13"
                },
                AdjustmentDate = new DateTime(2020, 1, 14, 0, 0, 14),
                ResponsibleOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "15"
                }
            };

            ISegment actual = new AdjSegment();
            actual.FromDelimitedString("ADJ|1|2|3|4|5|6|7|8|9|10|11|12|13|20200114000014|15");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that calling FromDelimitedString() with a string input containing an incorrect segment ID results in an ArgumentException being thrown.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithIncorrectSegmentId_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ISegment hl7Segment = new AdjSegment();
                hl7Segment.FromDelimitedString("ADA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new AdjSegment
            {
                ProviderAdjustmentNumber = new EntityIdentifier
                {
                    EntityId = "1"
                },
                PayerAdjustmentNumber = new EntityIdentifier
                {
                    EntityId = "2"
                },
                AdjustmentSequenceNumber = 3,
                AdjustmentCategory = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                AdjustmentAmount = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 5
                    }
                },
                AdjustmentQuantity = new CompositeQuantityWithUnits
                {
                    Quantity = 6
                },
                AdjustmentReasonPa = new CodedWithExceptions
                {
                    Identifier = "7"
                },
                AdjustmentDescription = "8",
                OriginalValue = 9,
                SubstituteValue = 10,
                AdjustmentAction = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                ProviderAdjustmentNumberCrossReference = new EntityIdentifier
                {
                    EntityId = "12"
                },
                ProviderProductServiceLineItemNumberCrossReference = new EntityIdentifier
                {
                    EntityId = "13"
                },
                AdjustmentDate = new DateTime(2020, 1, 14, 0, 0, 14),
                ResponsibleOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "15"
                }
            };

            string expected = "ADJ|1|2|3|4|5|6|7|8|9|10|11|12|13|20200114000014|15";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
