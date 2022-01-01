namespace ClearHl7.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0445 - Identity Reliability Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0445</remarks>
    public enum CodeIdentityReliabilityCode
    {
        /// <summary>
        /// AL - Patient/Person Name is an Alias.
        /// </summary>
        PatientPersonNameIsAnAlias,

        /// <summary>
        /// UA - Unknown/Default Address.
        /// </summary>
        UnknownDefaultAddress,

        /// <summary>
        /// UD - Unknown/Default Date of Birth.
        /// </summary>
        UnknownDefaultDateOfBirth,

        /// <summary>
        /// US - Unknown/Default Social Security Number.
        /// </summary>
        UnknownDefaultSocialSecurityNumber
    }
}
