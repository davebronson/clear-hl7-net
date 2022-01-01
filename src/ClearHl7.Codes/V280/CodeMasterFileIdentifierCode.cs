namespace ClearHl7.Codes.V280
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
        /// CLN - Clinic master file.
        /// </summary>
        ClinicMasterFile,

        /// <summary>
        /// CMA - Clinical study with phases and scheduled master file.
        /// </summary>
        ClinicalStudyWithPhasesAndScheduledMasterFile,

        /// <summary>
        /// CMB - Clinical study without phases but with scheduled master file.
        /// </summary>
        ClinicalStudyWithoutPhasesButWithScheduledMasterFile,

        /// <summary>
        /// INV - Inventory master file.
        /// </summary>
        InventoryMasterFile,

        /// <summary>
        /// LOC - Location master file.
        /// </summary>
        LocationMasterFile,

        /// <summary>
        /// OMA - Numerical observation master file.
        /// </summary>
        NumericalObservationMasterFile,

        /// <summary>
        /// OMB - Categorical observation master file.
        /// </summary>
        CategoricalObservationMasterFile,

        /// <summary>
        /// OMC - Observation batteries master file.
        /// </summary>
        ObservationBatteriesMasterFile,

        /// <summary>
        /// OMD - Calculated observations master file.
        /// </summary>
        CalculatedObservationsMasterFile,

        /// <summary>
        /// OME - Other Observation/Service Item master file.
        /// </summary>
        OtherObservationServiceItemMasterFile,

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
