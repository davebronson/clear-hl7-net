using System;

namespace ClearHl7.Fhir.V250.Types
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
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                IsSubcomponent ? "{0}&{1}&{2}" : "{0}^{1}^{2}",
                                ChannelCalibrationSensitivityCorrectionFactor.HasValue ? ChannelCalibrationSensitivityCorrectionFactor.Value.ToString(Consts.NumericFormat, culture) : null,
                                ChannelCalibrationBaseline.HasValue ? ChannelCalibrationBaseline.Value.ToString(Consts.NumericFormat, culture) : null,
                                ChannelCalibrationTimeSkew.HasValue ? ChannelCalibrationTimeSkew.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
