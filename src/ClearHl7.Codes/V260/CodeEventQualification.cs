namespace ClearHl7.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0237 - Event Qualification.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0237</remarks>
    public enum CodeEventQualification
    {
        /// <summary>
        /// A - Abuse.
        /// </summary>
        Abuse,

        /// <summary>
        /// B - Unexpected beneficial effect.
        /// </summary>
        UnexpectedBeneficialEffect,

        /// <summary>
        /// D - Dependency.
        /// </summary>
        Dependency,

        /// <summary>
        /// I - Interaction.
        /// </summary>
        Interaction,

        /// <summary>
        /// L - Lack of expect therapeutic effect.
        /// </summary>
        LackOfExpectTherapeuticEffect,

        /// <summary>
        /// M - Misuse.
        /// </summary>
        Misuse,

        /// <summary>
        /// O - Overdose.
        /// </summary>
        Overdose,

        /// <summary>
        /// W - Drug withdrawal.
        /// </summary>
        DrugWithdrawal
    }
}
