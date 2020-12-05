using System;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.TypesTests
{
    public class DriversLicenseNumberTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new DriversLicenseNumber
            {
                LicenseNumber = "1",
                IssuingStateProvinceCountry = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                ExpirationDate = new DateTime(2020, 3, 3)
            };

            string expected = "1^2^20200303";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
