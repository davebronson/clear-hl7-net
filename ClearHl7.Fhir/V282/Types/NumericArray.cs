using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 NA - Numeric Array.
    /// </summary>
    public class NumericArray
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// NA.1 - Value1.
        /// </summary>
        public decimal? Value1 { get; set; }

        /// <summary>
        /// NA.2 - Value2.
        /// </summary>
        public decimal? Value2 { get; set; }

        /// <summary>
        /// NA.3 - Value3.
        /// </summary>
        public decimal? Value3 { get; set; }

        /// <summary>
        /// NA.4 - Value4.
        /// </summary>
        public decimal? Value4 { get; set; }
    }
}
