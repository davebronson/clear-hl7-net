namespace ClearHl7.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0168 - Processing Priority.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0168</remarks>
    public enum CodeProcessingPriority
    {
        /// <summary>
        /// A - As soon as possible (a priority lower than stat).
        /// </summary>
        AsSoonAsPossible,

        /// <summary>
        /// B - Do at bedside or portable (may be used with other codes).
        /// </summary>
        DoAtBedsideOrPortable,

        /// <summary>
        /// C - Measure continuously (e.g., arterial line blood pressure).
        /// </summary>
        MeasureContinuously,

        /// <summary>
        /// P - Preoperative (to be done prior to surgery).
        /// </summary>
        Preoperative,

        /// <summary>
        /// R - Routine.
        /// </summary>
        Routine,

        /// <summary>
        /// S - Stat (do immediately).
        /// </summary>
        Stat,

        /// <summary>
        /// T - Timing critical (do as near as possible to requested time).
        /// </summary>
        TimingCritical
    }
}
