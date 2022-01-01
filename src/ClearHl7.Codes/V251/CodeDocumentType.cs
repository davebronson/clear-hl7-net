namespace ClearHl7.Codes.V251
{
    /// <summary>
    /// HL7 Version 2 Table 0270 - Document Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0270</remarks>
    public enum CodeDocumentType
    {
        /// <summary>
        /// AR - Autopsy report.
        /// </summary>
        AutopsyReport,

        /// <summary>
        /// CD - Cardiodiagnostics.
        /// </summary>
        Cardiodiagnostics,

        /// <summary>
        /// CN - Consultation.
        /// </summary>
        Consultation,

        /// <summary>
        /// DI - Diagnostic imaging.
        /// </summary>
        DiagnosticImaging,

        /// <summary>
        /// DS - Discharge summary.
        /// </summary>
        DischargeSummary,

        /// <summary>
        /// ED - Emergency department report.
        /// </summary>
        EmergencyDepartmentReport,

        /// <summary>
        /// HP - History and physical examination.
        /// </summary>
        HistoryAndPhysicalExamination,

        /// <summary>
        /// OP - Operative report.
        /// </summary>
        OperativeReport,

        /// <summary>
        /// PC - Psychiatric consultation.
        /// </summary>
        PsychiatricConsultation,

        /// <summary>
        /// PH - Psychiatric history and physical examination.
        /// </summary>
        PsychiatricHistoryAndPhysicalExamination,

        /// <summary>
        /// PN - Procedure note.
        /// </summary>
        ProcedureNote,

        /// <summary>
        /// PR - Progress note.
        /// </summary>
        ProgressNote,

        /// <summary>
        /// SP - Surgical pathology.
        /// </summary>
        SurgicalPathology,

        /// <summary>
        /// TS - Transfer summary.
        /// </summary>
        TransferSummary
    }
}
