using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 CP - Composite Price.
    /// </summary>
    public class CompositePrice
    {
        /// <summary>
        /// CP.1 - Price.
        /// </summary>
        public Money Price { get; set; }

        /// <summary>
        /// CP.2 - Price Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0205</remarks>
        public string PriceType { get; set; }

        /// <summary>
        /// CP.3 - From Value.
        /// </summary>
        public decimal? FromValue { get; set; }

        /// <summary>
        /// CP.4 - To Value.
        /// </summary>
        public decimal? ToValue { get; set; }

        /// <summary>
        /// CP.5 - Range Units.
        /// </summary>
        public CodedWithExceptions RangeUnits { get; set; }

        /// <summary>
        /// CP.6 - Range Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0298</remarks>
        public string RangeType { get; set; }
    }
}
