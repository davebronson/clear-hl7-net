namespace ClearHl7.Codes.V251
{
    /// <summary>
    /// HL7 Version 2 Table 0502 - Non-Subject Consenter Reason.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0502</remarks>
    public enum CodeNonSubjectConsenterReason
    {
        /// <summary>
        /// LM - Legally mandated.
        /// </summary>
        LegallyMandated,

        /// <summary>
        /// MIN - Subject is a minor.
        /// </summary>
        SubjectIsAMinor,

        /// <summary>
        /// NC - Subject is not competent to consent.
        /// </summary>
        SubjectIsNotCompetentToConsent
    }
}
