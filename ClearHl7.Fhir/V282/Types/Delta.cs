using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 DLT - Delta.
    /// </summary>
    public class Delta
    {
        /// <summary>
        /// DLT.1 - Normal Range.
        /// </summary>
        public NumericRange NormalRange { get; set; }

        /// <summary>
        /// DLT.2 - Numeric Threshold.
        /// </summary>
        public decimal NumericThreshold { get; set; }

        /// <summary>
        /// DLT.3 - Change Computation.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0523</remarks>
        public string ChangeComputation { get; set; }

        /// <summary>
        /// DLT.4 - Days Retained.
        /// </summary>
        public decimal DaysRetained { get; set; }
    }
}
