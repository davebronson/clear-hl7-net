namespace ClearHl7.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0909 - Patient Results Release Categorization Scheme.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0909</remarks>
    public enum CodePatientResultsReleaseCategorizationScheme
    {
        /// <summary>
        /// SID - Share In 1 Day. Share result regardless of reference/therapeutic range after 1 or more business day as agreed to by the systems in play.
        /// </summary>
        ShareIn1Day,

        /// <summary>
        /// SIDC - Share in 1 Day Conditionally. Share result in reference ranges/therapeutic with patient after 1 or more business day as agreed to by the systems in play. Withhold result out of reference/therapeutic range until physician release.
        /// </summary>
        ShareIn1DayConditionally,

        /// <summary>
        /// SIMM - Share Immediately. Share result with patient immediately.
        /// </summary>
        ShareImmediately,

        /// <summary>
        /// STBD - Share To Be Determined. Category to be determined.
        /// </summary>
        ShareToBeDetermined,

        /// <summary>
        /// SWNL - Share Within Normal Limits. Share result in reference/therapeutic range with patient immediately. Share result out of reference/therapeutic ranges with patient after 1 or more business day as agreed to by the systems in play.
        /// </summary>
        ShareWithinNormalLimits,

        /// <summary>
        /// SWTH - Share Withhold. Withhold result regardless of reference/therapeutic ranges.
        /// </summary>
        ShareWithhold
    }
}
