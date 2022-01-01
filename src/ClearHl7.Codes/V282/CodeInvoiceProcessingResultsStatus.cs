namespace ClearHl7.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0571 - Invoice Processing Results Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0571</remarks>
    public enum CodeInvoiceProcessingResultsStatus
    {
        /// <summary>
        /// ACK - Acknowledge.
        /// </summary>
        Acknowledge,

        /// <summary>
        /// ADJ - Adjudicated with Adjustments.
        /// </summary>
        AdjudicatedWithAdjustments,

        /// <summary>
        /// ADJSUB - Adjudicated as Submitted.
        /// </summary>
        AdjudicatedAsSubmitted,

        /// <summary>
        /// ADJZER - Adjudicated to Zero.
        /// </summary>
        AdjudicatedToZero,

        /// <summary>
        /// PAID - Paid.
        /// </summary>
        Paid,

        /// <summary>
        /// PEND - Pending.
        /// </summary>
        Pending,

        /// <summary>
        /// PRED - Pre-Determination.
        /// </summary>
        PreDetermination,

        /// <summary>
        /// REJECT - Reject.
        /// </summary>
        Reject
    }
}
