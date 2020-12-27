using ClearHl7.Fhir.V290.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.TypesTests
{
    public class PersonLocationTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new PersonLocation
            {
                PointOfCare = new HierarchicDesignator
                {
                    NamespaceId = "1"
                },
                Room = new HierarchicDesignator
                {
                    NamespaceId = "2"
                },
                Bed = new HierarchicDesignator
                {
                    NamespaceId = "3"
                },
                Facility = new HierarchicDesignator
                {
                    NamespaceId = "4"
                },
                LocationStatus = "5",
                PersonLocationType = "6",
                Building = new HierarchicDesignator
                {
                    NamespaceId = "7"
                },
                Floor = new HierarchicDesignator
                {
                    NamespaceId = "8"
                },
                LocationDescription = "9",
                ComprehensiveLocationIdentifier = new EntityIdentifier
                {
                    EntityId = "10"
                },
                AssigningAuthorityForLocation = new HierarchicDesignator
                {
                    NamespaceId = "11"
                }
            };

            string expected = "1^2^3^4^5^6^7^8^9^10^11";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
