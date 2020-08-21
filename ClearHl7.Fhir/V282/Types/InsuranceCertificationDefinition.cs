using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 ICD - Insurance Certification Definition.
    /// </summary>
    public class InsuranceCertificationDefinition
    {
        /// <summary>
        /// ICD.1 - Certification Patient Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0150</remarks>
        public CodedWithExceptions CertificationPatientType { get; set; }

        /// <summary>
        /// ICD.2 - Certification Required.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string CertificationRequired { get; set; }

        /// <summary>
        /// ICD.3 - Date/Time Certification Required.
        /// </summary>
        public DateTime DateTimeCertificationRequired { get; set; }
    }
}
