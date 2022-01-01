namespace ClearHl7.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0615 - User Authentication Credential Type Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0615</remarks>
    public enum CodeUserAuthenticationCredentialTypeCode
    {
        /// <summary>
        /// KERB - Kerberos Service Ticket.
        /// </summary>
        KerberosServiceTicket,

        /// <summary>
        /// SAML - Authenticated User Identity Assertion.
        /// </summary>
        AuthenticatedUserIdentityAssertion
    }
}
