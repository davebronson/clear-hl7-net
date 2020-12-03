using System;
using ClearHl7.Fhir.V282.Segments;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class AdjSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
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
                AdjustmentSequenceNumber = new EntityIdentifier
                {
                    EntityId = "3"
                },
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
