using System;

namespace ClearHl7.Fhir.Codes.V210
{
    /// <summary>
    /// HL7 Version 2 Table 0008 - Acknowledgment Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0008</remarks>
    public enum AcknowledgmentCode
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
        OriginalModeRejectEnhancedModeAcknowledgmentReject
    }
}