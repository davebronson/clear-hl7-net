using System;
using System.Collections.Generic;
using ClearHl7.Helpers;
using ClearHl7.V231.Types;

namespace ClearHl7.V231.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0156</remarks>
        public IEnumerable<string> WhichDateTimeQualifier { get; set; }

        /// <summary>
        /// QRF.7 - Which Date/Time Status Qualifier.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0157</remarks>
        public IEnumerable<string> WhichDateTimeStatusQualifier { get; set; }

        /// <summary>
        /// QRF.8 - Date/Time Selection Qualifier.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0158</remarks>
        public IEnumerable<string> DateTimeSelectionQualifier { get; set; }

        /// <summary>
        /// QRF.9 - When Quantity/Timing Qualifier.
        /// </summary>
        public TimingQuantity WhenQuantityTimingQualifier { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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