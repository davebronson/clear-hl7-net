namespace ClearHl7.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0235 - Report Source.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0235</remarks>
    public enum CodeReportSource
    {
        /// <summary>
        /// C - Clinical trial.
        /// </summary>
        ClinicalTrial,

        /// <summary>
        /// D - Database/registry/poison control center.
        /// </summary>
        DatabaseRegistryPoisonControlCenter,

        /// <summary>
        /// E - Distributor.
        /// </summary>
        Distributor,

        /// <summary>
        /// H - Health professional.
        /// </summary>
        HealthProfessional,

        /// <summary>
        /// L - Literature.
        /// </summary>
        Literature,

        /// <summary>
        /// M - Manufacturer/marketing authority holder.
        /// </summary>
        ManufacturerMarketingAuthorityHolder,

        /// <summary>
        /// N - Non-healthcare professional.
        /// </summary>
        NonHealthcareProfessional,

        /// <summary>
        /// O - Other.
        /// </summary>
        Other,

        /// <summary>
        /// P - Patient.
        /// </summary>
        Patient,

        /// <summary>
        /// R - Regulatory agency.
        /// </summary>
        RegulatoryAgency
    }
}
