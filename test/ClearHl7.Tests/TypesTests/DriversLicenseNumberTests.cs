using System;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class DriversLicenseNumberTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new DriversLicenseNumber
            {
                LicenseNumber = "1",
                IssuingStateProvinceCountry = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "2"
                },
                ExpirationDate = new DateTime(2020, 3, 3)
            };

            IType actual = new DriversLicenseNumber();
            actual.FromDelimitedString("1^2^20200303");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
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
