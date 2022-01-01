namespace ClearHl7.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0562 - Processing Consideration Codes.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0562</remarks>
    public enum CodeProcessingConsiderationCodes
    {
        /// <summary>
        /// DFADJ - Deferred Adjudication Processing.
        /// </summary>
        DeferredAdjudicationProcessing,

        /// <summary>
        /// EFORM - Electronic form to follow.
        /// </summary>
        ElectronicFormToFollow,

        /// <summary>
        /// FAX - Fax to follow.
        /// </summary>
        FaxToFollow,

        /// <summary>
        /// PAPER - Paper documentation to follow.
        /// </summary>
        PaperDocumentationToFollow,

        /// <summary>
        /// PYRDELAY - Delayed by a Previous Payer.
        /// </summary>
        DelayedByAPreviousPayer,

        /// <summary>
        /// RTADJ - Real Time Adjudication Processing.
        /// </summary>
        RealTimeAdjudicationProcessing
    }
}
