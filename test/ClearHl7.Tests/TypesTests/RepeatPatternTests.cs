using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class RepeatPatternTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new RepeatPattern
            {
                RepeatPatternCode = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "1"
                },
                CalendarAlignment = "2",
                PhaseRangeBeginValue = 3,
                PhaseRangeEndValue = 4,
                PeriodQuantity = 5,
                PeriodUnits = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "6"
                },
                InstitutionSpecifiedTime = "7",
                Event = "8",
                EventOffsetQuantity = 9,
                EventOffsetUnits = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "10"
                },
                GeneralTimingSpecification = "11"
            };

            IType actual = new RepeatPattern();
            actual.FromDelimitedString("1^2^3^4^5^6^7^8^9^10^11");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
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
