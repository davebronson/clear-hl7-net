using System;

namespace ClearHl7.Fhir.Codes.V251
{
    /// <summary>
    /// HL7 Version 2 Table 0170 - Derived Specimen.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0170</remarks>
    public enum DerivedSpecimen
    {
        /// <summary>
        /// C - Child Observation.
        /// </summary>
        ChildObservation,
        
        /// <summary>
        /// N - Not Applicable.
        /// </summary>
        NotApplicable,
        
        /// <summary>
        /// P - Parent Observation.
        /// </summary>
        ParentObservation
    }
}