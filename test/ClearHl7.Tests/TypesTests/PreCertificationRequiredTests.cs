using System;
using ClearHl7.V240.Types;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class PreCertificationRequiredTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new PreCertificationRequired
            {
                PreCertificationPatientType = "1",
                PreCertificationIsRequired = "2",
                PreCertificationWindow = new DateTime(2020, 3, 3, 0, 0, 3)
            };

            string expected = "1^2^20200303000003";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
