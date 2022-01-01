namespace ClearHl7.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0516 - Error Severity.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0516</remarks>
    public enum CodeErrorSeverity
    {
        /// <summary>
        /// E - Error.
        /// </summary>
        Error,

        /// <summary>
        /// F - Fatal Error.
        /// </summary>
        FatalError,

        /// <summary>
        /// I - Information.
        /// </summary>
        Information,

        /// <summary>
        /// W - Warning.
        /// </summary>
        Warning
    }
}
