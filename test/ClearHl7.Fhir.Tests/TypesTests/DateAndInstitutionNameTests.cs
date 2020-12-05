using System;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.TypesTests
{
    public class DateAndInstitutionNameTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new DateAndInstitutionName
            {
                Date = new DateTime(2020, 1, 1),
                InstitutionName = new CodedWithExceptions
                {
                    Identifier = "2"
                }
            };

            string expected = "20200101^2";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
