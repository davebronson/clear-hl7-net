using ClearHl7.Fhir.V290.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.TypesTests
{
    public class AddressTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new Address
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
