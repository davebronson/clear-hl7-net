namespace ClearHl7.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0478 - Formulary Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0478</remarks>
    public enum CodeFormularyStatus
    {
        /// <summary>
        /// G - Pharmaceutical substance is in the formulary, but guidelines apply.
        /// </summary>
        PharmaceuticalSubstanceIsInFormularyButGuidelinesApply,

        /// <summary>
        /// N - Pharmaceutical substance is NOT in the formulary.
        /// </summary>
        PharmaceuticalSubstanceIsNotInFormulary,

        /// <summary>
        /// R - Pharmaceutical substance is in the formulary, but restrictions apply.
        /// </summary>
        PharmaceuticalSubstanceIsInFormularyButRestrictionsApply,

        /// <summary>
        /// Y - Pharmaceutical substance is in the formulary.
        /// </summary>
        PharmaceuticalSubstanceIsInFormulary
    }
}
