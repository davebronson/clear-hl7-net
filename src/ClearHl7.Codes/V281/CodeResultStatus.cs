namespace ClearHl7.Codes.V281
{
    /// <summary>
    /// HL7 Version 2 Table 0123 - Result Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0123</remarks>
    public enum CodeResultStatus
    {
        /// <summary>
        /// A - Some, but not all, results available.
        /// </summary>
        SomeResultsAvailable,

        /// <summary>
        /// C - Corrected, final.
        /// </summary>
        CorrectedFinal,

        /// <summary>
        /// F - Final results.
        /// </summary>
        FinalResults,

        /// <summary>
        /// I - No results available; specimen received, procedure incomplete.
        /// </summary>
        NoResultsAvailableSpecimenReceivedProcedureIncomplete,

        /// <summary>
        /// O - Order received; specimen not yet received.
        /// </summary>
        OrderReceivedSpecimenNotYetReceived,

        /// <summary>
        /// P - Preliminary.
        /// </summary>
        Preliminary,

        /// <summary>
        /// R - Results stored; not yet verified.
        /// </summary>
        ResultsStoredNotYetVerified,

        /// <summary>
        /// S - No results available; procedure scheduled, but not done.
        /// </summary>
        NoResultsAvailableProcedureScheduledButNotDone,

        /// <summary>
        /// X - No results available; Order canceled.
        /// </summary>
        NoResultsAvailableOrderCanceled,

        /// <summary>
        /// Y - No order on record for this test.
        /// </summary>
        NoOrderOnRecordForThisTest,

        /// <summary>
        /// Z - No record of this patient.
        /// </summary>
        NoRecordOfThisPatient
    }
}
