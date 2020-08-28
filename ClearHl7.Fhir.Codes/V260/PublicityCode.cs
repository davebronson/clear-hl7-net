using System;

namespace ClearHl7.Fhir.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0215 - Publicity Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0215</remarks>
    public enum PublicityCode
    {
        /// <summary>
        /// F - Family only.
        /// </summary>
        FamilyOnly,
        
        /// <summary>
        /// N - No Publicity.
        /// </summary>
        NoPublicity,
        
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