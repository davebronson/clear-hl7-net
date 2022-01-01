namespace ClearHl7.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0144 - Eligibility Source.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0144</remarks>
    public enum CodeEligibilitySource
    {
        /// <summary>
        /// 1 - Insurance company.
        /// </summary>
        InsuranceCompany,

        /// <summary>
        /// 2 - Employer.
        /// </summary>
        Employer,

        /// <summary>
        /// 3 - Insured presented policy.
        /// </summary>
        InsuredPresentedPolicy,

        /// <summary>
        /// 4 - Insured presented card.
        /// </summary>
        InsuredPresentedCard,

        /// <summary>
        /// 5 - Signed statement on file.
        /// </summary>
        SignedStatementOnFile,

        /// <summary>
        /// 6 - Verbal information.
        /// </summary>
        VerbalInformation,

        /// <summary>
        /// 7 - None.
        /// </summary>
        None
    }
}
