using System;

namespace ClearHl7.Fhir.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0557 - Payee Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0557</remarks>
    public enum PayeeType
    {
        /// <summary>
        /// EMPL - Employer.
        /// </summary>
        Employer,
        
        /// <summary>
        /// ORG - Payee Organization.
        /// </summary>
        PayeeOrganization,
        
        /// <summary>
        /// PERS - Person.
        /// </summary>
        Person,
        
        /// <summary>
        /// PPER - Pay Person.
        /// </summary>
        PayPerson
    }
}