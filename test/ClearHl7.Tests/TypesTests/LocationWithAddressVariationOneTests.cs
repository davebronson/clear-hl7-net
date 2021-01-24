using ClearHl7.V270.Types;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class LocationWithAddressVariationOneTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new LocationWithAddressVariationOne
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
                Address = new Address
                {
                    StreetAddress = "9"
                }
            };

            string expected = "1^2^3^4^5^6^7^8^9";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
