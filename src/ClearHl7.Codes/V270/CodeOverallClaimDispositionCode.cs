namespace ClearHl7.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0457 - Overall Claim Disposition Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0457</remarks>
    public enum CodeOverallClaimDispositionCode
    {
        /// <summary>
        /// 0 - No edits present on claim.
        /// </summary>
        NoEditsPresentOnClaim,

        /// <summary>
        /// 1 - Only edits present are for line item denial or rejection.
        /// </summary>
        EditsPresentAreForLineItemDenialOrRejection,

        /// <summary>
        /// 2 - Multiple-day claim with one or more days denied or rejected.
        /// </summary>
        MultipleDayClaimWithDaysDeniedOrRejected,

        /// <summary>
        /// 3 - Claim denied, rejected, suspended or returned to provider with only post payment edits.
        /// </summary>
        ClaimDeniedWithOnlyPostPaymentEdits,

        /// <summary>
        /// 4 - Claim denied, rejected, suspended or returned to provider with only pre payment edits.
        /// </summary>
        ClaimDeniedWithOnlyPrePaymentEdits
    }
}
