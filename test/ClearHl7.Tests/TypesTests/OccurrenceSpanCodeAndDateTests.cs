using System;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class OccurrenceSpanCodeAndDateTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new OccurrenceSpanCodeAndDate
            {
                OccurrenceSpanCode = new CodedWithNoExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "1"
                },
                OccurrenceSpanStartDate = new DateTime(2020, 2, 2, 2, 22, 0),
                OccurrenceSpanStopDate = new DateTime(2020, 3, 3, 3, 33, 28)
            };

            IType actual = new OccurrenceSpanCodeAndDate();
            actual.FromDelimitedString("1^20200202022200^20200303033328");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new OccurrenceSpanCodeAndDate
            {
                OccurrenceSpanCode = new CodedWithNoExceptions
                {
                    Identifier = "1"
                },
                OccurrenceSpanStartDate = new DateTime(2020, 2, 2, 2, 22, 0),
                OccurrenceSpanStopDate = new DateTime(2020, 3, 3, 3, 33, 28)
            };

            string expected = "1^20200202022200^20200303033328";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
