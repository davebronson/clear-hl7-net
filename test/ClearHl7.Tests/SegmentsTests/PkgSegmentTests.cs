﻿using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class PkgSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
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
