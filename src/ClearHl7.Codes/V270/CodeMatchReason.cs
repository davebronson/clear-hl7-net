namespace ClearHl7.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0392 - Match Reason.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0392</remarks>
    public enum CodeMatchReason
    {
        /// <summary>
        /// DB - Match on Date of Birth.
        /// </summary>
        MatchOnDateOfBirth,

        /// <summary>
        /// NA - Match on Name (Alpha Match).
        /// </summary>
        MatchOnNameAlphaMatch,

        /// <summary>
        /// NP - Match on Name (Phonetic Match).
        /// </summary>
        MatchOnNamePhoneticMatch,

        /// <summary>
        /// SS - Match on Social Security Number.
        /// </summary>
        MatchOnSocialSecurityNumber
    }
}
