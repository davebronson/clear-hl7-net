using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V250.Types;

namespace ClearHl7.Fhir.V250.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment CSS - Clinical Study Data Schedule Segment.
    /// </summary>
    public class CssSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "CSS";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// CSS.1 - Study Scheduled Time Point.
        /// </summary>
        public CodedElement StudyScheduledTimePoint { get; set; }

        /// <summary>
        /// CSS.2 - Study Scheduled Patient Time Point.
        /// </summary>
        public DateTime? StudyScheduledPatientTimePoint { get; set; }

        /// <summary>
        /// CSS.3 - Study Quality Control Codes.
        /// </summary>
        public IEnumerable<CodedElement> StudyQualityControlCodes { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 4, Configuration.FieldSeparator),
                                Id,
                                StudyScheduledTimePoint?.ToDelimitedString(),
                                StudyScheduledPatientTimePoint.HasValue ? StudyScheduledPatientTimePoint.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                StudyQualityControlCodes != null ? string.Join(Configuration.FieldRepeatSeparator, StudyQualityControlCodes.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator);
        }
    }
}