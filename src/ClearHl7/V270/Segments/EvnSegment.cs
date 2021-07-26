using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V270.Types;

namespace ClearHl7.V270.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment EVN - Event Type.
    /// </summary>
    public class EvnSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "EVN";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// EVN.1 - Event Type Code.
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
        /// <para>Suggested: 0062 Event Reason -&gt; ClearHl7.Codes.V270.CodeEventReason</para>
        /// </summary>
        public CodedWithExceptions EventReasonCode { get; set; }

        /// <summary>
        /// EVN.5 - Operator ID.
        /// <para>Suggested: 0188 Operator ID</para>
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> OperatorId { get; set; }

        /// <summary>
        /// EVN.6 - Event Occurred.
        /// </summary>
        public DateTime? EventOccurred { get; set; }

        /// <summary>
        /// EVN.7 - Event Facility.
        /// </summary>
        public HierarchicDesignator EventFacility { get; set; }

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
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            EventTypeCode = segments.ElementAtOrDefault(1);
            RecordedDateTime = segments.ElementAtOrDefault(2)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            DateTimePlannedEvent = segments.ElementAtOrDefault(3)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            EventReasonCode = segments.Length > 4 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(4), false) : null;
            OperatorId = segments.Length > 5 ? segments.ElementAtOrDefault(5).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            EventOccurred = segments.ElementAtOrDefault(6)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            EventFacility = segments.Length > 7 ? TypeHelper.Deserialize<HierarchicDesignator>(segments.ElementAtOrDefault(7), false) : null;
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
                                EventTypeCode,
                                RecordedDateTime.HasValue ? RecordedDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                DateTimePlannedEvent.HasValue ? DateTimePlannedEvent.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EventReasonCode?.ToDelimitedString(),
                                OperatorId != null ? string.Join(Configuration.FieldRepeatSeparator, OperatorId.Select(x => x.ToDelimitedString())) : null,
                                EventOccurred.HasValue ? EventOccurred.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EventFacility?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}