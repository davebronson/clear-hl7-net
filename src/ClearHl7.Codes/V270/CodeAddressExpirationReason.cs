namespace ClearHl7.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0616 - Address Expiration Reason.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0616</remarks>
    public enum CodeAddressExpirationReason
    {
        /// <summary>
        /// C - Corrected.
        /// </summary>
        Corrected,

        /// <summary>
        /// E - Added in error.
        /// </summary>
        AddedInError,

        /// <summary>
        /// M - Moved.
        /// </summary>
        Moved,

        /// <summary>
        /// R - On request.
        /// </summary>
        OnRequest
    }
}
