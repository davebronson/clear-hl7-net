using System;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V240.Types;

namespace ClearHl7.Fhir.V240.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0367</remarks>
        public CodedElement NotificationAlertSeverity { get; set; }

        /// <summary>
        /// NDS.4 - Notification Code.
        /// </summary>
        public CodedElement NotificationCode { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 5, Configuration.FieldSeparator),
                                Id,
                                NotificationReferenceNumber.HasValue ? NotificationReferenceNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                NotificationDateTime.HasValue ? NotificationDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                NotificationAlertSeverity?.ToDelimitedString(),
                                NotificationCode?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator);
        }
    }
}