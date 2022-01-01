namespace ClearHl7.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0719 - Access Restriction Reason Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0719</remarks>
    public enum CodeAccessRestrictionReasonCode
    {
        /// <summary>
        /// DIA - Diagnosis-related.
        /// </summary>
        DiagnosisRelated,

        /// <summary>
        /// EMP - Employee of this organization.
        /// </summary>
        EmployeeOfThisOrganization,

        /// <summary>
        /// ORG - Organizational policy or requirement.
        /// </summary>
        OrganizationalPolicyOrRequirement,

        /// <summary>
        /// PAT - Patient Request.
        /// </summary>
        PatientRequest,

        /// <summary>
        /// PHY - Physician Request.
        /// </summary>
        PhysicianRequest,

        /// <summary>
        /// REG - Regulatory requirement.
        /// </summary>
        RegulatoryRequirement,

        /// <summary>
        /// VIP - Very important person or celebrity.
        /// </summary>
        VeryImportantPersonOrCelebrity
    }
}
