namespace ClearHl7.Codes.V230
{
    /// <summary>
    /// HL7 Version 2 Table 0102 - Delayed Acknowledgment Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0102</remarks>
    public enum CodeDelayedAcknowledgmentType
    {
        /// <summary>
        /// D - Message received, stored for later processing.
        /// </summary>
        MessageReceived,

        /// <summary>
        /// F - acknowledgment after processing.
        /// </summary>
        AcknowledgmentAfterProcessing
    }
}
