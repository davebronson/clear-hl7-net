using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Ub1SegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new Ub1Segment
            {
                SetIdUb1 = 1,
                BloodDeductible = "2",
                BloodFurnishedPints = 3,
                BloodReplacedPints = 4,
                BloodNotReplacedPints = 5,
                CoInsuranceDays = 6,
                ConditionCode = new string[]
                {
                    "7"
                },
                CoveredDays = 8,
                NonCoveredDays = 9,
                ValueAmountCode = new ValueCodeAndAmount[]
                {
                    new ValueCodeAndAmount
                    {
                        ValueCode = new CodedWithExceptions
                        {
                            Identifier = "10"
                        }
                    }
                },
                NumberOfGraceDays = 11,
                SpecialProgramIndicator = new CodedWithExceptions
                {
                    Identifier = "12"
                },
                PsroUrApprovalIndicator = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                PsroUrApprovedStayFm = new DateTime(2020, 1, 14),
                PsroUrApprovedStayTo = new DateTime(2020, 1, 15),
                Occurrence = new OccurrenceCodeAndDate[]
                {
                    new OccurrenceCodeAndDate
                    {
                        OccurrenceCode = new CodedWithNoExceptions
                        {
                            Identifier = "16"
                        }
                    }
                },
                OccurrenceSpan = new CodedWithExceptions
                {
                    Identifier = "17"
                },
                OccurSpanStartDate = new DateTime(2020, 1, 18),
                OccurSpanEndDate = new DateTime(2020, 1, 19),
                Ub82Locator2 = "20",
                Ub82Locator9 = "21",
                Ub82Locator27 = "22",
                Ub82Locator45 = "23"
            };

            ISegment actual = new Ub1Segment();
            actual.FromDelimitedString("UB1|1|2|3|4|5|6|7|8|9|10|11|12|13|20200114|20200115|16|17|20200118|20200119|20|21|22|23");

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
                ISegment hl7Segment = new Ub1Segment();
                hl7Segment.FromDelimitedString("UBA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Ub1Segment
            {
                SetIdUb1 = 1,
                BloodDeductible = "2",
                BloodFurnishedPints = 3,
                BloodReplacedPints = 4,
                BloodNotReplacedPints = 5,
                CoInsuranceDays = 6,
                ConditionCode = new string[]
                {
                    "7"
                },
                CoveredDays = 8,
                NonCoveredDays = 9,
                ValueAmountCode = new ValueCodeAndAmount[]
                {
                    new ValueCodeAndAmount
                    {
                        ValueCode = new CodedWithExceptions
                        {
                            Identifier = "10"
                        }
                    }
                },
                NumberOfGraceDays = 11,
                SpecialProgramIndicator = new CodedWithExceptions
                {
                    Identifier = "12"
                },
                PsroUrApprovalIndicator = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                PsroUrApprovedStayFm = new DateTime(2020, 1, 14),
                PsroUrApprovedStayTo = new DateTime(2020, 1, 15),
                Occurrence = new OccurrenceCodeAndDate[]
                {
                    new OccurrenceCodeAndDate
                    {
                        OccurrenceCode = new CodedWithNoExceptions
                        {
                            Identifier = "16"
                        }
                    }
                },
                OccurrenceSpan = new CodedWithExceptions
                {
                    Identifier = "17"
                },
                OccurSpanStartDate = new DateTime(2020, 1, 18),
                OccurSpanEndDate = new DateTime(2020, 1, 19),
                Ub82Locator2 = "20",
                Ub82Locator9 = "21",
                Ub82Locator27 = "22",
                Ub82Locator45 = "23"
            };

            string expected = "UB1|1|2|3|4|5|6|7|8|9|10|11|12|13|20200114|20200115|16|17|20200118|20200119|20|21|22|23";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
