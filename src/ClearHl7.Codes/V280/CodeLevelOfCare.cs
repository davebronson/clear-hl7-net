namespace ClearHl7.Codes.V280
{
    /// <summary>
    /// HL7 Version 2 Table 0263 - Level Of Care.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0263</remarks>
    public enum CodeLevelOfCare
    {
        /// <summary>
        /// A - Ambulatory.
        /// </summary>
        Ambulatory,

        /// <summary>
        /// C - Critical care.
        /// </summary>
        CriticalCare,

        /// <summary>
        /// E - Emergency.
        /// </summary>
        Emergency,

        /// <summary>
        /// F - Isolation.
        /// </summary>
        Isolation,

        /// <summary>
        /// N - Intensive care.
        /// </summary>
        IntensiveCare,

        /// <summary>
        /// R - Routine.
        /// </summary>
        Routine,

        /// <summary>
        /// S - Surgery.
        /// </summary>
        Surgery
    }
}
