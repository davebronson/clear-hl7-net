using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment MCP - Master File Coverage.
    /// </summary>
    public class McpSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="McpSegment"/> class.
        /// </summary>
        public McpSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public McpSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "MCP";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// MCP.1 - Set ID - MCP.
        /// </summary>
        public uint? SetIdMcp { get; set; }

        /// <summary>
        /// MCP.2 - Producer's Service/Test/Observation ID.
        /// </summary>
        public CodedWithExceptions ProducersServiceTestObservationId { get; set; }

        /// <summary>
        /// MCP.3 - Universal Service Price Range - Low Value.
        /// </summary>
        public Money UniversalServicePriceRangeLowValue { get; set; }

        /// <summary>
        /// MCP.4 - Universal Service Price Range - High Value.
        /// </summary>
        public Money UniversalServicePriceRangeHighValue { get; set; }

        /// <summary>
        /// MCP.5 - Reason for Universal Service Cost Range.
        /// </summary>
        public string ReasonForUniversalServiceCostRange { get; set; }

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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdMcp = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            ProducersServiceTestObservationId = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[2], false, seps) : null;
            UniversalServicePriceRangeLowValue = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<Money>(segments[3], false, seps) : null;
            UniversalServicePriceRangeHighValue = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<Money>(segments[4], false, seps) : null;
            ReasonForUniversalServiceCostRange = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 6, Configuration.FieldSeparator),
                                Id,
                                SetIdMcp.HasValue ? SetIdMcp.Value.ToString(culture) : null,
                                ProducersServiceTestObservationId?.ToDelimitedString(),
                                UniversalServicePriceRangeLowValue?.ToDelimitedString(),
                                UniversalServicePriceRangeHighValue?.ToDelimitedString(),
                                ReasonForUniversalServiceCostRange
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
