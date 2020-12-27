using System;
using ClearHl7.Fhir.V290.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.TypesTests
{
    public class FinancialClassTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new FinancialClass
            {
                FinancialClassCode = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                EffectiveDate = new DateTime(2020, 1, 1, 0, 0, 22)
            };

            string expected = "1^20200101000022";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
