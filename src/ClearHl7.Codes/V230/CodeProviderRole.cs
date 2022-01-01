namespace ClearHl7.Codes.V230
{
    /// <summary>
    /// HL7 Version 2 Table 0286 - Provider Role.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0286</remarks>
    public enum CodeProviderRole
    {
        /// <summary>
        /// CP - Consulting Provider.
        /// </summary>
        ConsultingProvider,

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
