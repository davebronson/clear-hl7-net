namespace ClearHl7.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0916 - Relevant Clinicial Information.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0916</remarks>
    public enum CodeRelevantClinicialInformation
    {
        /// <summary>
        /// F - Patient was fasting prior to the procedure.
        /// </summary>
        PatientWasFastingPrior,

        /// <summary>
        /// NF - The patient indicated they did not fast prior to the procedure.
        /// </summary>
        PatientIndicatedTheyDidNotFastPrior,

        /// <summary>
        /// NG - Not Given - Patient was not asked at the time of the procedure.
        /// </summary>
        PatientWasNotAsked
    }
}
