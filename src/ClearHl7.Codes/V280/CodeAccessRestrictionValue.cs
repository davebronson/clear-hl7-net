namespace ClearHl7.Codes.V280
{
    /// <summary>
    /// HL7 Version 2 Table 0717 - Access Restriction Value.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0717</remarks>
    public enum CodeAccessRestrictionValue
    {
        /// <summary>
        /// ALL - All.
        /// </summary>
        All,

        /// <summary>
        /// DEM - All demographic data.
        /// </summary>
        AllDemographicData,

        /// <summary>
        /// DRG - Drug.
        /// </summary>
        Drug,

        /// <summary>
        /// HIV - HIV status and results.
        /// </summary>
        HivStatusAndResults,

        /// <summary>
        /// LOC - Patient Location.
        /// </summary>
        PatientLocation,

        /// <summary>
        /// NO - None.
        /// </summary>
        None,

        /// <summary>
        /// OI - Opt in all registries (HIPAA).
        /// </summary>
        OptInAllRegistriesHipaa,

        /// <summary>
        /// OO - Opt out all registries (HIPAA).
        /// </summary>
        OptOutAllRegistriesHipaa,

        /// <summary>
        /// PID-17 - Religion.
        /// </summary>
        Religion,

        /// <summary>
        /// PID-7 - Date of Birth.
        /// </summary>
        DateOfBirth,

        /// <summary>
        /// PSY - Psychiatric Mental health.
        /// </summary>
        PsychiatricMentalHealth,

        /// <summary>
        /// SMD - Sensitive medical data.
        /// </summary>
        SensitiveMedicalData,

        /// <summary>
        /// STD - Sexually transmitted diseases.
        /// </summary>
        SexuallyTransmittedDiseases
    }
}
