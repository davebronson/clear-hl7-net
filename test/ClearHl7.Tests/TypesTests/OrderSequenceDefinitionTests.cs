using System;
using ClearHl7.V260.Types;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class OrderSequenceDefinitionTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new OrderSequenceDefinition
            {
                OccurrenceCode = new CodedWithNoExceptions
                {
                    Identifier = "1"
                },
                OccurrenceDate = new DateTime(2020, 2, 2)
            };

            string expected = "1^20200202";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
