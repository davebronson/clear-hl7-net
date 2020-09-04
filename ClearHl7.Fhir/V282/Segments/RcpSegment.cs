using System;

namespace ClearHl7.Fhir.V282.Segments
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

        ///// <summary>
        ///// RCP.1 - Query Priority.
        ///// </summary>
        //public QueryPriority { get; set; }

        ///// <summary>
        ///// RCP.2 - Quantity Limited Request.
        ///// </summary>
        //public QuantityLimitedRequest { get; set; }

        ///// <summary>
        ///// RCP.3 - Response Modality.
        ///// </summary>
        //public ResponseModality { get; set; }

        ///// <summary>
        ///// RCP.4 - Execution and Delivery Time.
        ///// </summary>
        //public ExecutionAndDeliveryTime { get; set; }

        ///// <summary>
        ///// RCP.5 - Modify Indicator.
        ///// </summary>
        //public ModifyIndicator { get; set; }

        ///// <summary>
        ///// RCP.6 - Sort-by Field.
        ///// </summary>
        //public SortByField { get; set; }

        ///// <summary>
        ///// RCP.7 - Segment group inclusion.
        ///// </summary>
        //public SegmentGroupInclusion { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}"
                                ).TrimEnd('|');
        }
    }
}