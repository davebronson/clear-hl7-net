using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V251.Types;

namespace ClearHl7.Fhir.V251.Segments
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
        /// QRF.10 - Search Confidence Threshold.
        /// </summary>
        public decimal? SearchConfidenceThreshold { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}",
                                Id,
                                WhereSubjectFilter != null ? string.Join("~", WhereSubjectFilter) : null,
                                WhenDataStartDateTime.HasValue ? WhenDataStartDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                WhenDataEndDateTime.HasValue ? WhenDataEndDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                WhatUserQualifier != null ? string.Join("~", WhatUserQualifier) : null,
                                OtherQrySubjectFilter != null ? string.Join("~", OtherQrySubjectFilter) : null,
                                WhichDateTimeQualifier != null ? string.Join("~", WhichDateTimeQualifier) : null,
                                WhichDateTimeStatusQualifier != null ? string.Join("~", WhichDateTimeStatusQualifier) : null,
                                DateTimeSelectionQualifier != null ? string.Join("~", DateTimeSelectionQualifier) : null,
                                WhenQuantityTimingQualifier?.ToDelimitedString(),
                                SearchConfidenceThreshold.HasValue ? SearchConfidenceThreshold.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd('|');
        }
    }
}