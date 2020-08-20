using System;

namespace ClearHl7.Fhir.Codes.V210
{
    /// <summary>
    /// HL7 Version 2 Table 0123 - Result Status.
    /// </summary>
    /// </remarks>https://www.hl7.org/fhir/v2/0123</remarks>
    public enum ResultStatus
    {
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
        /// Y - No order on record for this test.
        /// </summary>
        NoOrderOnRecordForThisTest,
        
        /// <summary>
        /// Z - No record of this patient.
        /// </summary>
        NoRecordOfThisPatient
    }
}