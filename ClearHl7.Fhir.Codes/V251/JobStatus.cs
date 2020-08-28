using System;

namespace ClearHl7.Fhir.Codes.V251
{
    /// <summary>
    /// HL7 Version 2 Table 0311 - Job Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0311</remarks>
    public enum JobStatus
    {
        /// <summary>
        /// O - Other.
        /// </summary>
        Other,
        
        /// <summary>
        /// P - Permanent.
        /// </summary>
        Permanent,
        
        /// <summary>
        /// T - Temporary.
        /// </summary>
        Temporary,
        
        /// <summary>
        /// U - Unknown.
        /// </summary>
        Unknown
    }
}