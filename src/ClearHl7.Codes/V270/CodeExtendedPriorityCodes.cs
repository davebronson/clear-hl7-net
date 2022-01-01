namespace ClearHl7.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0485 - Extended Priority Codes.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0485</remarks>
    public enum CodeExtendedPriorityCodes
    {
        /// <summary>
        /// A - ASAP.
        /// </summary>
        Asap,

        /// <summary>
        /// C - Callback.
        /// </summary>
        Callback,

        /// <summary>
        /// P - Preop.
        /// </summary>
        Preop,

        /// <summary>
        /// PRN - As needed.
        /// </summary>
        AsNeeded,

        /// <summary>
        /// R - Routine.
        /// </summary>
        Routine,

        /// <summary>
        /// S - Stat.
        /// </summary>
        Stat,

        /// <summary>
        /// T - Timing critical.
        /// </summary>
        TimingCritical,

        /// <summary>
        /// TDinteger - Timing critical within integer days.
        /// </summary>
        TimingCriticalWithinIntegerDays,

        /// <summary>
        /// THinteger - Timing critical within integer hours.
        /// </summary>
        TimingCriticalWithinIntegerHours,

        /// <summary>
        /// TLinteger - Timing critical within integer months.
        /// </summary>
        TimingCriticalWithinIntegerMonths,

        /// <summary>
        /// TMinteger - Timing critical within integer minutes.
        /// </summary>
        TimingCriticalWithinIntegerMinutes,

        /// <summary>
        /// TSinteger - Timing critical within integer seconds.
        /// </summary>
        TimingCriticalWithinIntegerSeconds,

        /// <summary>
        /// TWinteger - Timing critical within integer weeks.
        /// </summary>
        TimingCriticalWithinIntegerWeeks
    }
}
