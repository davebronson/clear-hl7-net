namespace ClearHl7.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0731 - DRG Diagnosis Determination Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0731</remarks>
    public enum CodeDrgDiagnosisDeterminationStatus
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
        /// 2 - Two primary diagnosis codes.
        /// </summary>
        TwoPrimaryDiagnosisCodes,

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
