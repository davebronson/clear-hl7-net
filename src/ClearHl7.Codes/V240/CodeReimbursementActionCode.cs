namespace ClearHl7.Codes.V240
{
    /// <summary>
    /// HL7 Version 2 Table 0459 - Reimbursement Action Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0459</remarks>
    public enum CodeReimbursementActionCode
    {
        /// <summary>
        /// 0 - OCE line item denial or rejection is not ignored.
        /// </summary>
        OceLineItemDenialOrRejectionIsNotIgnored,

        /// <summary>
        /// 1 - OCE line item denial or rejection is ignored.
        /// </summary>
        OceLineItemDenialOrRejectionIsIgnored,

        /// <summary>
        /// 2 - External line item denial. Line item is denied even if no OCE edits.
        /// </summary>
        ExternalLineItemDenial,

        /// <summary>
        /// 3 - External line item rejection. Line item is rejected even if no OCE edits.
        /// </summary>
        ExternalLineItemRejection
    }
}
