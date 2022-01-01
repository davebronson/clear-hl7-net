namespace ClearHl7.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0027 - Priority.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0027</remarks>
    public enum CodePriority
    {
        /// <summary>
        /// A - As soon as possible (a priority lower than stat).
        /// </summary>
        AsSoonAsPossible,

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
