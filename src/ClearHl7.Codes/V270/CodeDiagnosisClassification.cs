namespace ClearHl7.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0228 - Diagnosis Classification.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0228</remarks>
    public enum CodeDiagnosisClassification
    {
        /// <summary>
        /// C - Consultation.
        /// </summary>
        Consultation,

        /// <summary>
        /// D - Diagnosis.
        /// </summary>
        Diagnosis,

        /// <summary>
        /// I - Invasive procedure not classified elsewhere (I.V., catheter, etc.).
        /// </summary>
        InvasiveProcedureNotClassified,

        /// <summary>
        /// M - Medication (antibiotic).
        /// </summary>
        MedicationAntibiotic,

        /// <summary>
        /// O - Other.
        /// </summary>
        Other,

        /// <summary>
        /// R - Radiological scheduling (not using ICDA codes).
        /// </summary>
        RadiologicalScheduling,

        /// <summary>
        /// S - Sign and symptom.
        /// </summary>
        SignAndSymptom,

        /// <summary>
        /// T - Tissue diagnosis.
        /// </summary>
        TissueDiagnosis
    }
}
