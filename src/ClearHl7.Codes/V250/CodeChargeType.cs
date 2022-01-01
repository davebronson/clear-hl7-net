namespace ClearHl7.Codes.V250
{
    /// <summary>
    /// HL7 Version 2 Table 0122 - Charge Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0122</remarks>
    public enum CodeChargeType
    {
        /// <summary>
        /// CH - Charge.
        /// </summary>
        Charge,

        /// <summary>
        /// CO - Contract.
        /// </summary>
        Contract,

        /// <summary>
        /// CR - Credit.
        /// </summary>
        Credit,

        /// <summary>
        /// DP - Department.
        /// </summary>
        Department,

        /// <summary>
        /// GR - Grant.
        /// </summary>
        Grant,

        /// <summary>
        /// NC - No Charge.
        /// </summary>
        NoCharge,

        /// <summary>
        /// PC - Professional.
        /// </summary>
        Professional,

        /// <summary>
        /// RS - Research.
        /// </summary>
        Research
    }
}
