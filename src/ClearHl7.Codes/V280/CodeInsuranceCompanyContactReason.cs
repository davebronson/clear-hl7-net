namespace ClearHl7.Codes.V280
{
    /// <summary>
    /// HL7 Version 2 Table 0232 - Insurance Company Contact Reason.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0232</remarks>
    public enum CodeInsuranceCompanyContactReason
    {
        /// <summary>
        /// 01 - Medicare claim status.
        /// </summary>
        MedicareClaimStatus,

        /// <summary>
        /// 02 - Medicaid claim status.
        /// </summary>
        MedicaidClaimStatus,

        /// <summary>
        /// 03 - Name/address change.
        /// </summary>
        NameAddressChange
    }
}
