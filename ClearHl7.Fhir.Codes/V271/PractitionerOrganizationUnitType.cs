using System;

namespace ClearHl7.Fhir.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0474 - Practitioner Organization Unit Type.
    /// </summary>
    /// </remarks>https://www.hl7.org/fhir/v2/0474</remarks>
    public enum PractitionerOrganizationUnitType
    {
        /// <summary>
        /// D - Department.
        /// </summary>
        Department,
        
        /// <summary>
        /// F - Facility.
        /// </summary>
        Facility,
        
        /// <summary>
        /// S - Subdivision.
        /// </summary>
        Subdivision,
        
        /// <summary>
        /// U - Subdepartment.
        /// </summary>
        Subdepartment,
        
        /// <summary>
        /// V - Division.
        /// </summary>
        Division
    }
}