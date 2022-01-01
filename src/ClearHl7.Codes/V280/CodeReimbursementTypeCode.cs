namespace ClearHl7.Codes.V280
{
    /// <summary>
    /// HL7 Version 2 Table 0470 - Reimbursement Type Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0470</remarks>
    public enum CodeReimbursementTypeCode
    {
        /// <summary>
        /// Crnl - Corneal Tissue APC.
        /// </summary>
        CornealTissueApc,

        /// <summary>
        /// DME - Durable Medical Equipment.
        /// </summary>
        DurableMedicalEquipment,

        /// <summary>
        /// EPO - Epotein.
        /// </summary>
        Epotein,

        /// <summary>
        /// Lab - Clinical Laboratory APC.
        /// </summary>
        ClinicalLaboratoryApc,

        /// <summary>
        /// Mamm - Screening Mammography APC.
        /// </summary>
        ScreeningMammographyApc,

        /// <summary>
        /// NoPay - This APC is not paid.
        /// </summary>
        ThisApcIsNotPaid,

        /// <summary>
        /// OPPS - Outpatient Prospective Payment System.
        /// </summary>
        OutpatientProspectivePaymentSystem,

        /// <summary>
        /// PartH - Partial Hospitalization APC.
        /// </summary>
        PartialHospitalizationApc,

        /// <summary>
        /// Pckg - Packaged APC.
        /// </summary>
        PackagedApc,

        /// <summary>
        /// Thrpy - Therapy APC.
        /// </summary>
        TherapyApc
    }
}
