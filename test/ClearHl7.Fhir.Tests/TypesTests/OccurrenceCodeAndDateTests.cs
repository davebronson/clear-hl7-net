using System;
using ClearHl7.Fhir.V290.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.TypesTests
{
    public class OccurrenceCodeAndDateTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new OccurrenceCodeAndDate
            {
                OccurrenceCode = new CodedWithNoExceptions
                {
                    Identifier = "1"
                },
                OccurrenceDate = new DateTime(2020, 2, 22)
            };

            string expected = "1^20200222";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
