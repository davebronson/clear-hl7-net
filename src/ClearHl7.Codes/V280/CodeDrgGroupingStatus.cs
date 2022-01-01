namespace ClearHl7.Codes.V280
{
    /// <summary>
    /// HL7 Version 2 Table 0749 - DRG Grouping Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0749</remarks>
    public enum CodeDrgGroupingStatus
    {
        /// <summary>
        /// 0 - Valid code; not used for grouping.
        /// </summary>
        ValidCodeNotUsedForGrouping,

        /// <summary>
        /// 1 - Valid code; used for grouping.
        /// </summary>
        ValidCodeUsedForGrouping,

        /// <summary>
        /// 2 - Invalid code; not used for grouping.
        /// </summary>
        InvalidCodeNotUsedForGrouping,

        /// <summary>
        /// 3 - Invalid code; code is relevant for grouping.
        /// </summary>
        InvalidCodeCodeIsRelevantForGrouping
    }
}
