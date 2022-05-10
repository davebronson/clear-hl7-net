using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V260.Types
{
    /// <summary>
    /// HL7 Version 2 CD - Channel Definition.
    /// </summary>
    public class ChannelDefinition : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelDefinition"/> class.
        /// </summary>
        public ChannelDefinition()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelDefinition"/> class.
        /// </summary>
        /// <param name="channelIdentifier">CD.1 - Channel Identifier.</param>
        public ChannelDefinition(ChannelIdentifier channelIdentifier)
        {
            ChannelIdentifier = channelIdentifier;
        }

        /// <inheritdoc/>
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
        public NumericRange MinimumAndMaximumDataValues { get; set; }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] separator = IsSubcomponent ? seps.SubcomponentSeparator : seps.ComponentSeparator;
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(separator, StringSplitOptions.None);

            ChannelIdentifier = segments.Length > 0 && segments[0].Length > 0 ? TypeSerializer.Deserialize<ChannelIdentifier>(segments[0], true, seps) : null;
            WaveformSource = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<WaveformSource>(segments[1], true, seps) : null;
            ChannelSensitivityAndUnits = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<ChannelSensitivityAndUnits>(segments[2], true, seps) : null;
            ChannelCalibrationParameters = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<ChannelCalibrationParameters>(segments[3], true, seps) : null;
            ChannelSamplingFrequency = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDecimal() : null;
            MinimumAndMaximumDataValues = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<NumericRange>(segments[5], true, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
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
