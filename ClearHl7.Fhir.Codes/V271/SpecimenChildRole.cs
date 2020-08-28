using System;

namespace ClearHl7.Fhir.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0494 - Specimen Child Role.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0494</remarks>
    public enum SpecimenChildRole
    {
        /// <summary>
        /// A - Aliquot.
        /// </summary>
        Aliquot,
        
        /// <summary>
        /// C - Component.
        /// </summary>
        Component,
        
        /// <summary>
        /// M - Modified from original specimen.
        /// </summary>
        ModifiedFromOriginalSpecimen
    }
}