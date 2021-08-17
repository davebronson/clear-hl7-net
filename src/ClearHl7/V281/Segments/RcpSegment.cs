using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
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
        /// <para>Suggested: 0091 Query Priority -&gt; ClearHl7.Codes.V281.CodeQueryPriority</para>
        /// </summary>
        public string QueryPriority { get; set; }

        /// <summary>
        /// RCP.2 - Quantity Limited Request.
        /// <para>Suggested: 0126 Quantity Limited Request -&gt; ClearHl7.Codes.V281.CodeQuantityLimitedRequest</para>
        /// </summary>
        public CompositeQuantityWithUnits QuantityLimitedRequest { get; set; }

        /// <summary>
        /// RCP.3 - Response Modality.
        /// <para>Suggested: 0394 Response Modality -&gt; ClearHl7.Codes.V281.CodeResponseModality</para>
        /// </summary>
        public CodedWithNoExceptions ResponseModality { get; set; }

        /// <summary>
        /// RCP.4 - Execution and Delivery Time.
        /// </summary>
        public DateTime? ExecutionAndDeliveryTime { get; set; }

        /// <summary>
        /// RCP.5 - Modify Indicator.
        /// <para>Suggested: 0395 Modify Indicator -&gt; ClearHl7.Codes.V281.CodeModifyIndicator</para>
        /// </summary>
        public string ModifyIndicator { get; set; }

        /// <summary>
        /// RCP.6 - Sort-by Field.
        /// </summary>
        public IEnumerable<SortOrder> SortByField { get; set; }

        /// <summary>
        /// RCP.7 - Segment group inclusion.
        /// <para>Suggested: 0391 Segment Group -&gt; ClearHl7.Codes.V281.CodeSegmentGroup</para>
        /// </summary>
        public IEnumerable<string> SegmentGroupInclusion { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());
            char[] separator = Configuration.FieldRepeatSeparator.ToCharArray();

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            QueryPriority = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            QuantityLimitedRequest = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments[2], false) : null;
            ResponseModality = segments.Length > 3 && segments[3].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[3], false) : null;
            ExecutionAndDeliveryTime = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            ModifyIndicator = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            SortByField = segments.Length > 6 && segments[6].Length > 0 ? segments[6].Split(separator).Select(x => TypeHelper.Deserialize<SortOrder>(x, false)) : null;
            SegmentGroupInclusion = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(separator) : null;
        }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

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