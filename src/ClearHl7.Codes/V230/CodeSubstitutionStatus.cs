namespace ClearHl7.Codes.V230
{
    /// <summary>
    /// HL7 Version 2 Table 0167 - Substitution Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0167</remarks>
    public enum CodeSubstitutionStatus
    {
        /// <summary>
        /// G - A generic substitution was dispensed.
        /// </summary>
        AGenericSubstitutionWasDispensed,

        /// <summary>
        /// N - No substitute was dispensed.  This is equivalent to the default (null) value.
        /// </summary>
        NoSubstituteWasDispensed,

        /// <summary>
        /// T - A therapeutic substitution was dispensed.
        /// </summary>
        TherapeuticSubstitutionWasDispensed
    }
}
