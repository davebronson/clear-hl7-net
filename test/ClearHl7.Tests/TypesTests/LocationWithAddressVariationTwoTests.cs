using ClearHl7.V271.Types;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class LocationWithAddressVariationTwoTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new LocationWithAddressVariationTwo
            {
                PointOfCare = "1",
                Room = "2",
                Bed = "3",
                Facility = new HierarchicDesignator
                {
                    NamespaceId = "4"
                },
                LocationStatus = "5",
                PatientLocationType = "6",
                Building = "7",
                Floor = "8",
                StreetAddress = "9",
                OtherDesignation = "10",
                City = "11",
                StateOrProvince = "12",
                ZipOrPostalCode = "13",
                Country = "14",
                AddressType = "15",
                OtherGeographicDesignation = "16"
            };

            string expected = "1^2^3^4^5^6^7^8^9^10^11^12^13^14^15^16";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
