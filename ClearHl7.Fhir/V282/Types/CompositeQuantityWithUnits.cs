using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 CQ - Composite Quantity With Units.
    /// </summary>
    public class CompositeQuantityWithUnits
    {
        /// <summary>
        /// CQ.1 - Quantity.
        /// </summary>
        public decimal? Quantity { get; set; }

        /// <summary>
        /// CQ.2 - Units.
        /// </summary>  
        public CodedWithExceptions Units { get; set; }
    }
}
