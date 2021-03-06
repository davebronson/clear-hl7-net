﻿using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class RepeatPatternTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new RepeatPattern
            {
                RepeatPatternCode = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                CalendarAlignment = "2",
                PhaseRangeBeginValue = 3,
                PhaseRangeEndValue = 4,
                PeriodQuantity = 5,
                PeriodUnits = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                InstitutionSpecifiedTime = "7",
                Event = "8",
                EventOffsetQuantity = 9,
                EventOffsetUnits = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                GeneralTimingSpecification = "11"
            };

            string expected = "1^2^3^4^5^6^7^8^9^10^11";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
