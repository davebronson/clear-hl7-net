using System;

namespace ClearHl7.Fhir.Codes.V230
{
    /// <summary>
    /// HL7 Version 2 Table 0269 - Charge On Indicator.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0269</remarks>
    public enum ChargeOnIndicator
    {
        /// <summary>
        /// O - Charge on Order.
        /// </summary>
        ChargeOnOrder,
        
        /// <summary>
        /// R - Charge on Result.
        /// </summary>
        ChargeOnResult
    }
}