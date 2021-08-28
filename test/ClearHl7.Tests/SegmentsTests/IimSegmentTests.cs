using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class IimSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new IimSegment
            {
                PrimaryKeyValueIim = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                ServiceItemCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                InventoryLotNumber = "3",
                InventoryExpirationDate = new DateTime(2020, 4, 4, 0, 0, 4),
                InventoryManufacturerName = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                InventoryLocation = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                InventoryReceivedDate = new DateTime(2020, 7, 7, 0, 0, 7),
                InventoryReceivedQuantity = 8,
                InventoryReceivedQuantityUnit = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                InventoryReceivedItemCost = new Money
                {
                    Quantity = 10
                },
                InventoryOnHandDate = new DateTime(2020, 11, 11, 0, 0, 11),
                InventoryOnHandQuantity = 12,
                InventoryOnHandQuantityUnit = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                ProcedureCode = new CodedWithNoExceptions
                {
                    Identifier = "14"
                },
                ProcedureCodeModifier = new CodedWithNoExceptions[]
                {
                    new CodedWithNoExceptions
                    {
                        Identifier = "15"
                    }
                }
            };

            ISegment actual = new IimSegment();
            actual.FromDelimitedString("IIM|1|2|3|20200404000004|5|6|20200707000007|8|9|10|20201111000011|12|13|14|15");

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
                ISegment hl7Segment = new IimSegment();
                hl7Segment.FromDelimitedString("IIA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new IimSegment
            {
                PrimaryKeyValueIim = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                ServiceItemCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                InventoryLotNumber = "3",
                InventoryExpirationDate = new DateTime(2020, 4, 4, 0, 0, 4),
                InventoryManufacturerName = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                InventoryLocation = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                InventoryReceivedDate = new DateTime(2020, 7, 7, 0, 0, 7),
                InventoryReceivedQuantity = 8,
                InventoryReceivedQuantityUnit = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                InventoryReceivedItemCost = new Money
                {
                    Quantity = 10
                },
                InventoryOnHandDate = new DateTime(2020, 11, 11, 0, 0, 11),
                InventoryOnHandQuantity = 12,
                InventoryOnHandQuantityUnit = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                ProcedureCode = new CodedWithNoExceptions
                {
                    Identifier = "14"
                },
                ProcedureCodeModifier = new CodedWithNoExceptions[]
                {
                    new CodedWithNoExceptions
                    {
                        Identifier = "15"
                    }
                }
            };

            string expected = "IIM|1|2|3|20200404000004|5|6|20200707000007|8|9|10|20201111000011|12|13|14|15";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
