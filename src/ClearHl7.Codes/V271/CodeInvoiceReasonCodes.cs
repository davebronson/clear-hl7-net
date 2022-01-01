namespace ClearHl7.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0554 - Invoice Reason Codes.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0554</remarks>
    public enum CodeInvoiceReasonCodes
    {
        /// <summary>
        /// LATE - Late Invoice.
        /// </summary>
        LateInvoice,

        /// <summary>
        /// NORM - Normal submission.
        /// </summary>
        NormalSubmission,

        /// <summary>
        /// SUB - Subscriber coverage problem.
        /// </summary>
        SubscriberCoverageProblem
    }
}
