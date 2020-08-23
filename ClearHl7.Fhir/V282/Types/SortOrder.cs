using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 SRT - Sort Order.
    /// </summary>
    public class SortOrder
    {
        /// <summary>
        /// SRT.1 - Sort-by Field.
        /// </summary>
        public string SortByField { get; set; }

        /// <summary>
        /// SRT.2 - Sequencing.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0397</remarks>
        public string Sequencing { get; set; }
    }
}
