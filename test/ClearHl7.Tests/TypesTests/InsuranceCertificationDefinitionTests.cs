using System;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class InsuranceCertificationDefinitionTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new InsuranceCertificationDefinition
            {
                CertificationPatientType = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "1"
                },
                CertificationRequired = "2",
                DateTimeCertificationRequired = new DateTime(2020, 3, 3, 0, 0, 33)
            };

            IType actual = new InsuranceCertificationDefinition();
            actual.FromDelimitedString("1^2^20200303000033");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
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
