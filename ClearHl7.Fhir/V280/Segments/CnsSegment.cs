using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V280.Types;

namespace ClearHl7.Fhir.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment CNS - Clear Notification.
    /// </summary>
    public class CnsSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "CNS";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// CNS.1 - Starting Notification Reference Number.
        /// </summary>
        public decimal? StartingNotificationReferenceNumber { get; set; }

        /// <summary>
        /// CNS.2 - Ending Notification Reference Number.
        /// </summary>
        public decimal? EndingNotificationReferenceNumber { get; set; }

        /// <summary>
        /// CNS.3 - Starting Notification Date/Time.
        /// </summary>
        public DateTime? StartingNotificationDateTime { get; set; }

        /// <summary>
        /// CNS.4 - Ending Notification Date/Time.
        /// </summary>
        public DateTime? EndingNotificationDateTime { get; set; }

        /// <summary>
        /// CNS.5 - Starting Notification Code.
        /// </summary>
        public CodedWithExceptions StartingNotificationCode { get; set; }

        /// <summary>
        /// CNS.6 - Ending Notification Code.
        /// </summary>
        public CodedWithExceptions EndingNotificationCode { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}",
                                Id,
                                StartingNotificationReferenceNumber.HasValue ? StartingNotificationReferenceNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                EndingNotificationReferenceNumber.HasValue ? EndingNotificationReferenceNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                StartingNotificationDateTime.HasValue ? StartingNotificationDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EndingNotificationDateTime.HasValue ? EndingNotificationDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                StartingNotificationCode?.ToDelimitedString(),
                                EndingNotificationCode?.ToDelimitedString()
                                ).TrimEnd('|');
        }
    }
}