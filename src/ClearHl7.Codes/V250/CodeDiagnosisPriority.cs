namespace ClearHl7.Codes.V250
{
    /// <summary>
    /// HL7 Version 2 Table 0359 - Diagnosis Priority.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0359</remarks>
    public enum CodeDiagnosisPriority
    {
        /// <summary>
        /// 0 - Not included in diagnosis ranking.
        /// </summary>
        NotIncludedInDiagnosisRanking,

        /// <summary>
        /// 1 - The primary diagnosis.
        /// </summary>
        ThePrimaryDiagnosis,

        /// <summary>
        /// 2 ... - For ranked secondary diagnoses.
        /// </summary>
        ForRankedSecondaryDiagnoses
    }
}
