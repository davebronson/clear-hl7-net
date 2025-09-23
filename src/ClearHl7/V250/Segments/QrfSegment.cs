using System;
using System.Collections.Generic;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V250.Types;

namespace ClearHl7.V250.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment QRF - Query Filter.
    /// </summary>
    public class QrfSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QrfSegment"/> class.
        /// </summary>
        public QrfSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QrfSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public QrfSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "QRF";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// QRF.1 - Where Subject Filter.
        /// </summary>
        public IEnumerable<string> WhereSubjectFilter { get; set; }

        /// <summary>
        /// QRF.2 - When Data Start Date/Time.
        /// </summary>
        public DateTime? WhenDataStartDateTime { get; set; }

        /// <summary>
        /// QRF.3 - When Data End Date/Time.
        /// </summary>
        public DateTime? WhenDataEndDateTime { get; set; }

        /// <summary>
        /// QRF.4 - What User Qualifier.
        /// </summary>
        public IEnumerable<string> WhatUserQualifier { get; set; }

        /// <summary>
        /// QRF.5 - Other QRY Subject Filter.
        /// </summary>
        public IEnumerable<string> OtherQrySubjectFilter { get; set; }

        /// <summary>
        /// QRF.6 - Which Date/Time Qualifier.
        /// <para>Suggested: 0156 Which Date/Time Qualifier -&gt; ClearHl7.Codes.V250.CodeWhichDateTimeQualifier</para>
        /// </summary>
        public IEnumerable<string> WhichDateTimeQualifier { get; set; }

        /// <summary>
        /// QRF.7 - Which Date/Time Status Qualifier.
        /// <para>Suggested: 0157 Which Date/Time Status Qualifier -&gt; ClearHl7.Codes.V250.CodeWhichDateTimeStatusQualifier</para>
        /// </summary>
        public IEnumerable<string> WhichDateTimeStatusQualifier { get; set; }

        /// <summary>
        /// QRF.8 - Date/Time Selection Qualifier.
        /// <para>Suggested: 0158 Date/Time Selection Qualifier -&gt; ClearHl7.Codes.V250.CodeDateTimeSelectionQualifier</para>
        /// </summary>
        public IEnumerable<string> DateTimeSelectionQualifier { get; set; }

        /// <summary>
        /// QRF.9 - When Quantity/Timing Qualifier.
        /// </summary>
        public TimingQuantity WhenQuantityTimingQualifier { get; set; }

        /// <summary>
        /// QRF.10 - Search Confidence Threshold.
        /// </summary>
        public decimal? SearchConfidenceThreshold { get; set; }

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

            WhereSubjectFilter = segments.Length > 1 && segments[1].Length > 0 ? segments[1].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            WhenDataStartDateTime = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDateTime() : null;
            WhenDataEndDateTime = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDateTime() : null;
            WhatUserQualifier = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            OtherQrySubjectFilter = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            WhichDateTimeQualifier = segments.Length > 6 && segments[6].Length > 0 ? segments[6].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            WhichDateTimeStatusQualifier = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            DateTimeSelectionQualifier = segments.Length > 8 && segments[8].Length > 0 ? segments[8].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            WhenQuantityTimingQualifier = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<TimingQuantity>(segments[9], false, seps) : null;
            SearchConfidenceThreshold = segments.Length > 10 && segments[10].Length > 0 ? segments[10].ToNullableDecimal() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 11, Configuration.FieldSeparator),
                                Id,
                                WhereSubjectFilter != null ? string.Join(Configuration.FieldRepeatSeparator, WhereSubjectFilter) : null,
                                WhenDataStartDateTime.ToHl7DateTimeString(typeof(QrfSegment), nameof(WhenDataStartDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                WhenDataEndDateTime.ToHl7DateTimeString(typeof(QrfSegment), nameof(WhenDataEndDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                WhatUserQualifier != null ? string.Join(Configuration.FieldRepeatSeparator, WhatUserQualifier) : null,
                                OtherQrySubjectFilter != null ? string.Join(Configuration.FieldRepeatSeparator, OtherQrySubjectFilter) : null,
                                WhichDateTimeQualifier != null ? string.Join(Configuration.FieldRepeatSeparator, WhichDateTimeQualifier) : null,
                                WhichDateTimeStatusQualifier != null ? string.Join(Configuration.FieldRepeatSeparator, WhichDateTimeStatusQualifier) : null,
                                DateTimeSelectionQualifier != null ? string.Join(Configuration.FieldRepeatSeparator, DateTimeSelectionQualifier) : null,
                                WhenQuantityTimingQualifier?.ToDelimitedString(),
                                SearchConfidenceThreshold.HasValue ? SearchConfidenceThreshold.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
