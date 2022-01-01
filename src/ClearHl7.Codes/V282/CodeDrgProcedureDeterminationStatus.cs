namespace ClearHl7.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0761 - DRG Procedure Determination Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0761</remarks>
    public enum CodeDrgProcedureDeterminationStatus
    {
        /// <summary>
        /// 0 - Valid code.
        /// </summary>
        ValidCode,

        /// <summary>
        /// 1 - Invalid code.
        /// </summary>
        InvalidCode,

        /// <summary>
        /// 2 - Not used.
        /// </summary>
        NotUsed,

        /// <summary>
        /// 3 - Invalid for this gender.
        /// </summary>
        InvalidForThisGender,

        /// <summary>
        /// 4 - Invalid for this age.
        /// </summary>
        InvalidForThisAge
    }
}
