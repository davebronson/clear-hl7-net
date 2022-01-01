namespace ClearHl7.Codes.V230
{
    /// <summary>
    /// HL7 Version 2 Table 0175 - Master File Identifier Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0175</remarks>
    public enum CodeMasterFileIdentifierCode
    {
        /// <summary>
        /// CDM - Charge description master file.
        /// </summary>
        ChargeDescriptionMasterFile,

        /// <summary>
        /// CM0 - Clinical study master.
        /// </summary>
        ClinicalStudyMaster,

        /// <summary>
        /// CM1 - Clinical study phase master.
        /// </summary>
        ClinicalStudyPhaseMaster,

        /// <summary>
        /// CM2 - Clinical study Data Schedule Master.
        /// </summary>
        ClinicalStudyDataScheduleMaster,

        /// <summary>
        /// LOC - Location master file.
        /// </summary>
        LocationMasterFile,

        /// <summary>
        /// OM1 - Observation text master file segments (e.g., Lab).
        /// </summary>
        OM1ObservationTextMasterFileSegments,

        /// <summary>
        /// OM1-OM6 - Observation text master file segments (e.g., Lab).
        /// </summary>
        OM1To6ObservationTextMasterFileSegments,

        /// <summary>
        /// OM2 - Observation text master file segments (e.g., Lab).
        /// </summary>
        OM2ObservationTextMasterFileSegments,

        /// <summary>
        /// OM3 - Observation text master file segments (e.g., Lab).
        /// </summary>
        OM3ObservationTextMasterFileSegments,

        /// <summary>
        /// OM4 - Observation text master file segments (e.g., Lab).
        /// </summary>
        OM4ObservationTextMasterFileSegments,

        /// <summary>
        /// OM5 - Observation text master file segments (e.g., Lab).
        /// </summary>
        OM5ObservationTextMasterFileSegments,

        /// <summary>
        /// OM6 - Observation text master file segments (e.g., Lab).
        /// </summary>
        OM6ObservationTextMasterFileSegments,

        /// <summary>
        /// PRA - Practitioner master file.
        /// </summary>
        PractitionerMasterFile,

        /// <summary>
        /// STF - Staff master file.
        /// </summary>
        StaffMasterFile
    }
}
