namespace ClearHl7.Codes.V231
{
    /// <summary>
    /// HL7 Version 2 Table 0282 - Referral Disposition.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0282</remarks>
    public enum CodeReferralDisposition
    {
        /// <summary>
        /// AM - Assume Management.
        /// </summary>
        AssumeManagement,

        /// <summary>
        /// RP - Return Patient After Evaluation.
        /// </summary>
        ReturnPatientAfterEvaluation,

        /// <summary>
        /// SO - Second Opinion.
        /// </summary>
        SecondOpinion,

        /// <summary>
        /// WR - Send Written Report.
        /// </summary>
        SendWrittenReport
    }
}
