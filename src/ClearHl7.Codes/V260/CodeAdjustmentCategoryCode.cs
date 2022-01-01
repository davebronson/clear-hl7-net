namespace ClearHl7.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0564 - Adjustment Category Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0564</remarks>
    public enum CodeAdjustmentCategoryCode
    {
        /// <summary>
        /// EA - Edit/Adjudication Response.
        /// </summary>
        EditAdjudicationResponse,

        /// <summary>
        /// IN - Information.
        /// </summary>
        Information,

        /// <summary>
        /// PA - Provider Adjustment.
        /// </summary>
        ProviderAdjustment,

        /// <summary>
        /// PR - Processing Result.
        /// </summary>
        ProcessingResult
    }
}
