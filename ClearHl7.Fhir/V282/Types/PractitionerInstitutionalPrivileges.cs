using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 PIP - Practitioner Institutional Privileges.
    /// </summary>
    public class PractitionerInstitutionalPrivileges
    {
        /// <summary>
        /// PIP.1 - Privilege.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0525</remarks>
        public CodedWithExceptions Privilege { get; set; }

        /// <summary>
        /// PIP.2 - Privilege Class.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0526</remarks>
        public CodedWithExceptions PrivilegeClass { get; set; }

        /// <summary>
        /// PIP.3 - Expiration Date.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// PIP.4 - Activation Date.
        /// </summary>
        public DateTime? ActivationDate { get; set; }

        /// <summary>
        /// PIP.5 - Facility.
        /// </summary>
        public EntityIdentifier Facility { get; set; }
    }
}
