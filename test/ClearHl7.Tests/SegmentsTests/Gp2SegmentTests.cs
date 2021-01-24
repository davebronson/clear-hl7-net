using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Gp2SegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Gp2Segment
            {
                RevenueCode = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                NumberOfServiceUnits = 2,
                Charge = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 3
                    }
                },
                ReimbursementActionCode = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                DenialOrRejectionCode = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                OceEditCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "6"
                    }
                },
                AmbulatoryPaymentClassificationCode = new CodedWithExceptions
                {
                    Identifier = "7"
                },
                ModifierEditCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "8"
                    }
                },
                PaymentAdjustmentCode = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                PackagingStatusCode = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                ExpectedCmsPaymentAmount = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 11
                    }
                },
                ReimbursementTypeCode = new CodedWithExceptions
                {
                    Identifier = "12"
                },
                CoPayAmount = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 13
                    }
                },
                PayRatePerServiceUnit = 14
            };

            string expected = "GP2|1|2|3|4|5|6|7|8|9|10|11|12|13|14";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
