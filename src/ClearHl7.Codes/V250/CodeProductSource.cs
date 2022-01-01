namespace ClearHl7.Codes.V250
{
    /// <summary>
    /// HL7 Version 2 Table 0248 - Product Source.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0248</remarks>
    public enum CodeProductSource
    {
        /// <summary>
        /// A - Actual product involved in incident was evaluated.
        /// </summary>
        ActualProductWasEvaluated,

        /// <summary>
        /// L - A product from the same lot as the actual product involved was evaluated.
        /// </summary>
        ProductFromSameLotWasEvaluated,

        /// <summary>
        /// N - A product from a controlled/non-related inventory was evaluated.
        /// </summary>
        ProductFromNonRelatedInventoryWasEvaluated,

        /// <summary>
        /// R - A product from a reserve sample was evaluated.
        /// </summary>
        ProductFromReserveWasEvaluated
    }
}
