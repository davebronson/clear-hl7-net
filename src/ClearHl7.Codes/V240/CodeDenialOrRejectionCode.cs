namespace ClearHl7.Codes.V240
{
    /// <summary>
    /// HL7 Version 2 Table 0460 - Denial Or Rejection Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0460</remarks>
    public enum CodeDenialOrRejectionCode
    {
        /// <summary>
        /// 0 - Line item not denied or rejected.
        /// </summary>
        LineItemNotDeniedOrRejected,

        /// <summary>
        /// 1 - Line item denied or rejected.
        /// </summary>
        LineItemDeniedOrRejected,

        /// <summary>
        /// 2 - Line item is on a multiple-day claim. The line item is not denied or rejected, but occurs on a day that has been denied or rejected.
        /// </summary>
        LineItemIsOnAMultipleDayClaim
    }
}
