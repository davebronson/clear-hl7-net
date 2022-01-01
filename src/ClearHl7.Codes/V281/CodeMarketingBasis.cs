namespace ClearHl7.Codes.V281
{
    /// <summary>
    /// HL7 Version 2 Table 0330 - Marketing Basis.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0330</remarks>
    public enum CodeMarketingBasis
    {
        /// <summary>
        /// 510E - 510 (K) exempt.
        /// </summary>
        Basis510KExempt,

        /// <summary>
        /// 510K - 510 (K).
        /// </summary>
        Basis510K,

        /// <summary>
        /// 522S - Post marketing study (522).
        /// </summary>
        PostMarketingStudy522,

        /// <summary>
        /// PMA - Premarketing authorization.
        /// </summary>
        PremarketingAuthorization,

        /// <summary>
        /// PRE - Preamendment.
        /// </summary>
        Preamendment,

        /// <summary>
        /// TXN - Transitional.
        /// </summary>
        Transitional
    }
}
