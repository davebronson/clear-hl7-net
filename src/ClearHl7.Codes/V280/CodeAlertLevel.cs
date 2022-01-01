namespace ClearHl7.Codes.V280
{
    /// <summary>
    /// HL7 Version 2 Table 0367 - Alert Level.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0367</remarks>
    public enum CodeAlertLevel
    {
        /// <summary>
        /// ... - (null) No level change.
        /// </summary>
        NullNoLevelChangeADeprecated,

        /// <summary>
        /// C - Critical.
        /// </summary>
        Critical,

        /// <summary>
        /// N - Normal.
        /// </summary>
        Normal,

        /// <summary>
        /// S - Serious.
        /// </summary>
        Serious,

        /// <summary>
        /// W - Warning.
        /// </summary>
        Warning
    }
}
