using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V290.Types
{
    /// <summary>
    /// HL7 Version 2 CCP - Channel Calibration Parameters.
    /// </summary>
    public class ChannelCalibrationParameters : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// CCP.1 - Channel Calibration Sensitivity Correction Factor.
        /// </summary>
        public decimal? ChannelCalibrationSensitivityCorrectionFactor { get; set; }

        /// <summary>
        /// CCP.2 - Channel Calibration Baseline.
        /// </summary>
        public decimal? ChannelCalibrationBaseline { get; set; }

        /// <summary>
        /// CCP.3 - Channel Calibration Time Skew.
        /// </summary>
        public decimal? ChannelCalibrationTimeSkew { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public ChannelCalibrationParameters FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            ChannelCalibrationSensitivityCorrectionFactor = segments.ElementAtOrDefault(0)?.ToNullableDecimal();
            ChannelCalibrationBaseline = segments.ElementAtOrDefault(1)?.ToNullableDecimal();
            ChannelCalibrationTimeSkew = segments.ElementAtOrDefault(2)?.ToNullableDecimal();

            return this;
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
                                StringHelper.StringFormatSequence(0, 3, separator),
                                ChannelCalibrationSensitivityCorrectionFactor.HasValue ? ChannelCalibrationSensitivityCorrectionFactor.Value.ToString(Consts.NumericFormat, culture) : null,
                                ChannelCalibrationBaseline.HasValue ? ChannelCalibrationBaseline.Value.ToString(Consts.NumericFormat, culture) : null,
                                ChannelCalibrationTimeSkew.HasValue ? ChannelCalibrationTimeSkew.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
