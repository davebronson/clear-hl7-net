using System;
using ClearHl7.Fhir.V290.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.TypesTests
{
    public class PractitionerInstitutionalPrivilegesTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
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
