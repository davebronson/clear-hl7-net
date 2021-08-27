using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V250.Types;

namespace ClearHl7.V250.Segments
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
        public CodedElement StartingNotificationCode { get; set; }

        /// <summary>
        /// CNS.6 - Ending Notification Code.
        /// </summary>
        public CodedElement EndingNotificationCode { get; set; }

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

            StartingNotificationReferenceNumber = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            EndingNotificationReferenceNumber = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDecimal() : null;
            StartingNotificationDateTime = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDateTime() : null;
            EndingNotificationDateTime = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            StartingNotificationCode = segments.Length > 5 && segments[5].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[5], false) : null;
            EndingNotificationCode = segments.Length > 6 && segments[6].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[6], false) : null;
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