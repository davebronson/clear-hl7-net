namespace ClearHl7.Codes.V280
{
    /// <summary>
    /// HL7 Version 2 Table 0511 - BP Observation Status Codes Interpretation.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0511</remarks>
    public enum CodeBpObservationStatusCodesInterpretation
    {
        /// <summary>
        /// C - Record coming over is a correction and thus replaces a final status.
        /// </summary>
        RecordComingOverIsCorrection,

        /// <summary>
        /// D - Deletes the BPX record.
        /// </summary>
        DeletesTheBpxRecord,

        /// <summary>
        /// F - Final status; Can only be changed with a corrected status.
        /// </summary>
        FinalStatus,

        /// <summary>
        /// O - Order detail description only (no status).
        /// </summary>
        OrderDetailDescriptionOnly,

        /// <summary>
        /// P - Preliminary status.
        /// </summary>
        PreliminaryStatus,

        /// <summary>
        /// W - Post original as wrong, e.g., transmitted for wrong patient.
        /// </summary>
        PostOriginalAsWrong
    }
}
