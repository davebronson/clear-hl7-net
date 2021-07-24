using System;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class NameWithDateAndLocationTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new NameWithDateAndLocation
            {
                Name = new CompositeIdNumberAndNameSimplified
                {
                    IsSubcomponent = true,
                    IdNumber = "1"
                },
                StartDateTime = new DateTime(2020, 2, 2, 00, 00, 2),
                EndDateTime = new DateTime(2020, 3, 3, 00, 00, 33),
                PointOfCare = "4",
                Room = "5",
                Bed = "6",
                Facility = new HierarchicDesignator
                {
                    IsSubcomponent = true,
                    NamespaceId = "7"
                },
                LocationStatus = "8",
                PatientLocationType = "9",
                Building = "10",
                Floor = "11"
            };

            IType actual = new NameWithDateAndLocation();
            actual.FromDelimitedString("1^20200202000002^20200303000033^4^5^6^7^8^9^10^11");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new NameWithDateAndLocation
            {
                Name = new CompositeIdNumberAndNameSimplified
                {
                    IdNumber = "1"
                },
                StartDateTime = new DateTime(2020, 2, 2, 00, 00, 2),
                EndDateTime = new DateTime(2020, 3, 3, 00, 00, 33),
                PointOfCare = "4",
                Room = "5",
                Bed = "6",
                Facility = new HierarchicDesignator
                {
                    NamespaceId = "7"
                },
                LocationStatus = "8",
                PatientLocationType = "9",
                Building = "10",
                Floor = "11"
            };

            string expected = "1^20200202000002^20200303000033^4^5^6^7^8^9^10^11";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
