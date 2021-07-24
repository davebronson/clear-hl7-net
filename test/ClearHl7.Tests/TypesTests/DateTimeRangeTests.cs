using System;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class DateTimeRangeTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new DateTimeRange
            {
                RangeStartDateTime = new DateTime(2020, 1, 1, 0, 0, 11),
                RangeEndDateTime = new DateTime(2020, 2, 2, 0, 0, 22)
            };

            IType actual = new DateTimeRange();
            actual.FromDelimitedString("20200101000011^20200202000022");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new DateTimeRange
            {
                RangeStartDateTime = new DateTime(2020, 1, 1, 0, 0, 11),
                RangeEndDateTime = new DateTime(2020, 2, 2, 0, 0, 22)
            };

            string expected = "20200101000011^20200202000022";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
