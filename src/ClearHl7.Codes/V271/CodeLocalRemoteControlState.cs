namespace ClearHl7.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0366 - Local/Remote Control State.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0366</remarks>
    public enum CodeLocalRemoteControlState
    {
        /// <summary>
        /// ... - (null) No state change.
        /// </summary>
        NullNoStateChangeADeprecated,

        /// <summary>
        /// L - Local.
        /// </summary>
        Local,

        /// <summary>
        /// R - Remote.
        /// </summary>
        Remote,

        /// <summary>
        /// ... - (null) No state change.
        /// </summary>
        NullNoStateChangeBDeprecated
    }
}
