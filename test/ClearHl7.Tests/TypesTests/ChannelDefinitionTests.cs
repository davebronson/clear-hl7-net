using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class ChannelDefinitionTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new ChannelDefinition
            {
                ChannelIdentifier = new ChannelIdentifier
                {
                    IsSubcomponent = true,
                    ChannelNumber = 1
                },
                WaveformSource = new WaveformSource
                {
                    IsSubcomponent = true,
                    SourceOneName = "2"
                },
                ChannelSensitivityAndUnits = new ChannelSensitivityAndUnits
                {
                    IsSubcomponent = true,
                    ChannelSensitivity = 3
                },
                ChannelCalibrationParameters = new ChannelCalibrationParameters
                {
                    IsSubcomponent = true,
                    ChannelCalibrationSensitivityCorrectionFactor = 4
                },
                ChannelSamplingFrequency = 5,
                MinimumAndMaximumDataValues = new NumericRange
                {
                    IsSubcomponent = true,
                    LowValue = 6
                }
            };

            IType actual = new ChannelDefinition();
            actual.FromDelimitedString("1^2^3^4^5^6");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new ChannelDefinition
            {
                ChannelIdentifier = new ChannelIdentifier
                {
                    ChannelNumber = 1
                },
                WaveformSource = new WaveformSource
                {
                    SourceOneName = "2"
                },
                ChannelSensitivityAndUnits = new ChannelSensitivityAndUnits
                {
                    ChannelSensitivity = 3
                },
                ChannelCalibrationParameters = new ChannelCalibrationParameters
                {
                    ChannelCalibrationSensitivityCorrectionFactor = 4
                },
                ChannelSamplingFrequency = 5,
                MinimumAndMaximumDataValues = new NumericRange
                {
                    LowValue = 6
                }
            };

            string expected = "1^2^3^4^5^6";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
