using System;

namespace ClearHl7.Fhir.Codes.V220
{
    /// <summary>
    /// HL7 Version 2 Table 0007 - Admission Type.
    /// </summary>
    /// </remarks>https://www.hl7.org/fhir/v2/0007</remarks>
    public enum AdmissionType
    {
        /// <summary>
        /// A - Accident.
        /// </summary>
        Accident,
        
        /// <summary>
        /// E - Emergency.
        /// </summary>
        Emergency,
        
        /// <summary>
        /// L - Labor and Delivery.
        /// </summary>
        LaborAndDelivery,
        
        /// <summary>
        /// R - Routine.
        /// </summary>
        Routine
    }
}