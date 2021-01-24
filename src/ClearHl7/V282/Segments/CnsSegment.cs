using System;
using ClearHl7.Helpers;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
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
                                StringHelper.StringFormatSequence(0, 7, Configuration.FieldSeparator),
                                Id,
                                StartingNotificationReferenceNumber.HasValue ? StartingNotificationReferenceNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                EndingNotificationReferenceNumber.HasValue ? EndingNotificationReferenceNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                StartingNotificationDateTime.HasValue ? StartingNotificationDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EndingNotificationDateTime.HasValue ? EndingNotificationDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                StartingNotificationCode?.ToDelimitedString(),
                                EndingNotificationCode?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}