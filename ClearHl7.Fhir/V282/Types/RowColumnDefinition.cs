using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 RCD - Row Column Definition.
    /// </summary>
    public class RowColumnDefinition
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

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

        /// <summary>
        /// Returns a pipe-delimited representation of this instance. 
        /// </summary>
        /// <returns>A string.</returns>
        public string ToPipeString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                IsSubcomponent ? "{0}&{1}&{2}" : "{0}^{1}^{2}",
                                SegmentFieldName,
                                Hl7DataType,
                                MaximumColumnWidth.HasValue ? MaximumColumnWidth.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
