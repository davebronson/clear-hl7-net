using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.TypesTests
{
    public class ChannelDefinitionTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
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
