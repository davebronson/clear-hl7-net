using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V251.Types;

namespace ClearHl7.V251.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment NDS - Notification Detail.
    /// </summary>
    public class NdsSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NdsSegment"/> class.
        /// </summary>
        public NdsSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NdsSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public NdsSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "NDS";

        /// <inheritdoc/>
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
        /// <para>Suggested: 0367 Alert Level -&gt; ClearHl7.Codes.V251.CodeAlertLevel</para>
        /// </summary>
        public CodedElement NotificationAlertSeverity { get; set; }

        /// <summary>
        /// NDS.4 - Notification Code.
        /// </summary>
        public CodedElement NotificationCode { get; set; }

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

            NotificationReferenceNumber = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            NotificationDateTime = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDateTime() : null;
            NotificationAlertSeverity = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[3], false, seps) : null;
            NotificationCode = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[4], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 5, Configuration.FieldSeparator),
                                Id,
                                NotificationReferenceNumber.HasValue ? NotificationReferenceNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                NotificationDateTime?.ToHl7DateTimeString(typeof(NdsSegment), nameof(NotificationDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                NotificationAlertSeverity?.ToDelimitedString(),
                                NotificationCode?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
