using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V250.Types;

namespace ClearHl7.V250.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RCP - Response Control Parameter.
    /// </summary>
    public class RcpSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RcpSegment"/> class.
        /// </summary>
        public RcpSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RcpSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public RcpSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "RCP";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// RCP.1 - Query Priority.
        /// <para>Suggested: 0091 Query Priority -&gt; ClearHl7.Codes.V250.CodeQueryPriority</para>
        /// </summary>
        public string QueryPriority { get; set; }

        /// <summary>
        /// RCP.2 - Quantity Limited Request.
        /// <para>Suggested: 0126 Quantity Limited Request -&gt; ClearHl7.Codes.V250.CodeQuantityLimitedRequest</para>
        /// </summary>
        public CompositeQuantityWithUnits QuantityLimitedRequest { get; set; }

        /// <summary>
        /// RCP.3 - Response Modality.
        /// <para>Suggested: 0394 Response Modality -&gt; ClearHl7.Codes.V250.CodeResponseModality</para>
        /// </summary>
        public CodedElement ResponseModality { get; set; }

        /// <summary>
        /// RCP.4 - Execution and Delivery Time.
        /// </summary>
        public DateTime? ExecutionAndDeliveryTime { get; set; }

        /// <summary>
        /// RCP.5 - Modify Indicator.
        /// <para>Suggested: 0395 Modify Indicator -&gt; ClearHl7.Codes.V250.CodeModifyIndicator</para>
        /// </summary>
        public string ModifyIndicator { get; set; }

        /// <summary>
        /// RCP.6 - Sort-by Field.
        /// </summary>
        public IEnumerable<SortOrder> SortByField { get; set; }

        /// <summary>
        /// RCP.7 - Segment group inclusion.
        /// </summary>
        public IEnumerable<string> SegmentGroupInclusion { get; set; }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (!string.Equals(Id, segments[0], StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            QueryPriority = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            QuantityLimitedRequest = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[2], false, seps) : null;
            ResponseModality = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[3], false, seps) : null;
            ExecutionAndDeliveryTime = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            ModifyIndicator = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            SortByField = segments.Length > 6 && segments[6].Length > 0 ? segments[6].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<SortOrder>(x, false, seps)) : null;
            SegmentGroupInclusion = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
        }

        /// <inheritdoc/>
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
                                ExecutionAndDeliveryTime?.ToHl7DateTimeString(typeof(RcpSegment), nameof(ExecutionAndDeliveryTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                ModifyIndicator,
                                SortByField != null ? string.Join(Configuration.FieldRepeatSeparator, SortByField.Select(x => x.ToDelimitedString())) : null,
                                SegmentGroupInclusion != null ? string.Join(Configuration.FieldRepeatSeparator, SegmentGroupInclusion) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
