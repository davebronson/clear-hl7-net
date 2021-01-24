﻿using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class PrcSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new PrcSegment
            {
                PrimaryKeyValuePrc = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                FacilityIdPrc = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "2"
                    }
                },
                Department = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "3"
                    }
                },
                ValidPatientClasses = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "4"
                    }
                },
                Price = new CompositePrice[]
                {
                    new CompositePrice
                    {
                        Price = new Money
                        {
                            Quantity = 5
                        }
                    }
                },
                Formula = new string[]
                {
                    "6"
                },
                MinimumQuantity = 7,
                MaximumQuantity = 8,
                MinimumPrice = new Money
                {
                    Quantity = 9
                },
                MaximumPrice = new Money
                {
                    Quantity = 10
                },
                EffectiveStartDate = new DateTime(2020, 11, 11, 0, 0, 11),
                EffectiveEndDate = new DateTime(2020, 12, 12, 0, 0, 12),
                PriceOverrideFlag = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                BillingCategory = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "14"
                    }
                },
                ChargeableFlag = "15",
                ActiveInactiveFlag = "16",
                Cost = new Money
                {
                    Quantity = 17
                },
                ChargeOnIndicator = new CodedWithExceptions
                {
                    Identifier = "18"
                }
            };

            string expected = "PRC|1|2|3|4|5|6|7|8|9|10|20201111000011|20201212000012|13|14|15|16|17|18";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
