using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment EVN - Event Type.
    /// </summary>
    public class EvnSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvnSegment"/> class.
        /// </summary>
        public EvnSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvnSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public EvnSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "EVN";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// EVN.1 - Event Type Code.
        /// <para>Suggested: 0003 Event Type Code -&gt; ClearHl7.Codes.V230.CodeEventTypeCode</para>
        /// </summary>
        public string EventTypeCode { get; set; }

        /// <summary>
        /// EVN.2 - Recorded Date/Time.
        /// </summary>
        public DateTime? RecordedDateTime { get; set; }

        /// <summary>
        /// EVN.3 - Date/Time Planned Event.
        /// </summary>
        public DateTime? DateTimePlannedEvent { get; set; }

        /// <summary>
        /// EVN.4 - Event Reason Code.
        /// <para>Suggested: 0062 Event Reason -&gt; ClearHl7.Codes.V230.CodeEventReason</para>
        /// </summary>
        public string EventReasonCode { get; set; }

        /// <summary>
        /// EVN.5 - Operator ID.
        /// <para>Suggested: 0188 Operator ID</para>
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons OperatorId { get; set; }

        /// <summary>
        /// EVN.6 - Event Occurred.
        /// </summary>
        public DateTime? EventOccurred { get; set; }

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

            EventTypeCode = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            RecordedDateTime = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDateTime() : null;
            DateTimePlannedEvent = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDateTime() : null;
            EventReasonCode = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            OperatorId = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[5], false, seps) : null;
            EventOccurred = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDateTime() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 7, Configuration.FieldSeparator),
                                Id,
                                EventTypeCode,
                                RecordedDateTime?.ToHl7DateTimeString(typeof(EvnSegment), nameof(RecordedDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                DateTimePlannedEvent?.ToHl7DateTimeString(typeof(EvnSegment), nameof(DateTimePlannedEvent), Consts.DateTimeFormatPrecisionSecond, culture),
                                EventReasonCode,
                                OperatorId?.ToDelimitedString(),
                                EventOccurred?.ToHl7DateTimeString(typeof(EvnSegment), nameof(EventOccurred), Consts.DateTimeFormatPrecisionSecond, culture)
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
