using System;

namespace ClearHl7.Fhir.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0651 - Labor Calculation Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0651</remarks>
    public enum LaborCalculationType
    {
        /// <summary>
        /// CST - Cost.
        /// </summary>
        Cost,
        
        /// <summary>
        /// TME - Time.
        /// </summary>
        Time
    }
}