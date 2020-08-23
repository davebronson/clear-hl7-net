using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 SN - Structured Numeric.
    /// </summary>
    public class StructuredNumeric
    {
        /// <summary>
        /// SN.1 - Comparator.
        /// </summary>
        public string Comparator { get; set; }

        /// <summary>
        /// SN.2 - Num1.
        /// </summary>
        public decimal? Num1 { get; set; }

        /// <summary>
        /// SN.3 - Separator/Suffix.
        /// </summary>
        public string SeparatorSuffix { get; set; }

        /// <summary>
        /// SN.4 - Num2.
        /// </summary>
        public decimal? Num2 { get; set; }
    }
}
