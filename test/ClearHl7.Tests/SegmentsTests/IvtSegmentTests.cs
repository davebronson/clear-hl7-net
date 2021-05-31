using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class IvtSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new IvtSegment
            {
                SetIdIvt = 1,
                InventoryLocationIdentifier = new EntityIdentifier
                {
                    EntityId = "2"
                },
                InventoryLocationName = "3",
                SourceLocationIdentifier = new EntityIdentifier
                {
                    EntityId = "4"
                },
                SourceLocationName = "5",
                ItemStatus = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                BinLocationIdentifier = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "7"
                    }
                },
                OrderPackaging = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                IssuePackaging = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                DefaultInventoryAssetAccount = new EntityIdentifier
                {
                    EntityId = "10"
                },
                PatientChargeableIndicator = new CodedWithNoExceptions
                {
                    Identifier = "11"
                },
                TransactionCode = new CodedWithExceptions
                {
                    Identifier = "12"
                },
                TransactionAmountUnit = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 13
                    }
                },
                ItemImportanceCode = new CodedWithExceptions
                {
                    Identifier = "14"
                },
                StockedItemIndicator = new CodedWithNoExceptions
                {
                    Identifier = "15"
                },
                ConsignmentItemIndicator = new CodedWithNoExceptions
                {
                    Identifier = "16"
                },
                ReusableItemIndicator = new CodedWithNoExceptions
                {
                    Identifier = "17"
                },
                ReusableCost = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 18
                    }
                },
                SubstituteItemIdentifier = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "19"
                    }
                },
                LatexFreeSubstituteItemIdentifier = new EntityIdentifier
                {
                    EntityId = "20"
                },
                RecommendedReorderTheory = new CodedWithExceptions
                {
                    Identifier = "21"
                },
                RecommendedSafetyStockDays = 22,
                RecommendedMaximumDaysInventory = 23,
                RecommendedOrderPoint = 24,
                RecommendedOrderAmount = 25,
                OperatingRoomParLevelIndicator = new CodedWithNoExceptions
                {
                    Identifier = "26"
                }
            };

            string expected = "IVT|1|2|3|4|5|6|7|8|9|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
