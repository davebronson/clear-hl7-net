using System;

namespace ClearHl7.Fhir.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0728 - CCL Value.
    /// </summary>
    /// </remarks>https://www.hl7.org/fhir/v2/0728</remarks>
    public enum CclValue
    {
        /// <summary>
        /// 0 - Nothing obvious.
        /// </summary>
        NothingObvious,
        
        /// <summary>
        /// 1 - Low.
        /// </summary>
        Low,
        
        /// <summary>
        /// 2 - Moderate.
        /// </summary>
        Moderate,
        
        /// <summary>
        /// 3 - High.
        /// </summary>
        High,
        
        /// <summary>
        /// 4 - Very high.
        /// </summary>
        VeryHigh
    }
}