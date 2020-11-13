using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V250.Types;

namespace ClearHl7.Fhir.V250.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RCP - Response Control Parameter.
    /// </summary>
    public class RcpSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "RCP";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// RCP.1 - Query Priority.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0091</remarks>
        public string QueryPriority { get; set; }

        /// <summary>
        /// RCP.2 - Quantity Limited Request.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0126</remarks>
        public CompositeQuantityWithUnits QuantityLimitedRequest { get; set; }

        /// <summary>
        /// RCP.3 - Response Modality.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0394</remarks>
        public CodedElement ResponseModality { get; set; }

        /// <summary>
        /// RCP.4 - Execution and Delivery Time.
        /// </summary>
        public DateTime? ExecutionAndDeliveryTime { get; set; }

        /// <summary>
        /// RCP.5 - Modify Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0395</remarks>
        public string ModifyIndicator { get; set; }

        /// <summary>
        /// RCP.6 - Sort-by Field.
        /// </summary>
        public IEnumerable<SortOrder> SortByField { get; set; }

        /// <summary>
        /// RCP.7 - Segment group inclusion.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0391</remarks>
        public IEnumerable<string> SegmentGroupInclusion { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}",
                                Id,
                                QueryPriority,
                                QuantityLimitedRequest?.ToDelimitedString(),
                                ResponseModality?.ToDelimitedString(),
                                ExecutionAndDeliveryTime.HasValue ? ExecutionAndDeliveryTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ModifyIndicator,
                                SortByField != null ? string.Join("~", SortByField.Select(x => x.ToDelimitedString())) : null,
                                SegmentGroupInclusion != null ? string.Join("~", SegmentGroupInclusion) : null
                                ).TrimEnd('|');
        }
    }
}