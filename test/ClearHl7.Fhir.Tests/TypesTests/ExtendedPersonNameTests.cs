using System;
using ClearHl7.Fhir.V290.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.TypesTests
{
    public class ExtendedPersonNameTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new ExtendedPersonName
            {
                FamilyName = new FamilyName
                {
                    Surname = "1"
                },
                GivenName = "2",
                SecondAndFurtherGivenNamesOrInitialsThereof = "3",
                Suffix = "4",
                Prefix = "5",
                Degree = "6",
                NameTypeCode = "7",
                NameRepresentationCode = "8",
                NameContext = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                NameValidityRange = new DateTimeRange
                {
                    RangeStartDateTime = new DateTime(2020, 10, 10, 0, 0, 10)
                },
                NameAssemblyOrder = "11",
                EffectiveDate = new DateTime(2020, 12, 12, 0, 0, 12),
                ExpirationDate = new DateTime(2020, 1, 13, 0, 0, 13),
                ProfessionalSuffix = "14",
                CalledBy = "15"
            };

            string expected = "1^2^3^4^5^6^7^8^9^20201010000010^11^20201212000012^20200113000013^14^15";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
