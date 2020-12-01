namespace ClearHl7.Fhir.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0909 - Patient Results Release Categorization Scheme.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0909</remarks>
    public enum PatientResultsReleaseCategorizationScheme
    {
        /// <summary>
        /// SID - Share In1 Day -pShare result regardless of reference/therapeutic range after 1 or more business day as agreed to by the systems in play..
        /// </summary>
        ShareIn1Day,
        
        /// <summary>
        /// SIDC - Share in 1 Day Conditionally -pShare result in reference ranges/therapeutic with patient after 1 or more business day as agreed to by the systems in play.pWithhold result out of reference/therapeutic range until physician release.
        /// </summary>
        ShareIn1DayConditionally,
        
        /// <summary>
        /// SIMM - Share Immediately -pShare result with patient immediately.
        /// </summary>
        ShareImmediately,
        
        /// <summary>
        /// STBD - Share To Be Determined -pCategory to be determined.
        /// </summary>
        ShareToBeDetermined,
        
        /// <summary>
        /// SWNL - Share Within Normal Limits -pShare result in reference/therapeutic range with patient immediatelypShare result out of reference/therapeutic ranges with patient after 1 or more business day as agreed to by the systems in play..
        /// </summary>
        ShareWithinNormalLimits,
        
        /// <summary>
        /// SWTH - Share Withhold -pWithhold result regardless of reference/therapeutic ranges.
        /// </summary>
        ShareWithhold
    }
}