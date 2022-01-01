namespace ClearHl7.Codes.V250
{
    /// <summary>
    /// HL7 Version 2 Table 0498 - Consent Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0498</remarks>
    public enum CodeConsentStatus
    {
        /// <summary>
        /// A - Active - Consent has been granted.
        /// </summary>
        Active,

        /// <summary>
        /// B - Bypassed (Consent not sought).
        /// </summary>
        Bypassed,

        /// <summary>
        /// L - Limited - Consent has been granted with limitations.
        /// </summary>
        Limited,

        /// <summary>
        /// P - Pending - Consent has not yet been sought.
        /// </summary>
        Pending,

        /// <summary>
        /// R - Refused - Consent has been refused.
        /// </summary>
        Refused,

        /// <summary>
        /// X - Rescinded - Consent was initially granted, but was subsequently revoked or ended.
        /// </summary>
        Rescinded
    }
}
