using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 MOP - Money Or Percentage.
    /// </summary>
    public class MoneyOrPercentage
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// MOP.1 - Money or Percentage Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0148</remarks>
        public string MoneyOrPercentageIndicator { get; set; }

        /// <summary>
        /// MOP.2 - Money or Percentage Quantity.
        /// </summary>
        public decimal? MoneyOrPercentageQuantity { get; set; }

        /// <summary>
        /// MOP.3 - Monetary Denomination.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0913</remarks>
        public string MonetaryDenomination { get; set; }
    }
}
