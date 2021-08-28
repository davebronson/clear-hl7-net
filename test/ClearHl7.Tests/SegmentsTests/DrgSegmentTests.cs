using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class DrgSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new DrgSegment
            {
                DiagnosticRelatedGroup = new CodedWithNoExceptions
                {
                    Identifier = "1"
                },
                DrgAssignedDateTime = new DateTime(2020, 2, 2, 0, 0, 2),
                DrgApprovalIndicator = "3",
                DrgGrouperReviewCode = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                OutlierType = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                OutlierDays = 6,
                OutlierCost = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 7
                    }
                },
                DrgPayor = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                OutlierReimbursement = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 9
                    }
                },
                ConfidentialIndicator = "10",
                DrgTransferType = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                NameOfCoder = new ExtendedPersonName
                {
                    FamilyName = new FamilyName
                    {
                        Surname = "12"
                    }
                },
                GrouperStatus = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                PcclValueCode = new CodedWithExceptions
                {
                    Identifier = "14"
                },
                EffectiveWeight = 15,
                MonetaryAmount = new Money
                {
                    Quantity = 16
                },
                StatusPatient = new CodedWithExceptions
                {
                    Identifier = "17"
                },
                GrouperSoftwareName = "18",
                GrouperSoftwareVersion = "19",
                StatusFinancialCalculation = new CodedWithExceptions
                {
                    Identifier = "20"
                },
                RelativeDiscountSurcharge = new Money
                {
                    Quantity = 21
                },
                BasicCharge = new Money
                {
                    Quantity = 22
                },
                TotalCharge = new Money
                {
                    Quantity = 23
                },
                DiscountSurcharge = new Money
                {
                    Quantity = 24
                },
                CalculatedDays = 25,
                StatusGender = new CodedWithExceptions
                {
                    Identifier = "26"
                },
                StatusAge = new CodedWithExceptions
                {
                    Identifier = "27"
                },
                StatusLengthOfStay = new CodedWithExceptions
                {
                    Identifier = "28"
                },
                StatusSameDayFlag = new CodedWithExceptions
                {
                    Identifier = "29"
                },
                StatusSeparationMode = new CodedWithExceptions
                {
                    Identifier = "30"
                },
                StatusWeightAtBirth = new CodedWithExceptions
                {
                    Identifier = "31"
                },
                StatusRespirationMinutes = new CodedWithExceptions
                {
                    Identifier = "32"
                },
                StatusAdmission = new CodedWithExceptions
                {
                    Identifier = "33"
                }
            };

            ISegment actual = new DrgSegment();
            actual.FromDelimitedString("DRG|1|20200202000002|3|4|5|6|7|8|9|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33");

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
                ISegment hl7Segment = new DrgSegment();
                hl7Segment.FromDelimitedString("DRA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new DrgSegment
            {
                DiagnosticRelatedGroup = new CodedWithNoExceptions
                {
                    Identifier = "1"
                },
                DrgAssignedDateTime = new DateTime(2020, 2, 2, 0, 0, 2),
                DrgApprovalIndicator = "3",
                DrgGrouperReviewCode = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                OutlierType = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                OutlierDays = 6,
                OutlierCost = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 7
                    }
                },
                DrgPayor = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                OutlierReimbursement = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 9
                    }
                },
                ConfidentialIndicator = "10",
                DrgTransferType = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                NameOfCoder = new ExtendedPersonName
                {
                    FamilyName = new FamilyName
                    {
                        Surname = "12"
                    }
                },
                GrouperStatus = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                PcclValueCode = new CodedWithExceptions
                {
                    Identifier = "14"
                },
                EffectiveWeight = 15,
                MonetaryAmount = new Money
                {
                    Quantity = 16
                },
                StatusPatient = new CodedWithExceptions
                {
                    Identifier = "17"
                },
                GrouperSoftwareName = "18",
                GrouperSoftwareVersion = "19",
                StatusFinancialCalculation = new CodedWithExceptions
                {
                    Identifier = "20"
                },
                RelativeDiscountSurcharge = new Money
                {
                    Quantity = 21
                },
                BasicCharge = new Money
                {
                    Quantity = 22
                },
                TotalCharge = new Money
                {
                    Quantity = 23
                },
                DiscountSurcharge = new Money
                {
                    Quantity = 24
                },
                CalculatedDays = 25,
                StatusGender = new CodedWithExceptions
                {
                    Identifier = "26"
                },
                StatusAge = new CodedWithExceptions
                {
                    Identifier = "27"
                },
                StatusLengthOfStay = new CodedWithExceptions
                {
                    Identifier = "28"
                },
                StatusSameDayFlag = new CodedWithExceptions
                {
                    Identifier = "29"
                },
                StatusSeparationMode = new CodedWithExceptions
                {
                    Identifier = "30"
                },
                StatusWeightAtBirth = new CodedWithExceptions
                {
                    Identifier = "31"
                },
                StatusRespirationMinutes = new CodedWithExceptions
                {
                    Identifier = "32"
                },
                StatusAdmission = new CodedWithExceptions
                {
                    Identifier = "33"
                }
            };

            string expected = "DRG|1|20200202000002|3|4|5|6|7|8|9|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
