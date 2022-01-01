namespace ClearHl7.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0338 - Practitioner ID Number Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0338</remarks>
    public enum CodePractitionerIdNumberType
    {
        /// <summary>
        /// CY - County number.
        /// </summary>
        CountyNumber,

        /// <summary>
        /// DEA - Drug Enforcement Agency no.
        /// </summary>
        DrugEnforcementAgencyNo,

        /// <summary>
        /// GL - General ledger number.
        /// </summary>
        GeneralLedgerNumber,

        /// <summary>
        /// L&amp;I - Labor and industries number.
        /// </summary>
        LaborAndIndustriesNumberDeprecated,

        /// <summary>
        /// LI - Labor and industries number.
        /// </summary>
        LaborAndIndustriesNumber,

        /// <summary>
        /// MCD - Medicaid number.
        /// </summary>
        MedicaidNumber,

        /// <summary>
        /// MCR - Medicare number.
        /// </summary>
        MedicareNumber,

        /// <summary>
        /// QA - QA number.
        /// </summary>
        QaNumber,

        /// <summary>
        /// SL - State license number.
        /// </summary>
        StateLicenseNumber,

        /// <summary>
        /// TAX - Tax ID number.
        /// </summary>
        TaxIdNumber,

        /// <summary>
        /// TRL - Training license number.
        /// </summary>
        TrainingLicenseNumber,

        /// <summary>
        /// UPIN - Unique physician ID no.
        /// </summary>
        UniquePhysicianIdNo
    }
}
