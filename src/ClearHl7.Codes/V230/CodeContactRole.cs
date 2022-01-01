namespace ClearHl7.Codes.V230
{
    /// <summary>
    /// HL7 Version 2 Table 0131 - Contact Role.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0131</remarks>
    public enum CodeContactRole
    {
        /// <summary>
        /// BP - Billing contact person.
        /// </summary>
        BillingContactPerson,

        /// <summary>
        /// CP - Contact person.
        /// </summary>
        ContactPerson,

        /// <summary>
        /// EP - Emergency contact person.
        /// </summary>
        EmergencyContactPerson,

        /// <summary>
        /// PR - Person preparing referral.
        /// </summary>
        PersonPreparingReferral
    }
}
