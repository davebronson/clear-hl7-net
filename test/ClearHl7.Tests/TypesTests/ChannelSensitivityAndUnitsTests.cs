using System;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class ChannelSensitivityAndUnitsTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new ChannelSensitivityAndUnits
            {
                ChannelSensitivity = 1,
                UnitOfMeasureIdentifier = "2",
                UnitOfMeasureDescription = "3",
                UnitOfMeasureCodingSystem = "4",
                AlternateUnitOfMeasureIdentifier = "5",
                AlternateUnitOfMeasureDescription = "6",
                AlternateUnitOfMeasureCodingSystem = "7",
                UnitOfMeasureCodingSystemVersionId = "8",
                AlternateUnitOfMeasureCodingSystemVersionId = "9",
                OriginalText = "10",
                SecondAlternateUnitOfMeasureIdentifier = "11",
                SecondAlternateUnitOfMeasureText = "12",
                NameOfSecondAlternateUnitOfMeasureCodingSystem = "13",
                SecondAlternateUnitOfMeasureCodingSystemVersionId = "14",
                UnitOfMeasureCodingSystemOid = "15",
                UnitOfMeasureValueSetOid = "16",
                UnitOfMeasureValueSetVersionId = new DateTime(2020, 1, 7),
                AlternateUnitOfMeasureCodingSystemOid = "18",
                AlternateUnitOfMeasureValueSetOid = "19",
                AlternateUnitOfMeasureValueSetVersionId = new DateTime(2020, 2, 1),
                AlternateUnitOfMeasureCodingSystemOidAdditional = "21",
                AlternateUnitOfMeasureValueSetOidAdditional = "22",
                AlternateUnitOfMeasureValueSetVersionIdAdditional = "23"
            };

            IType actual = new ChannelSensitivityAndUnits();
            actual.FromDelimitedString("1^2^3^4^5^6^7^8^9^10^11^12^13^14^15^16^20200107^18^19^20200201^21^22^23");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new ChannelSensitivityAndUnits
            {
                ChannelSensitivity = 1,
                UnitOfMeasureIdentifier = "2",
                UnitOfMeasureDescription = "3",
                UnitOfMeasureCodingSystem = "4",
                AlternateUnitOfMeasureIdentifier = "5",
                AlternateUnitOfMeasureDescription = "6",
                AlternateUnitOfMeasureCodingSystem = "7",
                UnitOfMeasureCodingSystemVersionId = "8",
                AlternateUnitOfMeasureCodingSystemVersionId = "9",
                OriginalText = "10",
                SecondAlternateUnitOfMeasureIdentifier = "11",
                SecondAlternateUnitOfMeasureText = "12",
                NameOfSecondAlternateUnitOfMeasureCodingSystem = "13",
                SecondAlternateUnitOfMeasureCodingSystemVersionId = "14",
                UnitOfMeasureCodingSystemOid = "15",
                UnitOfMeasureValueSetOid = "16",
                UnitOfMeasureValueSetVersionId = new DateTime(2020, 1, 7),
                AlternateUnitOfMeasureCodingSystemOid = "18",
                AlternateUnitOfMeasureValueSetOid = "19",
                AlternateUnitOfMeasureValueSetVersionId = new DateTime(2020, 2, 1),
                AlternateUnitOfMeasureCodingSystemOidAdditional = "21",
                AlternateUnitOfMeasureValueSetOidAdditional = "22",
                AlternateUnitOfMeasureValueSetVersionIdAdditional = "23"
            };

            string expected = "1^2^3^4^5^6^7^8^9^10^11^12^13^14^15^16^20200107^18^19^20200201^21^22^23";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
