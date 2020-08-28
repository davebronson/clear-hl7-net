using System;

namespace ClearHl7.Fhir.Codes.V231
{
    /// <summary>
    /// HL7 Version 2 Table 0150 - Certification Patient Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0150</remarks>
    public enum CertificationPatientType
    {
        /// <summary>
        /// ER - Emergency.
        /// </summary>
        Emergency,
        
        /// <summary>
        /// IPE - Inpatient elective.
        /// </summary>
        InpatientElective,
        
        /// <summary>
        /// OPE - Outpatient elective.
        /// </summary>
        OutpatientElective,
        
        /// <summary>
        /// UR - Urgent.
        /// </summary>
        Urgent
    }
}