namespace ClearHl7.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0422 - Triage Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0422</remarks>
    public enum CodeTriageCode
    {
        /// <summary>
        /// 1 - Non-acute.
        /// </summary>
        NonAcute,

        /// <summary>
        /// 2 - Acute.
        /// </summary>
        Acute,

        /// <summary>
        /// 3 - Urgent.
        /// </summary>
        Urgent,

        /// <summary>
        /// 4 - Severe.
        /// </summary>
        Severe,

        /// <summary>
        /// 5 - Dead on Arrival (DOA).
        /// </summary>
        DeadOnArrivalDoa,

        /// <summary>
        /// 99 - Other.
        /// </summary>
        Other
    }
}
