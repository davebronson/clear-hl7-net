using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class PkgSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new PkgSegment
            {
                SetIdPkg = 1,
                PackagingUnits = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                DefaultOrderUnitOfMeasureIndicator = new CodedWithNoExceptions
                {
                    Identifier = "3"
                },
                PackageQuantity = 4,
                Price = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 5
                    }
                },
                FutureItemPrice = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 6
                    }
                },
                FutureItemPriceEffectiveDate = new DateTime(2020, 7, 7, 0, 0, 7),
                GlobalTradeItemNumber = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                ContractPrice = new Money
                {
                    Quantity = 9
                },
                QuantityOfEach = 10,
                VendorCatalogNumber = new EntityIdentifier
                {
                    EntityId = "11"
                }
            };

            ISegment actual = new PkgSegment();
            actual.FromDelimitedString("PKG|1|2|3|4|5|6|20200707000007|8|9|10|11");

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
                ISegment hl7Segment = new PkgSegment();
                hl7Segment.FromDelimitedString("PKA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new PkgSegment
            {
                SetIdPkg = 1,
                PackagingUnits = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                DefaultOrderUnitOfMeasureIndicator = new CodedWithNoExceptions
                {
                    Identifier = "3"
                },
                PackageQuantity = 4,
                Price = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 5
                    }
                },
                FutureItemPrice = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 6
                    }
                },
                FutureItemPriceEffectiveDate = new DateTime(2020, 7, 7, 0, 0, 7),
                GlobalTradeItemNumber = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                ContractPrice = new Money
                {
                    Quantity = 9
                },
                QuantityOfEach = 10,
                VendorCatalogNumber = new EntityIdentifier
                {
                    EntityId = "11"
                }
            };

            string expected = "PKG|1|2|3|4|5|6|20200707000007|8|9|10|11";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
