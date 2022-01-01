namespace ClearHl7.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0179 - Response Level.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0179</remarks>
    public enum CodeResponseLevel
    {
        /// <summary>
        /// AL - Always.  All MFA segments (whether denoting errors or not) must be returned via the application-level acknowledgment message.
        /// </summary>
        Always,

        /// <summary>
        /// ER - Error/Reject conditions only.  Only MFA segments denoting errors must be returned via the application-level acknowledgment for this message.
        /// </summary>
        ErrorReject,

        /// <summary>
        /// NE - Never.  No application-level response needed.
        /// </summary>
        Never,

        /// <summary>
        /// SU - Success.  Only MFA segments denoting success must be returned via the application-level acknowledgment for this message.
        /// </summary>
        Success
    }
}
