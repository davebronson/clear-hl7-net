namespace ClearHl7.Codes.V280
{
    /// <summary>
    /// HL7 Version 2 Table 0161 - Allow Substitution.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0161</remarks>
    public enum CodeAllowSubstitution
    {
        /// <summary>
        /// G - Allow generic substitutions.
        /// </summary>
        AllowGenericSubstitutions,

        /// <summary>
        /// N - Substitutions are NOT authorized.  (This is the default - null).
        /// </summary>
        SubstitutionsAreNotAuthorized,

        /// <summary>
        /// T - Allow therapeutic substitutions.
        /// </summary>
        AllowTherapeuticSubstitutions
    }
}
