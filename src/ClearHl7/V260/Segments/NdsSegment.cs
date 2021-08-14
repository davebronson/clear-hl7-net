using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment NDS - Notification Detail.
    /// </summary>
    public class NdsSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "NDS";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// NDS.1 - Notification Reference Number.
        /// </summary>
        public decimal? NotificationReferenceNumber { get; set; }

        /// <summary>
        /// NDS.2 - Notification Date/Time.
        /// </summary>
        public DateTime? NotificationDateTime { get; set; }

        /// <summary>
        /// NDS.3 - Notification Alert Severity.
        /// <para>Suggested: 0367 Alert Level -&gt; ClearHl7.Codes.V260.CodeAlertLevel</para>
        /// </summary>
        public CodedWithExceptions NotificationAlertSeverity { get; set; }

        /// <summary>
        /// NDS.4 - Notification Code.
        /// </summary>
        public CodedWithExceptions NotificationCode { get; set; }

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

            NotificationReferenceNumber = segments.ElementAtOrDefault(1)?.ToNullableDecimal();
            NotificationDateTime = segments.ElementAtOrDefault(2)?.ToNullableDateTime();
            NotificationAlertSeverity = segments.Length > 3 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(3), false) : null;
            NotificationCode = segments.Length > 4 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(4), false) : null;
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
                                StringHelper.StringFormatSequence(0, 5, Configuration.FieldSeparator),
                                Id,
                                NotificationReferenceNumber.HasValue ? NotificationReferenceNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                NotificationDateTime.HasValue ? NotificationDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                NotificationAlertSeverity?.ToDelimitedString(),
                                NotificationCode?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}