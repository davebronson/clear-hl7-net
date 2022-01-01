namespace ClearHl7.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0912 - Participation.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0912</remarks>
    public enum CodeParticipation
    {
        /// <summary>
        /// AD - Admitting Provider.
        /// </summary>
        AdmittingProvider,

        /// <summary>
        /// AI - Assistant/Alternate Interpreter.
        /// </summary>
        AssistantAlternateInterpreter,

        /// <summary>
        /// AP - Administering Provider.
        /// </summary>
        AdministeringProvider,

        /// <summary>
        /// ARI - Assistant Result Interpreter.
        /// </summary>
        AssistantResultInterpreter,

        /// <summary>
        /// AT - Attending Provider.
        /// </summary>
        AttendingProvider,

        /// <summary>
        /// AUT - Author/Event Initiator.
        /// </summary>
        AuthorEventInitiator,

        /// <summary>
        /// CP - Consulting Provider.
        /// </summary>
        ConsultingProvider,

        /// <summary>
        /// DP - Dispensing Provider.
        /// </summary>
        DispensingProvider,

        /// <summary>
        /// EP - Entering Person.
        /// </summary>
        EnteringPerson,

        /// <summary>
        /// EQUIP - Equipment.
        /// </summary>
        Equipment,

        /// <summary>
        /// FHCP - Family Health Care Professional.
        /// </summary>
        FamilyHealthCareProfessional,

        /// <summary>
        /// MDIR - Medical Director.
        /// </summary>
        MedicalDirector,

        /// <summary>
        /// OP - Ordering Provider.
        /// </summary>
        OrderingProvider,

        /// <summary>
        /// PB - Packed by.
        /// </summary>
        PackedBy,

        /// <summary>
        /// PH - Pharmacist.
        /// </summary>
        Pharmacist,

        /// <summary>
        /// PI - Primary Interpreter.
        /// </summary>
        PrimaryInterpreter,

        /// <summary>
        /// PO - Performing Organization.
        /// </summary>
        PerformingOrganization,

        /// <summary>
        /// POMD - Performing Organization Medical Director.
        /// </summary>
        PerformingOrganizationMedicalDirector,

        /// <summary>
        /// PP - Primary Care Provider.
        /// </summary>
        PrimaryCareProvider,

        /// <summary>
        /// PRI - Principal Result Interpreter.
        /// </summary>
        PrincipalResultInterpreter,

        /// <summary>
        /// RCT - Results Copies To.
        /// </summary>
        ResultsCopiesTo,

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
        /// SB - Send by.
        /// </summary>
        SendBy,

        /// <summary>
        /// SC - Specimen Collector.
        /// </summary>
        SpecimenCollector,

        /// <summary>
        /// TN - Technician.
        /// </summary>
        Technician,

        /// <summary>
        /// TR - Transcriptionist.
        /// </summary>
        Transcriptionist,

        /// <summary>
        /// VP - Verifier (Verifying Person).
        /// </summary>
        VerifierVerifyingPerson,

        /// <summary>
        /// VPS - Verifying Pharmaceutical Supplier   (not sure how to dissect Pharmacist/Treatment Supplier's Verifier ID).
        /// </summary>
        VerifyingPharmaceuticalSupplier,

        /// <summary>
        /// VTS - Verifying Treatment Supplier   (not sure how to dissect Pharmacist/Treatment Supplier's Verifier ID).
        /// </summary>
        VerifyingTreatmentSupplier,

        /// <summary>
        /// WAY - Waypoint.
        /// </summary>
        Waypoint,

        /// <summary>
        /// WAYR - Waypoint Recipient.
        /// </summary>
        WaypointRecipient
    }
}
