using System;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class PractitionerLicenseOrOtherIdNumberTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new PractitionerLicenseOrOtherIdNumber
            {
                IdNumber = "1",
                TypeOfIdNumber = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "2"
                },
                StateOtherQualifyingInformation = "3",
                ExpirationDate = new DateTime(2020, 4, 4)
            };

            IType actual = new PractitionerLicenseOrOtherIdNumber();
            actual.FromDelimitedString("1^2^3^20200404");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new PractitionerLicenseOrOtherIdNumber
            {
                IdNumber = "1",
                TypeOfIdNumber = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                StateOtherQualifyingInformation = "3",
                ExpirationDate = new DateTime(2020, 4, 4)
            };

            string expected = "1^2^3^20200404";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
