using System;

namespace ClearHl7.Fhir.Codes.V281
{
    /// <summary>
    /// HL7 Version 2 Table 0137 - Mail Claim Party.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0137</remarks>
    public enum MailClaimParty
    {
        /// <summary>
        /// E - Employer.
        /// </summary>
        Employer,
        
        /// <summary>
        /// G - Guarantor.
        /// </summary>
        Guarantor,
        
        /// <summary>
        /// I - Insurance company.
        /// </summary>
        InsuranceCompany,
        
        /// <summary>
        /// O - Other.
        /// </summary>
        Other,
        
        /// <summary>
        /// P - Patient.
        /// </summary>
        Patient
    }
}