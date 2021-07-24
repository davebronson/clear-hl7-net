using ClearHl7.V270.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class LocationWithAddressVariationOneTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new LocationWithAddressVariationOne
            {
                PointOfCare = "1",
                Room = "2",
                Bed = "3",
                Facility = new HierarchicDesignator
                {
                    IsSubcomponent = true,
                    NamespaceId = "4"
                },
                LocationStatus = "5",
                PatientLocationType = "6",
                Building = "7",
                Floor = "8",
                Address = new Address
                {
                    IsSubcomponent = true,
                    StreetAddress = "9"
                }
            };

            IType actual = new LocationWithAddressVariationOne();
            actual.FromDelimitedString("1^2^3^4^5^6^7^8^9");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
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
