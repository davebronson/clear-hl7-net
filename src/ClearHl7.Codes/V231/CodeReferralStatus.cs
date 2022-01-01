namespace ClearHl7.Codes.V231
{
    /// <summary>
    /// HL7 Version 2 Table 0283 - Referral Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0283</remarks>
    public enum CodeReferralStatus
    {
        /// <summary>
        /// A - Accepted.
        /// </summary>
        Accepted,

        /// <summary>
        /// E - Expired.
        /// </summary>
        Expired,

        /// <summary>
        /// P - Pending.
        /// </summary>
        Pending,

        /// <summary>
        /// R - Rejected.
        /// </summary>
        Rejected
    }
}
