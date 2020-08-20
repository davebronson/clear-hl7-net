using System;

namespace ClearHl7.Fhir.Codes.V280
{
    /// <summary>
    /// HL7 Version 2 Table 0223 - Living Dependency.
    /// </summary>
    /// </remarks>https://www.hl7.org/fhir/v2/0223</remarks>
    public enum LivingDependency
    {
        /// <summary>
        /// C - Small Children Dependent.
        /// </summary>
        SmallChildrenDependent,
        
        /// <summary>
        /// M - Medical Supervision Required.
        /// </summary>
        MedicalSupervisionRequired,
        
        /// <summary>
        /// O - Other.
        /// </summary>
        Other,
        
        /// <summary>
        /// S - Spouse Dependent.
        /// </summary>
        SpouseDependent,
        
        /// <summary>
        /// U - Unknown.
        /// </summary>
        Unknown
    }
}