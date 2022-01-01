namespace ClearHl7.Codes.V250
{
    /// <summary>
    /// HL7 Version 2 Table 0394 - Response Modality.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0394</remarks>
    public enum CodeResponseModality
    {
        /// <summary>
        /// B - Batch.
        /// </summary>
        Batch,

        /// <summary>
        /// R - Real Time.
        /// </summary>
        RealTime,

        /// <summary>
        /// T - Bolus (a series of responses sent at the same time without use of batch formatting).
        /// </summary>
        Bolus
    }
}
