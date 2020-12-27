using System;
using ClearHl7.Fhir.V290.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.TypesTests
{
    public class ExtendedCompositeIdWithCheckDigitTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new ExtendedCompositeIdWithCheckDigit
            {
                IdNumber = "1",
                IdentifierCheckDigit = "2",
                CheckDigitScheme = "3",
                AssigningAuthority = new HierarchicDesignator
                {
                    NamespaceId = "4"
                },
                IdentifierTypeCode = "5",
                AssigningFacility = new HierarchicDesignator
                {
                    NamespaceId = "6"
                },
                EffectiveDate = new DateTime(2020, 7, 7),
                ExpirationDate = new DateTime(2020, 8, 8),
                AssigningJurisdiction = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                AssigningAgencyOrDepartment = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                SecurityCheck = "11",
                SecurityCheckScheme = "12"
            };

            string expected = "1^2^3^4^5^6^20200707^20200808^9^10^11^12";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
