namespace ClearHl7.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0501 - Consent Non-Disclosure Reason.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0501</remarks>
    public enum CodeConsentNonDisclosureReason
    {
        /// <summary>
        /// E - Emergency.
        /// </summary>
        Emergency,

        /// <summary>
        /// PR - Patient Request.
        /// </summary>
        PatientRequest,

        /// <summary>
        /// RX - Rx Private.
        /// </summary>
        RxPrivate
    }
}
