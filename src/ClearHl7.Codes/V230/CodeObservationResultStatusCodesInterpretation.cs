namespace ClearHl7.Codes.V230
{
    /// <summary>
    /// HL7 Version 2 Table 0085 - Observation Result Status Codes Interpretation.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0085</remarks>
    public enum CodeObservationResultStatusCodesInterpretation
    {
        /// <summary>
        /// C - Record coming over is a correction and thus replaces a final result.
        /// </summary>
        RecordIsCorrection,

        /// <summary>
        /// D - Deletes the OBX record.
        /// </summary>
        DeletesTheObxRecord,

        /// <summary>
        /// F - Final results.
        /// </summary>
        FinalResults,

        /// <summary>
        /// I - Specimen in lab; results pending.
        /// </summary>
        SpecimenInLabResultsPending,

        /// <summary>
        /// P - Preliminary results.
        /// </summary>
        PreliminaryResults,

        /// <summary>
        /// R - Results entered -- not verified.
        /// </summary>
        ResultsEnteredNotVerified,

        /// <summary>
        /// S - Partial results. Deprecated. Retained only for backward compatibility as of V2.6.
        /// </summary>
        PartialResults,

        /// <summary>
        /// U - Results status change to final without retransmitting results already sent as 'preliminary.'  e.g., radiology changes status from preliminary to final.
        /// </summary>
        ResultsChangeToFinalWithoutRetransmit,

        /// <summary>
        /// X - Results cannot be obtained for this observation.
        /// </summary>
        ResultsCannotBeObtainedForThisObservation
    }
}
