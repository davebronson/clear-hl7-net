namespace ClearHl7.Codes.V240
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
        ReferredToProvider
    }
}
