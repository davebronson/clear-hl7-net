using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment CNS - Clear Notification.
    /// </summary>
    public class CnsSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CnsSegment"/> class.
        /// </summary>
        public CnsSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CnsSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public CnsSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "CNS";

        /// <inheritdoc/>
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

            StartingNotificationReferenceNumber = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            EndingNotificationReferenceNumber = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDecimal() : null;
            StartingNotificationDateTime = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDateTime() : null;
            EndingNotificationDateTime = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            StartingNotificationCode = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[5], false, seps) : null;
            EndingNotificationCode = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[6], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 7, Configuration.FieldSeparator),
                                Id,
                                StartingNotificationReferenceNumber.HasValue ? StartingNotificationReferenceNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                EndingNotificationReferenceNumber.HasValue ? EndingNotificationReferenceNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                StartingNotificationDateTime.ToHl7DateTimeString(typeof(CnsSegment), nameof(StartingNotificationDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                EndingNotificationDateTime.ToHl7DateTimeString(typeof(CnsSegment), nameof(EndingNotificationDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                StartingNotificationCode?.ToDelimitedString(),
                                EndingNotificationCode?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
