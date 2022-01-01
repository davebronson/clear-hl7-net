namespace ClearHl7.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0208 - Query Response Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0208</remarks>
    public enum CodeQueryResponseStatus
    {
        /// <summary>
        /// AE - Application error.
        /// </summary>
        ApplicationError,

        /// <summary>
        /// AR - Application reject.
        /// </summary>
        ApplicationReject,

        /// <summary>
        /// NF - No data found, no errors.
        /// </summary>
        NoDataFoundNoErrors,

        /// <summary>
        /// OK - Data found, no errors (this is the default).
        /// </summary>
        DataFoundNoErrors
    }
}
