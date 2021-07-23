using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V270.Types
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

            ChannelIdentifier = segments.Length > 0 ? TypeHelper.Deserialize<ChannelIdentifier>(segments.ElementAtOrDefault(0), true) : null;
            WaveformSource = segments.Length > 1 ? TypeHelper.Deserialize<WaveformSource>(segments.ElementAtOrDefault(1), true) : null;
            ChannelSensitivityAndUnits = segments.Length > 2 ? TypeHelper.Deserialize<ChannelSensitivityAndUnits>(segments.ElementAtOrDefault(2), true) : null;
            ChannelCalibrationParameters = segments.Length > 3 ? TypeHelper.Deserialize<ChannelCalibrationParameters>(segments.ElementAtOrDefault(3), true) : null;
            ChannelSamplingFrequency = segments.ElementAtOrDefault(4)?.ToNullableDecimal();
            MinimumAndMaximumDataValues = segments.Length > 5 ? TypeHelper.Deserialize<NumericRange>(segments.ElementAtOrDefault(5), true) : null;
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
