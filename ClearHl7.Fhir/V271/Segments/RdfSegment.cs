using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V271.Types;

namespace ClearHl7.Fhir.V271.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RDF - Table Row Definition.
    /// </summary>
    public class RdfSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "RDF";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// RDF.1 - Number of Columns per Row.
        /// </summary>
        public decimal? NumberOfColumnsPerRow { get; set; }

        /// <summary>
        /// RDF.2 - Column Description.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0440</remarks>
        public IEnumerable<RowColumnDefinition> ColumnDescription { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}",
                                Id,
                                NumberOfColumnsPerRow.HasValue ? NumberOfColumnsPerRow.Value.ToString(Consts.NumericFormat, culture) : null,
                                ColumnDescription != null ? string.Join("~", ColumnDescription.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd('|');
        }
    }
}