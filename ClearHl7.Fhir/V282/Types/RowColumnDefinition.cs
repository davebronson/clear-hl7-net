using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 RCD - Row Column Definition.
    /// </summary>
    public class RowColumnDefinition
    {
        /// <summary>
        /// RCD.1 - Segment Field Name.
        /// </summary>
        public string SegmentFieldName { get; set; }

        /// <summary>
        /// RCD.2 - HL7 Data Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0440</remarks>
        public string Hl7DataType { get; set; }

        /// <summary>
        /// RCD.3 - Maximum Column Width.
        /// </summary>
        public decimal? MaximumColumnWidth { get; set; }
    }
}
