using System;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class OccurrenceSpanCodeAndDateTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
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
