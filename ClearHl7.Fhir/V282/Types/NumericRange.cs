using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 NR - Numeric Range.
    /// </summary>
    public class NumericRange
    {
        /// <summary>
        /// NR.1 - Low Value.
        /// </summary>
        public decimal? LowValue { get; set; }

        /// <summary>
        /// NR.2 - High Value.
        /// </summary>
        public decimal? HighValue { get; set; }
    }
}
