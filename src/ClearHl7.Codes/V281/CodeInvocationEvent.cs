namespace ClearHl7.Codes.V281
{
    /// <summary>
    /// HL7 Version 2 Table 0100 - Invocation Event.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0100</remarks>
    public enum CodeInvocationEvent
    {
        /// <summary>
        /// D - On discharge.
        /// </summary>
        OnDischarge,

        /// <summary>
        /// O - On receipt of order.
        /// </summary>
        OnReceiptOfOrder,

        /// <summary>
        /// R - At time service is completed.
        /// </summary>
        AtTimeServiceIsCompleted,

        /// <summary>
        /// S - At time service is started.
        /// </summary>
        AtTimeServiceIsStarted,

        /// <summary>
        /// T - At a designated date/time.
        /// </summary>
        AtDesignatedDateTime
    }
}
