namespace ClearHl7.Codes.V230
{
    /// <summary>
    /// HL7 Version 2 Table 0208 - Query Response Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0208</remarks>
    public enum CodeQueryResponseStatus
    {
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
