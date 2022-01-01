namespace ClearHl7.Codes.V260
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
        /// AT - Attending.
        /// </summary>
        Attending,

        /// <summary>
        /// CP - Consulting Provider.
        /// </summary>
        ConsultingProvider,

        /// <summary>
        /// FHCP - Family Health Care Professional.
        /// </summary>
        FamilyHealthCareProfessional,

        /// <summary>
        /// PI - Primary Interpreter.
        /// </summary>
        PrimaryInterpreter,

        /// <summary>
        /// PP - Primary Care Provider.
        /// </summary>
        PrimaryCareProvider,

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
        Transcriptionist
    }
}
