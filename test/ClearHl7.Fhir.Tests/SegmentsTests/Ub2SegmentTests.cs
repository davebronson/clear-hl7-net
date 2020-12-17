﻿using ClearHl7.Fhir.V282.Segments;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class Ub2SegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Ub2Segment
            {
                SetIdUb2 = 1,
                CoInsuranceDays9 = "2",
                ConditionCode24To30 = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "3"
                    }
                },
                CoveredDays7 = "4",
                NonCoveredDays8 = "5",
                ValueAmountCode3941 = new ValueCodeAndAmount[]
                {
                    new ValueCodeAndAmount
                    {
                        ValueCode = new CodedWithExceptions
                        {
                            Identifier = "6"
                        }
                    }
                },
                OccurrenceCodeDate3235 = new OccurrenceCodeAndDate[]
                {
                    new OccurrenceCodeAndDate
                    {
                        OccurrenceCode = new CodedWithNoExceptions
                        {
                            Identifier = "7"
                        }
                    }
                },
                OccurrenceSpanCodeDates36 = new OccurrenceSpanCodeAndDate[]
                {
                    new OccurrenceSpanCodeAndDate
                    {
                        OccurrenceSpanCode = new CodedWithNoExceptions
                        {
                            Identifier = "8"
                        }
                    }
                },
                UniformBillingLocator2State = new string[]
                {
                    "9"
                },
                UniformBillingLocator11State = new string[]
                {
                    "10"
                },
                UniformBillingLocator31National = "11",
                DocumentControlNumber = new string[]
                {
                    "12"
                },
                UniformBillingLocator49National = new string[]
                {
                    "13"
                },
                UniformBillingLocator56State = new string[]
                {
                    "14"
                },
                UniformBillingLocator57Sational = "15",
                UniformBillingLocator78State = new string[]
                {
                    "16"
                },
                SpecialVisitCount = 17
            };

            string expected = "UB2|1|2|3|4|5|6|7|8|9|10|11|12|13|14|15|16|17";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
