﻿using System;
using ClearHl7.Helpers;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
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
        /// <remarks>https://www.hl7.org/fhir/v2/0003</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0062</remarks>
        public string EventReasonCode { get; set; }

        /// <summary>
        /// EVN.5 - Operator ID.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0188</remarks>
        public ExtendedCompositeIdNumberAndNameForPersons OperatorId { get; set; }

        /// <summary>
        /// EVN.6 - Event Occurred.
        /// </summary>
        public DateTime? EventOccurred { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 7, Configuration.FieldSeparator),
                                Id,
                                EventTypeCode,
                                RecordedDateTime.HasValue ? RecordedDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                DateTimePlannedEvent.HasValue ? DateTimePlannedEvent.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EventReasonCode,
                                OperatorId?.ToDelimitedString(),
                                EventOccurred.HasValue ? EventOccurred.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}