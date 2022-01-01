namespace ClearHl7.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0416 - Procedure DRG Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0416</remarks>
    public enum CodeProcedureDrgType
    {
        /// <summary>
        /// 1 - 1st non-Operative.
        /// </summary>
        FirstNonOperative,

        /// <summary>
        /// 2 - 2nd non-Operative.
        /// </summary>
        SecondNonOperative,

        /// <summary>
        /// 3 - Major Operative.
        /// </summary>
        MajorOperative,

        /// <summary>
        /// 4 - 2nd Operative.
        /// </summary>
        SecondOperative,

        /// <summary>
        /// 5 - 3rd Operative.
        /// </summary>
        ThirdOperative
    }
}
