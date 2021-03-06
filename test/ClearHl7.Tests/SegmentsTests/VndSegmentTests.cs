﻿using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class VndSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new VndSegment
            {
                SetIdVnd = 1,
                VendorIdentifier = new EntityIdentifier
                {
                    EntityId = "2"
                },
                VendorName = "3",
                VendorCatalogNumber = new EntityIdentifier
                {
                    EntityId = "4"
                },
                PrimaryVendorIndicator = new CodedWithNoExceptions
                {
                    Identifier = "5"
                },
                Corporation = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "6"
                    }
                },
                PrimaryContact = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "7"
                },
                ContractAdjustment = new MoneyOrPercentage
                {
                    MoneyOrPercentageIndicator = "8"
                },
                AssociatedContractId = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "9"
                    }
                },
                ClassOfTrade = new string[]
                {
                    "10"
                },
                PricingTierLevel = new CodedWithNoExceptions
                {
                    Identifier = "11"
                }
            };

            string expected = "VND|1|2|3|4|5|6|7|8|9|10|11";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
