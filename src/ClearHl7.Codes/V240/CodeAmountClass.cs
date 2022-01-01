namespace ClearHl7.Codes.V240
{
    /// <summary>
    /// HL7 Version 2 Table 0193 - Amount Class.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0193</remarks>
    public enum CodeAmountClass
    {
        /// <summary>
        /// AT - Amount.
        /// </summary>
        Amount,

        /// <summary>
        /// LM - Limit.
        /// </summary>
        Limit,

        /// <summary>
        /// PC - Percentage.
        /// </summary>
        Percentage,

        /// <summary>
        /// UL - Unlimited.
        /// </summary>
        Unlimited
    }
}
