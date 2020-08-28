using System;

namespace ClearHl7.Fhir.Codes.V251
{
    /// <summary>
    /// HL7 Version 2 Table 0534 - Notify Clergy Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0534</remarks>
    public enum NotifyClergyCode
    {
        /// <summary>
        /// L - Last Rites only.
        /// </summary>
        LastRitesOnly,
        
        /// <summary>
        /// N - No.
        /// </summary>
        No,
        
        /// <summary>
        /// O - Other.
        /// </summary>
        Other,
        
        /// <summary>
        /// U - Unknown.
        /// </summary>
        Unknown,
        
        /// <summary>
        /// Y - Yes.
        /// </summary>
        Yes
    }
}