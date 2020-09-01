using System;
using ClearHl7.Fhir.V282.Types;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment MCP - Master File Coverage.
    /// </summary>
    public class McpSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "MCP";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
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
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}",
                                Id,
                                SetIdMcp.HasValue ? SetIdMcp.Value.ToString(culture) : null,
                                ProducersServiceTestObservationId?.ToDelimitedString(),
                                UniversalServicePriceRangeLowValue?.ToDelimitedString(),
                                UniversalServicePriceRangeHighValue?.ToDelimitedString(),
                                ReasonForUniversalServiceCostRange
                                ).TrimEnd('|');
        }
    }
}