using System;
using ClearHl7.Fhir.V290.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.TypesTests
{
    public class DischargeToLocationAndDateTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new DischargeToLocationAndDate
            {
                DischargeToLocation = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                EffectiveDate = new DateTime(2020, 2, 2, 0, 0, 2)
            };

            string expected = "1^20200202000002";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
