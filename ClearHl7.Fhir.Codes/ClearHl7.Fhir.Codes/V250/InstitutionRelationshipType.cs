using System;

namespace ClearHl7.Fhir.Codes.V250
{
    /// <summary>
    /// HL7 Version 2 Table 0538 - Institution Relationship Type.
    /// </summary>
    /// </remarks>https://www.hl7.org/fhir/v2/0538</remarks>
    public enum InstitutionRelationshipType
    {
        /// <summary>
        /// CON - Contractor.
        /// </summary>
        Contractor,
        
        /// <summary>
        /// CST - Consultant.
        /// </summary>
        Consultant,
        
        /// <summary>
        /// EMP - Employee.
        /// </summary>
        Employee,
        
        /// <summary>
        /// VOL - Volunteer.
        /// </summary>
        Volunteer
    }
}