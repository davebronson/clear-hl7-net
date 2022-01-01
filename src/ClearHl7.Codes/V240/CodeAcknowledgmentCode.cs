namespace ClearHl7.Codes.V240
{
    /// <summary>
    /// HL7 Version 2 Table 0008 - Acknowledgment Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0008</remarks>
    public enum CodeAcknowledgmentCode
    {
        /// <summary>
        /// AA - Original mode: Application Accept - Enhanced mode: Application acknowledgment: Accept.
        /// </summary>
        OriginalModeAcceptEnhancedModeAcknowledgmentAccept,

        /// <summary>
        /// AE - Original mode: Application Error - Enhanced mode: Application acknowledgment: Error.
        /// </summary>
        OriginalModeErrorEnhancedModeAcknowledgmentError,

        /// <summary>
        /// AR - Original mode: Application Reject - Enhanced mode: Application acknowledgment: Reject.
        /// </summary>
        OriginalModeRejectEnhancedModeAcknowledgmentReject,

        /// <summary>
        /// CA - Enhanced mode: Accept acknowledgment: Commit Accept.
        /// </summary>
        EnhancedModeAcceptAcknowledgmentCommitAccept,

        /// <summary>
        /// CE - Enhanced mode: Accept acknowledgment: Commit Error.
        /// </summary>
        EnhancedModeAcceptAcknowledgmentCommitError,

        /// <summary>
        /// CR - Enhanced mode: Accept acknowledgment: Commit Reject.
        /// </summary>
        EnhancedModeAcceptAcknowledgmentCommitReject
    }
}
