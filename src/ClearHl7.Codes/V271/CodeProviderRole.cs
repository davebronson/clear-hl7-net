namespace ClearHl7.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0443 - Provider Role.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0443</remarks>
    public enum CodeProviderRole
    {
        /// <summary>
        /// AD - Admitting.
        /// </summary>
        Admitting,

        /// <summary>
        /// AI - Assistant/Alternate Interpreter.
        /// </summary>
        AssistantAlternateInterpreter,

        /// <summary>
        /// AP - Administering Provider.
        /// </summary>
        AdministeringProvider,

        /// <summary>
        /// AT - Attending.
        /// </summary>
        Attending,

        /// <summary>
        /// CLP - Collecting Provider.
        /// </summary>
        CollectingProvider,

        /// <summary>
        /// CP - Consulting Provider.
        /// </summary>
        ConsultingProvider,

        /// <summary>
        /// DP - Dispensing Provider.
        /// </summary>
        DispensingProvider,

        /// <summary>
        /// EP - Entering Provider (probably not the same as transcriptionist?).
        /// </summary>
        EnteringProvider,

        /// <summary>
        /// FHCP - Family Health Care Professional.
        /// </summary>
        FamilyHealthCareProfessional,

        /// <summary>
        /// IP - Initiating Provider (as in action by).
        /// </summary>
        InitiatingProviderAsInActionBy,

        /// <summary>
        /// MDIR - Medical Director.
        /// </summary>
        MedicalDirector,

        /// <summary>
        /// OP - Ordering Provider.
        /// </summary>
        OrderingProvider,

        /// <summary>
        /// PH - Pharmacist   (not sure how to dissect Pharmacist/Treatment Supplier's Verifier ID).
        /// </summary>
        Pharmacist,

        /// <summary>
        /// PI - Primary Interpreter.
        /// </summary>
        PrimaryInterpreter,

        /// <summary>
        /// PP - Primary Care Provider.
        /// </summary>
        PrimaryCareProvider,

        /// <summary>
        /// RO - Responsible Observer.
        /// </summary>
        ResponsibleObserver,

        /// <summary>
        /// RP - Referring Provider.
        /// </summary>
        ReferringProvider,

        /// <summary>
        /// RT - Referred to Provider.
        /// </summary>
        ReferredToProvider,

        /// <summary>
        /// TN - Technician.
        /// </summary>
        Technician,

        /// <summary>
        /// TR - Transcriptionist.
        /// </summary>
        Transcriptionist,

        /// <summary>
        /// VP - Verifying Provider.
        /// </summary>
        VerifyingProvider,

        /// <summary>
        /// VPS - Verifying Pharmaceutical Supplier   (not sure how to dissect Pharmacist/Treatment Supplier's Verifier ID).
        /// </summary>
        VerifyingPharmaceuticalSupplier,

        /// <summary>
        /// VTS - Verifying Treatment Supplier   (not sure how to dissect Pharmacist/Treatment Supplier's Verifier ID).
        /// </summary>
        VerifyingTreatmentSupplier
    }
}
