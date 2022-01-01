namespace ClearHl7.Codes.V230
{
    /// <summary>
    /// HL7 Version 2 Table 0157 - Which Date/Time Status Qualifier.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0157</remarks>
    public enum CodeWhichDateTimeStatusQualifier
    {
        /// <summary>
        /// ANY - Any status.
        /// </summary>
        AnyStatus,

        /// <summary>
        /// CFN - Current final value, whether final or corrected.
        /// </summary>
        CurrentFinalValueWhetherFinalOrCorrected,

        /// <summary>
        /// COR - Corrected only (no final with corrections).
        /// </summary>
        CorrectedOnly,

        /// <summary>
        /// FIN - Final only (no corrections).
        /// </summary>
        FinalOnly,

        /// <summary>
        /// PRE - Preliminary.
        /// </summary>
        Preliminary,

        /// <summary>
        /// REP - Report completion date/time.
        /// </summary>
        ReportCompletionDateTime
    }
}
