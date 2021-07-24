using System;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class PractitionerInstitutionalPrivilegesTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new PractitionerInstitutionalPrivileges
            {
                Privilege = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "1"
                },
                PrivilegeClass = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "2"
                },
                ExpirationDate = new DateTime(2020, 3, 3),
                ActivationDate = new DateTime(2020, 4, 4),
                Facility = new EntityIdentifier
                {
                    IsSubcomponent = true,
                    EntityId = "5"
                }
            };

            IType actual = new PractitionerInstitutionalPrivileges();
            actual.FromDelimitedString("1^2^20200303^20200404^5");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new PractitionerInstitutionalPrivileges
            {
                Privilege = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                PrivilegeClass = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                ExpirationDate = new DateTime(2020, 3, 3),
                ActivationDate = new DateTime(2020, 4, 4),
                Facility = new EntityIdentifier
                {
                    EntityId = "5"
                }
            };

            string expected = "1^2^20200303^20200404^5";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
