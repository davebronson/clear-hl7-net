using System;

namespace ClearHl7.Fhir.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0062 - Event Reason.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0062</remarks>
    public enum EventReason
    {
        /// <summary>
        /// 01 - Patient request.
        /// </summary>
        PatientRequest,
        
        /// <summary>
        /// 02 - Physician/health practitioner order.
        /// </summary>
        PhysicianHealthPractitionerOrder,
        
        /// <summary>
        /// 03 - Census management.
        /// </summary>
        CensusManagement,
        
        /// <summary>
        /// O - Other.
        /// </summary>
        Other,
        
        /// <summary>
        /// U - Unknown.
        /// </summary>
        Unknown
    }
}