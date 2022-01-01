namespace ClearHl7.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0147 - Policy Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0147</remarks>
    public enum CodePolicyType
    {
        /// <summary>
        /// 2ANC - Second ancillary.
        /// </summary>
        SecondAncillary,

        /// <summary>
        /// 2MMD - Second major medical.
        /// </summary>
        SecondMajorMedical,

        /// <summary>
        /// 3MMD - Third major medical.
        /// </summary>
        ThirdMajorMedical,

        /// <summary>
        /// ANC - Ancillary.
        /// </summary>
        Ancillary,

        /// <summary>
        /// MMD - Major medical.
        /// </summary>
        MajorMedical
    }
}
