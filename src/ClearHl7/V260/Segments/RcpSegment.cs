using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
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
        /// <para>Suggested: 0091 Query Priority -&gt; ClearHl7.Codes.V260.CodeQueryPriority</para>
        /// </summary>
        public string QueryPriority { get; set; }

        /// <summary>
        /// RCP.2 - Quantity Limited Request.
        /// <para>Suggested: 0126 Quantity Limited Request -&gt; ClearHl7.Codes.V260.CodeQuantityLimitedRequest</para>
        /// </summary>
        public CompositeQuantityWithUnits QuantityLimitedRequest { get; set; }

        /// <summary>
        /// RCP.3 - Response Modality.
        /// <para>Suggested: 0394 Response Modality -&gt; ClearHl7.Codes.V260.CodeResponseModality</para>
        /// </summary>
        public CodedWithNoExceptions ResponseModality { get; set; }

        /// <summary>
        /// RCP.4 - Execution and Delivery Time.
        /// </summary>
        public DateTime? ExecutionAndDeliveryTime { get; set; }

        /// <summary>
        /// RCP.5 - Modify Indicator.
        /// <para>Suggested: 0395 Modify Indicator -&gt; ClearHl7.Codes.V260.CodeModifyIndicator</para>
        /// </summary>
        public string ModifyIndicator { get; set; }

        /// <summary>
        /// RCP.6 - Sort-by Field.
        /// </summary>
        public IEnumerable<SortOrder> SortByField { get; set; }

        /// <summary>
        /// RCP.7 - Segment group inclusion.
        /// <para>Suggested: 0391 Segment Group -&gt; ClearHl7.Codes.V260.CodeSegmentGroup</para>
        /// </summary>
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
                                StringHelper.StringFormatSequence(0, 8, Configuration.FieldSeparator),
                                Id,
                                QueryPriority,
                                QuantityLimitedRequest?.ToDelimitedString(),
                                ResponseModality?.ToDelimitedString(),
                                ExecutionAndDeliveryTime.HasValue ? ExecutionAndDeliveryTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ModifyIndicator,
                                SortByField != null ? string.Join(Configuration.FieldRepeatSeparator, SortByField.Select(x => x.ToDelimitedString())) : null,
                                SegmentGroupInclusion != null ? string.Join(Configuration.FieldRepeatSeparator, SegmentGroupInclusion) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}