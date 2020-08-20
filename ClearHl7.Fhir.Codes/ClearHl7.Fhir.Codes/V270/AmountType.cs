using System;

namespace ClearHl7.Fhir.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0146 - Amount Type.
    /// </summary>
    /// </remarks>https://www.hl7.org/fhir/v2/0146</remarks>
    public enum AmountType
    {
        /// <summary>
        /// DF - Differential.
        /// </summary>
        Differential,
        
        /// <summary>
        /// LM - Limit.
        /// </summary>
        Limit,
        
        /// <summary>
        /// PC - Percentage.
        /// </summary>
        Percentage,
        
        /// <summary>
        /// RT - Rate.
        /// </summary>
        Rate,
        
        /// <summary>
        /// UL - Unlimited.
        /// </summary>
        Unlimited
    }
}