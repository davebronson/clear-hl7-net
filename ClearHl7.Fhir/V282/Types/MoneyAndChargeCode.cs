using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 MOC - Money And Charge Code.
    /// </summary>
    public class MoneyAndChargeCode
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

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
