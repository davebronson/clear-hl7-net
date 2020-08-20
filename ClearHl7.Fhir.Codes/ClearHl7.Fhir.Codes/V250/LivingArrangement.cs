using System;

namespace ClearHl7.Fhir.Codes.V250
{
    /// <summary>
    /// HL7 Version 2 Table 0220 - Living Arrangement.
    /// </summary>
    /// </remarks>https://www.hl7.org/fhir/v2/0220</remarks>
    public enum LivingArrangement
    {
        /// <summary>
        /// A - Alone.
        /// </summary>
        Alone,
        
        /// <summary>
        /// F - Family.
        /// </summary>
        Family,
        
        /// <summary>
        /// I - Institution.
        /// </summary>
        Institution,
        
        /// <summary>
        /// R - Relative.
        /// </summary>
        Relative,
        
        /// <summary>
        /// S - Spouse Only.
        /// </summary>
        SpouseOnly,
        
        /// <summary>
        /// U - Unknown.
        /// </summary>
        Unknown
    }
}