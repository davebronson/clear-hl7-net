using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 CCP - Channel Calibration Parameters.
    /// </summary>
    public class ChannelCalibrationParameters
    {
        /// <summary>
        /// CCP.1 - Channel Calibration Sensitivity Correction Factor.
        /// </summary>
        public decimal ChannelCalibrationSensitivityCorrectionFactor { get; set; }

        /// <summary>
        /// CCP.2 - Channel Calibration Baseline.
        /// </summary>
        public decimal ChannelCalibrationBaseline { get; set; }

        /// <summary>
        /// CCP.3 - Channel Calibration Time Skew.
        /// </summary>
        public decimal ChannelCalibrationTimeSkew { get; set; }
    }
}
