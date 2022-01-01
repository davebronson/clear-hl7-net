namespace ClearHl7.Codes.V281
{
    /// <summary>
    /// HL7 Version 2 Table 0247 - Status Of Evaluation.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0247</remarks>
    public enum CodeStatusOfEvaluation
    {
        /// <summary>
        /// A - Evaluation anticipated, but not yet begun.
        /// </summary>
        EvaluationAnticipatedNotYetBegun,

        /// <summary>
        /// C - Product received in condition which made analysis impossible.
        /// </summary>
        ProductReceivedInConditionWhichMadeAnalysisImpossible,

        /// <summary>
        /// D - Product discarded -- unable to follow up.
        /// </summary>
        ProductDiscardedNoFollowUp,

        /// <summary>
        /// I - Product remains implanted -- unable to follow up.
        /// </summary>
        ProductRemainsImplantedNoFollowUp,

        /// <summary>
        /// K - Problem already known, no evaluation necessary.
        /// </summary>
        ProblemAlreadyKnownNoEvaluation,

        /// <summary>
        /// O - Other.
        /// </summary>
        Other,

        /// <summary>
        /// P - Evaluation in progress.
        /// </summary>
        EvaluationInProgress,

        /// <summary>
        /// Q - Product under quarantine -- unable to follow up.
        /// </summary>
        ProductUnderQuarantineNoFollowUp,

        /// <summary>
        /// R - Product under recall/corrective action.
        /// </summary>
        ProductUnderRecall,

        /// <summary>
        /// U - Product unavailable for follow up investigation.
        /// </summary>
        ProductUnavailableForFollowUp,

        /// <summary>
        /// X - Product not made by company.
        /// </summary>
        ProductNotMadeByCompany,

        /// <summary>
        /// Y - Evaluation completed.
        /// </summary>
        EvaluationCompleted
    }
}
