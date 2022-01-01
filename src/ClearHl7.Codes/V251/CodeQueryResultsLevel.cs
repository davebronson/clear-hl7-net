namespace ClearHl7.Codes.V251
{
    /// <summary>
    /// HL7 Version 2 Table 0108 - Query Results Level.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0108</remarks>
    public enum CodeQueryResultsLevel
    {
        /// <summary>
        /// O - Order plus order status.
        /// </summary>
        OrderPlusOrderStatus,

        /// <summary>
        /// R - Results without bulk text.
        /// </summary>
        ResultsWithoutBulkText,

        /// <summary>
        /// S - Status only.
        /// </summary>
        StatusOnly,

        /// <summary>
        /// T - Full results.
        /// </summary>
        FullResults
    }
}
