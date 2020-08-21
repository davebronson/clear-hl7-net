using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 MO - Money.
    /// </summary>
    public class Money
    {
        /// <summary>
        /// MO.1 - Quantity.
        /// </summary>
        public decimal? Quantity { get; set; }

        /// <summary>
        /// MO.2 - Denomination.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0913</remarks>
        public string Denomination { get; set; }
    }
}
