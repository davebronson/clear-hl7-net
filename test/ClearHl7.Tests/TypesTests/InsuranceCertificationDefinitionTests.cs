using System;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class InsuranceCertificationDefinitionTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new InsuranceCertificationDefinition
            {
                CertificationPatientType = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                CertificationRequired = "2",
                DateTimeCertificationRequired = new DateTime(2020, 3, 3, 0, 0, 33)
            };

            string expected = "1^2^20200303000033";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
