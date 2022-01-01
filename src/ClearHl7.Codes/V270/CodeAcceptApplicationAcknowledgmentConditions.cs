namespace ClearHl7.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0155 - Accept/Application Acknowledgment Conditions.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0155</remarks>
    public enum CodeAcceptApplicationAcknowledgmentConditions
    {
        /// <summary>
        /// AL - Always.
        /// </summary>
        Always,

        /// <summary>
        /// ER - Error/reject conditions only.
        /// </summary>
        ErrorRejectConditionsOnly,

        /// <summary>
        /// NE - Never.
        /// </summary>
        Never,

        /// <summary>
        /// SU - Successful completion only.
        /// </summary>
        SuccessfulCompletionOnly
    }
}
