using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 FC - Financial Class.
    /// </summary>
    public class FinancialClass
    {
        /// <summary>
        /// FC.1 - Financial Class Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0064</remarks>
        public CodedWithExceptions FinancialClassCode { get; set; }

        /// <summary>
        /// FC.2 - Effective Date.
        /// </summary>
        public DateTime? EffectiveDate { get; set; }
    }
}
