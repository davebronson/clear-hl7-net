using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class IltSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new IltSegment
            {
                SetIdIlt = 1,
                InventoryLotNumber = "2",
                InventoryExpirationDate = new DateTime(2020, 3, 3, 0, 0, 3),
                InventoryReceivedDate = new DateTime(2020, 4, 4, 0, 0, 4),
                InventoryReceivedQuantity = 5,
                InventoryReceivedQuantityUnit = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                InventoryReceivedItemCost = new Money
                {
                    Quantity = 7
                },
                InventoryOnHandDate = new DateTime(2020, 8, 8, 0, 0, 8),
                InventoryOnHandQuantity = 9,
                InventoryOnHandQuantityUnit = new CodedWithExceptions
                {
                    Identifier = "10"
                }
            };

            ISegment actual = new IltSegment();
            actual.FromDelimitedString("ILT|1|2|20200303000003|20200404000004|5|6|7|20200808000008|9|10");

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
                ISegment hl7Segment = new IltSegment();
                hl7Segment.FromDelimitedString("ILA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new IltSegment
            {
                SetIdIlt = 1,
                InventoryLotNumber = "2",
                InventoryExpirationDate = new DateTime(2020, 3, 3, 0, 0, 3),
                InventoryReceivedDate = new DateTime(2020, 4, 4, 0, 0, 4),
                InventoryReceivedQuantity = 5,
                InventoryReceivedQuantityUnit = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                InventoryReceivedItemCost = new Money
                {
                    Quantity = 7
                },
                InventoryOnHandDate = new DateTime(2020, 8, 8, 0, 0, 8),
                InventoryOnHandQuantity = 9,
                InventoryOnHandQuantityUnit = new CodedWithExceptions
                {
                    Identifier = "10"
                }
            };

            string expected = "ILT|1|2|20200303000003|20200404000004|5|6|7|20200808000008|9|10";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
