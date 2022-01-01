namespace ClearHl7.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0868 - Telecommunication Expiration Reason.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0868</remarks>
    public enum CodeTelecommunicationExpirationReason
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
        /// N - No longer in service.
        /// </summary>
        NoLongerInService,

        /// <summary>
        /// R - On request.
        /// </summary>
        OnRequest
    }
}
