using System;

namespace ClearHl7.Fhir.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0280 - Referral Priority.
    /// </summary>
    /// </remarks>https://www.hl7.org/fhir/v2/0280</remarks>
    public enum ReferralPriority
    {
        /// <summary>
        /// A - ASAP.
        /// </summary>
        Asap,
        
        /// <summary>
        /// R - Routine.
        /// </summary>
        Routine,
        
        /// <summary>
        /// S - STAT.
        /// </summary>
        Stat
    }
}