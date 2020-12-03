using System;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.TypesTests
{
    public class CodedWithNoExceptionsTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new CodedWithNoExceptions
            {
                Identifier = "1",
                Text = "2",
                NameOfCodingSystem = "3",
                AlternateIdentifier = "4",
                AlternateText = "5",
                NameOfAlternateCodingSystem = "6",
                CodingSystemVersionId = "7",
                AlternateCodingSystemVersionId = "8",
                OriginalText = "9",
                SecondAlternateIdentifier = "10",
                SecondAlternateText = "11",
                NameOfSecondAlternateCodingSystem = "12",
                SecondAlternateCodingSystemVersionId = "13",
                CodingSystemOid = "14",
                ValueSetOid = "15",
                ValueSetVersionId = new DateTime(2020, 1, 16),
                AlternateCodingSystemOid = "17",
                AlternateValueSetOid = "18",
                AlternateValueSetVersionId = new DateTime(2020, 1, 19),

        /// <summary>
        /// CNE.20 - Second Alternate Coding System OID.
        /// </summary>
        public string SecondAlternateCodingSystemOid { get; set; }

        /// <summary>
        /// CNE.21 - Second Alternate Value Set OID.
        /// </summary>
        public string SecondAlternateValueSetOid { get; set; }

        /// <summary>
        /// CNE.22 - Second Alternate Value Set Version ID.
        /// </summary>
        public DateTime? SecondAlternateValueSetVersionId { get; set; }
    };

            string expected = "1^2^3^4^5^6^7^8^9^10^11^12^13^14^15^16^17^18^19^20^21^22^23^24^25^26^27^28^29^30^31^32^33^34^35^36^37^38^39^40^41^42^43^44^45^46^47^48^49^50";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
