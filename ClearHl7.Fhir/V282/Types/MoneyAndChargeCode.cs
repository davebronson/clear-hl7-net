using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 MOC - Money And Charge Code.
    /// </summary>
    public class MoneyAndChargeCode
    {
        /// <summary>
        /// MOC.1 - Monetary Amount.
        /// </summary>
        public Money MonetaryAmount { get; set; }

        /// <summary>
        /// MOC.2 - Charge Code.
        /// </summary>
        public CodedWithExceptions ChargeCode { get; set; }
    }
}
