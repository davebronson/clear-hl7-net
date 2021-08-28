using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class InvSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new InvSegment
            {
                SubstanceIdentifier = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                SubstanceStatus = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "2"
                    }
                },
                SubstanceType = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                InventoryContainerIdentifier = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                ContainerCarrierIdentifier = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                PositionOnCarrier = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                InitialQuantity = 7,
                CurrentQuantity = 8,
                AvailableQuantity = 9,
                ConsumptionQuantity = 10,
                QuantityUnits = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                ExpirationDateTime = new DateTime(2020, 12, 12, 0, 0, 12),
                FirstUsedDateTime = new DateTime(2020, 1, 13, 0, 0, 13),
                OnBoardStabilityDuration = "14",
                TestFluidIdentifiers = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "15"
                    }
                },
                ManufacturerLotNumber = "16",
                ManufacturerIdentifier = new CodedWithExceptions
                {
                    Identifier = "17"
                },
                SupplierIdentifier = new CodedWithExceptions
                {
                    Identifier = "18"
                },
                OnBoardStabilityTime = new CompositeQuantityWithUnits
                {
                    Quantity = 19
                },
                TargetValue = new CompositeQuantityWithUnits
                {
                    Quantity = 20
                },
                EquipmentStateIndicatorTypeCode = new CodedWithExceptions
                {
                    Identifier = "21"
                },
                EquipmentStateIndicatorValue = new CompositeQuantityWithUnits
                {
                    Quantity = 22
                }
            };

            ISegment actual = new InvSegment();
            actual.FromDelimitedString("INV|1|2|3|4|5|6|7|8|9|10|11|20201212000012|20200113000013|14|15|16|17|18|19|20|21|22");

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
                ISegment hl7Segment = new InvSegment();
                hl7Segment.FromDelimitedString("INA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new InvSegment
            {
                SubstanceIdentifier = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                SubstanceStatus = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "2"
                    }
                },
                SubstanceType = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                InventoryContainerIdentifier = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                ContainerCarrierIdentifier = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                PositionOnCarrier = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                InitialQuantity = 7,
                CurrentQuantity = 8,
                AvailableQuantity = 9,
                ConsumptionQuantity = 10,
                QuantityUnits = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                ExpirationDateTime = new DateTime(2020, 12, 12, 0, 0, 12),
                FirstUsedDateTime = new DateTime(2020, 1, 13, 0, 0, 13),
                OnBoardStabilityDuration = "14",
                TestFluidIdentifiers = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "15"
                    }
                },
                ManufacturerLotNumber = "16",
                ManufacturerIdentifier = new CodedWithExceptions
                {
                    Identifier = "17"
                },
                SupplierIdentifier = new CodedWithExceptions
                {
                    Identifier = "18"
                },
                OnBoardStabilityTime = new CompositeQuantityWithUnits
                {
                    Quantity = 19
                },
                TargetValue = new CompositeQuantityWithUnits
                {
                    Quantity = 20
                },
                EquipmentStateIndicatorTypeCode = new CodedWithExceptions
                {
                    Identifier = "21"
                },
                EquipmentStateIndicatorValue = new CompositeQuantityWithUnits
                {
                    Quantity = 22
                }
            };

            string expected = "INV|1|2|3|4|5|6|7|8|9|10|11|20201212000012|20200113000013|14|15|16|17|18|19|20|21|22";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
