using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V271.Types
{
    /// <summary>
    /// HL7 Version 2 CD - Channel Definition.
    /// </summary>
    public class ChannelDefinition : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

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
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            if (segments.Length > 0)
            {
                ChannelIdentifier = new ChannelIdentifier { IsSubcomponent = true };
                ChannelIdentifier.FromDelimitedString(segments.ElementAtOrDefault(0));
            }
            else
            {
                ChannelIdentifier = null;
            }

            if (segments.Length > 1)
            {
                WaveformSource = new WaveformSource { IsSubcomponent = true };
                WaveformSource.FromDelimitedString(segments.ElementAtOrDefault(1));
            }
            else
            {
                WaveformSource = null;
            }

            if (segments.Length > 2)
            {
                ChannelSensitivityAndUnits = new ChannelSensitivityAndUnits { IsSubcomponent = true };
                ChannelSensitivityAndUnits.FromDelimitedString(segments.ElementAtOrDefault(2));
            }
            else
            {
                ChannelIdentifier = null;
            }

            if (segments.Length > 3)
            {
                ChannelCalibrationParameters = new ChannelCalibrationParameters { IsSubcomponent = true };
                ChannelCalibrationParameters.FromDelimitedString(segments.ElementAtOrDefault(3));
            }
            else
            {
                ChannelCalibrationParameters = null;
            }

            ChannelSamplingFrequency = segments.ElementAtOrDefault(4)?.ToNullableDecimal();

            if (segments.Length > 5)
            {
                MinimumAndMaximumDataValues = new NumericRange { IsSubcomponent = true };
                MinimumAndMaximumDataValues.FromDelimitedString(segments.ElementAtOrDefault(5));
            }
            else
            {
                MinimumAndMaximumDataValues = null;
            }
        }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 6, separator),
                                ChannelIdentifier?.ToDelimitedString(),
                                WaveformSource?.ToDelimitedString(),
                                ChannelSensitivityAndUnits?.ToDelimitedString(),
                                ChannelCalibrationParameters?.ToDelimitedString(),
                                ChannelSamplingFrequency.HasValue ? ChannelSamplingFrequency.Value.ToString(Consts.NumericFormat, culture) : null,
                                MinimumAndMaximumDataValues?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
