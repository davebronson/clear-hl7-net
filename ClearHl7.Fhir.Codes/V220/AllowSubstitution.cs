using System;

namespace ClearHl7.Fhir.Codes.V220
{
    /// <summary>
    /// HL7 Version 2 Table 0161 - Allow Substitution.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0161</remarks>
    public enum AllowSubstitution
    {
        /// <summary>
        /// G - Allow generic substitutions..
        /// </summary>
        AllowGenericSubstitutions,
        
        /// <summary>
        /// N - Substitutions are NOT authorized.  (This is the default - null.).
        /// </summary>
        SubstitutionsAreNotAuthorized,
        
        /// <summary>
        /// T - Allow therapeutic substitutions.
        /// </summary>
        AllowTherapeuticSubstitutions
    }
}