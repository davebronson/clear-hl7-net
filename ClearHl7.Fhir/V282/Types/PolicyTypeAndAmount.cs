using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 PTA - Policy Type And Amount.
    /// </summary>
    public class PolicyTypeAndAmount
    {
        /// <summary>
        /// PTA.1 - Policy Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0147</remarks>
        public CodedWithExceptions PolicyType { get; set; }

        /// <summary>
        /// PTA.2 - Amount Class.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0193</remarks>
        public CodedWithExceptions AmountClass { get; set; }

        /// <summary>
        /// PTA.3 - Money or Percentage Quantity.
        /// </summary>
        public decimal? MoneyOrPercentageQuantity { get; set; }

        /// <summary>
        /// PTA.4 - Money or Percentage.
        /// </summary>
        public MoneyOrPercentage MoneyOrPercentage { get; set; }
    }
}
