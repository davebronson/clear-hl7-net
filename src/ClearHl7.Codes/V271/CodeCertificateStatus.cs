namespace ClearHl7.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0536 - Certificate Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0536</remarks>
    public enum CodeCertificateStatus
    {
        /// <summary>
        /// E - Expired.
        /// </summary>
        Expired,

        /// <summary>
        /// I - Inactive.
        /// </summary>
        Inactive,

        /// <summary>
        /// P - Provisional.
        /// </summary>
        Provisional,

        /// <summary>
        /// R - Revoked.
        /// </summary>
        Revoked,

        /// <summary>
        /// V - Active/Valid.
        /// </summary>
        ActiveValid
    }
}
