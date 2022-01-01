namespace ClearHl7.Codes.V270
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
        /// N - Not asked; used to affirmatively document that the observation identified in the OBX was not sought when the universal service ID in OBR-4 implies that it would be sought.
        /// </summary>
        NotAsked,

        /// <summary>
        /// O - Order detail description only (no result).
        /// </summary>
        OrderDetailDescription,

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
        /// W - Post original as wrong, e.g., transmitted for wrong patient.
        /// </summary>
        PostOriginalAsWrongEGTransmittedForWrongPatient,

        /// <summary>
        /// X - Results cannot be obtained for this observation.
        /// </summary>
        ResultsCannotBeObtainedForThisObservation
    }
}
