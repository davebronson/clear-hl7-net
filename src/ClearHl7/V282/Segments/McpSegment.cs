using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
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
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdMcp = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            ProducersServiceTestObservationId = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[2], false, seps) : null;
            UniversalServicePriceRangeLowValue = segments.Length > 3 && segments[3].Length > 0 ? TypeHelper.Deserialize<Money>(segments[3], false, seps) : null;
            UniversalServicePriceRangeHighValue = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<Money>(segments[4], false, seps) : null;
            ReasonForUniversalServiceCostRange = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
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