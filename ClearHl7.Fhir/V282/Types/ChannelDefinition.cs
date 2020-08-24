using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 CD - Channel Definition.
    /// </summary>
    public class ChannelDefinition
    {
        /// <summary>
        /// CD.1 - Channel Identifier.
        /// </summary>
        public ChannelIdentifier ChannelIdentifier { get; set; }

        /// <summary>
        /// CD.2 - Waveform Source.
        /// </summary>
        public WaveformSource WaveformSource { get; set; }

        /// <summary>
        /// CD.3 - Channel Sensitivity and Units.
        /// </summary>
        public ChannelSensitivityAndUnits ChannelSensitivityAndUnits { get; set; }

        /// <summary>
        /// CD.4 - Channel Calibration Parameters.
        /// </summary>
        public ChannelCalibrationParameters ChannelCalibrationParameters { get; set; }

        /// <summary>
        /// CD.5 - Channel Sampling Frequency.
        /// </summary>
        public decimal? ChannelSamplingFrequency { get; set; }

        /// <summary>
        /// CD.6 - Minimum and Maximum Data Values.
        /// </summary>
        public NumericRange MinimumAndMaximumDataValues{ get; set; }

        /// <summary>
        /// Returns a pipe-delimited representation of this instance. 
        /// </summary>
        /// <param name="isSubcomponent">Whether this instance is a subcomponent of another component instance.</param>
        /// <returns>A string.</returns>
        public string ToPipeString(bool isSubcomponent)
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
            string format = isSubcomponent ? "{0}&{1}&{2}&{3}&{4}&{5}" : "{0}^{1}^{2}^{3}^{4}^{5}";

            return string.Format(
                                culture,
                                format,
                                ChannelIdentifier?.ToPipeString(true),
                                WaveformSource,
                                ChannelSensitivityAndUnits,
                                ChannelCalibrationParameters,
                                ChannelSamplingFrequency.HasValue ? ChannelSamplingFrequency.Value.ToString(Consts.NumericFormat, culture) : null,
                                MinimumAndMaximumDataValues
                                ).TrimEnd(isSubcomponent ? '&' : '^');
        }
    }
}
