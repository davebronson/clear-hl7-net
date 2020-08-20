using System;

namespace ClearHl7.Fhir.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0434 - Patient Condition Code.
    /// </summary>
    /// </remarks>https://www.hl7.org/fhir/v2/0434</remarks>
    public enum PatientConditionCode
    {
        /// <summary>
        /// A - Satisfactory.
        /// </summary>
        Satisfactory,
        
        /// <summary>
        /// C - Critical.
        /// </summary>
        Critical,
        
        /// <summary>
        /// O - Other.
        /// </summary>
        Other,
        
        /// <summary>
        /// P - Poor.
        /// </summary>
        Poor,
        
        /// <summary>
        /// S - Stable.
        /// </summary>
        Stable,
        
        /// <summary>
        /// U - Unknown.
        /// </summary>
        Unknown
    }
}