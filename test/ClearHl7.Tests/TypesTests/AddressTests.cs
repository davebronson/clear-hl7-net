using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class AddressTests
    {
        [Fact]
        public void FromDelimitedString_WithAllProperties_CorrectlyInitializesFields()
        {
            Address expected = new()
            {
                StreetAddress = "1",
                OtherDesignation = "2",
                City = "3",
                StateOrProvince = "4",
                ZipOrPostalCode = "5",
                Country = "6",
                AddressType = "7",
                OtherGeographicDesignation = "8"
            };

            Address actual = new Address().FromDelimitedString("1^2^3^4^5^6^7^8");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            Address hl7Type = new()
            {
                StreetAddress = "1",
                OtherDesignation = "2",
                City = "3",
                StateOrProvince = "4",
                ZipOrPostalCode = "5",
                Country = "6",
                AddressType = "7",
                OtherGeographicDesignation = "8"
            };

            string expected = "1^2^3^4^5^6^7^8";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
