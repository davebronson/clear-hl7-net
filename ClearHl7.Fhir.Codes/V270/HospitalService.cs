using System;

namespace ClearHl7.Fhir.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0069 - Hospital Service.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0069</remarks>
    public enum HospitalService
    {
        /// <summary>
        /// CAR - Cardiac Service.
        /// </summary>
        CardiacService,
        
        /// <summary>
        /// MED - Medical Service.
        /// </summary>
        MedicalService,
        
        /// <summary>
        /// PUL - Pulmonary Service.
        /// </summary>
        PulmonaryService,
        
        /// <summary>
        /// SUR - Surgical Service.
        /// </summary>
        SurgicalService,
        
        /// <summary>
        /// URO - Urology Service.
        /// </summary>
        UrologyService
    }
}