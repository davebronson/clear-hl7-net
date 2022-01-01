namespace ClearHl7.Codes.V281
{
    /// <summary>
    /// HL7 Version 2 Table 0383 - Substance Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0383</remarks>
    public enum CodeSubstanceStatus
    {
        /// <summary>
        /// CE - Calibration Error.
        /// </summary>
        CalibrationError,

        /// <summary>
        /// CW - Calibration Warning.
        /// </summary>
        CalibrationWarning,

        /// <summary>
        /// EE - Expired Error.
        /// </summary>
        ExpiredError,

        /// <summary>
        /// EW - Expired Warning.
        /// </summary>
        ExpiredWarning,

        /// <summary>
        /// NE - Not Available Error.
        /// </summary>
        NotAvailableError,

        /// <summary>
        /// NW - Not Available Warning.
        /// </summary>
        NotAvailableWarning,

        /// <summary>
        /// OE - Other Error.
        /// </summary>
        OtherError,

        /// <summary>
        /// OK - OK Status.
        /// </summary>
        OkStatus,

        /// <summary>
        /// OW - Other Warning.
        /// </summary>
        OtherWarning,

        /// <summary>
        /// QE - QC Error.
        /// </summary>
        QcError,

        /// <summary>
        /// QW - QC Warning.
        /// </summary>
        QcWarning
    }
}
