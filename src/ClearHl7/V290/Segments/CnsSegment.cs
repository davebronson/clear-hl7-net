using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
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
        /// <para>Suggested: 0585 Starting Notification Code</para>
        /// </summary>
        public CodedWithExceptions StartingNotificationCode { get; set; }

        /// <summary>
        /// CNS.6 - Ending Notification Code.
        /// <para>Suggested: 0586 Ending Notification Code</para>
        /// </summary>
        public CodedWithExceptions EndingNotificationCode { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            StartingNotificationReferenceNumber = segments.ElementAtOrDefault(1)?.ToNullableDecimal();
            EndingNotificationReferenceNumber = segments.ElementAtOrDefault(2)?.ToNullableDecimal();
            StartingNotificationDateTime = segments.ElementAtOrDefault(3)?.ToNullableDateTime();
            EndingNotificationDateTime = segments.ElementAtOrDefault(4)?.ToNullableDateTime();
            StartingNotificationCode = segments.Length > 5 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(5), false) : null;
            EndingNotificationCode = segments.Length > 6 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(6), false) : null;
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