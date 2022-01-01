namespace ClearHl7.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0436 - Sensitivity To Causative Agent Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0436</remarks>
    public enum CodeSensitivityToCausativeAgentCode
    {
        /// <summary>
        /// AD - Adverse Reaction (Not otherwise classified).
        /// </summary>
        AdverseReaction,

        /// <summary>
        /// AL - Allergy.
        /// </summary>
        Allergy,

        /// <summary>
        /// CT - Contraindication.
        /// </summary>
        Contraindication,

        /// <summary>
        /// IN - Intolerance.
        /// </summary>
        Intolerance,

        /// <summary>
        /// SE - Side Effect.
        /// </summary>
        SideEffect
    }
}
