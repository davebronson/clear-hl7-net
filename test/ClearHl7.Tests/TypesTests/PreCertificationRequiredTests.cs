using System;
using ClearHl7.V240.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class PreCertificationRequiredTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new PreCertificationRequired
            {
                PreCertificationPatientType = "1",
                PreCertificationIsRequired = "2",
                PreCertificationWindow = new DateTime(2020, 3, 3, 0, 0, 3)
            };

            IType actual = new PreCertificationRequired();
            actual.FromDelimitedString("1^2^20200303000003");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
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
