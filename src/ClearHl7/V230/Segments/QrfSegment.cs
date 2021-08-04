using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment QRF - Query Filter.
    /// </summary>
    public class QrfSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "QRF";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
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
        /// <para>Suggested: 0156 Which Date/Time Qualifier -&gt; ClearHl7.Codes.V230.CodeWhichDateTimeQualifier</para>
        /// </summary>
        public IEnumerable<string> WhichDateTimeQualifier { get; set; }

        /// <summary>
        /// QRF.7 - Which Date/Time Status Qualifier.
        /// <para>Suggested: 0157 Which Date/Time Status Qualifier -&gt; ClearHl7.Codes.V230.CodeWhichDateTimeStatusQualifier</para>
        /// </summary>
        public IEnumerable<string> WhichDateTimeStatusQualifier { get; set; }

        /// <summary>
        /// QRF.8 - Date/Time Selection Qualifier.
        /// <para>Suggested: 0158 Date/Time Selection Qualifier -&gt; ClearHl7.Codes.V230.CodeDateTimeSelectionQualifier</para>
        /// </summary>
        public IEnumerable<string> DateTimeSelectionQualifier { get; set; }

        /// <summary>
        /// QRF.9 - When Quantity/Timing Qualifier.
        /// </summary>
        public TimingQuantity WhenQuantityTimingQualifier { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());
            char[] separator = Configuration.FieldRepeatSeparator.ToCharArray();

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            WhereSubjectFilter = segments.Length > 1 ? segments.ElementAtOrDefault(1).Split(separator) : null;
            WhenDataStartDateTime = segments.ElementAtOrDefault(2)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            WhenDataEndDateTime = segments.ElementAtOrDefault(3)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            WhatUserQualifier = segments.Length > 4 ? segments.ElementAtOrDefault(4).Split(separator) : null;
            OtherQrySubjectFilter = segments.Length > 5 ? segments.ElementAtOrDefault(5).Split(separator) : null;
            WhichDateTimeQualifier = segments.Length > 6 ? segments.ElementAtOrDefault(6).Split(separator) : null;
            WhichDateTimeStatusQualifier = segments.Length > 7 ? segments.ElementAtOrDefault(7).Split(separator) : null;
            DateTimeSelectionQualifier = segments.Length > 8 ? segments.ElementAtOrDefault(8).Split(separator) : null;
            WhenQuantityTimingQualifier = segments.Length > 9 ? TypeHelper.Deserialize<TimingQuantity>(segments.ElementAtOrDefault(9), false) : null;
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
                                StringHelper.StringFormatSequence(0, 10, Configuration.FieldSeparator),
                                Id,
                                WhereSubjectFilter != null ? string.Join(Configuration.FieldRepeatSeparator, WhereSubjectFilter) : null,
                                WhenDataStartDateTime.HasValue ? WhenDataStartDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                WhenDataEndDateTime.HasValue ? WhenDataEndDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                WhatUserQualifier != null ? string.Join(Configuration.FieldRepeatSeparator, WhatUserQualifier) : null,
                                OtherQrySubjectFilter != null ? string.Join(Configuration.FieldRepeatSeparator, OtherQrySubjectFilter) : null,
                                WhichDateTimeQualifier != null ? string.Join(Configuration.FieldRepeatSeparator, WhichDateTimeQualifier) : null,
                                WhichDateTimeStatusQualifier != null ? string.Join(Configuration.FieldRepeatSeparator, WhichDateTimeStatusQualifier) : null,
                                DateTimeSelectionQualifier != null ? string.Join(Configuration.FieldRepeatSeparator, DateTimeSelectionQualifier) : null,
                                WhenQuantityTimingQualifier?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}