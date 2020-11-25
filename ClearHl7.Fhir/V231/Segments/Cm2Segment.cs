using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V231.Types;

namespace ClearHl7.Fhir.V231.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment CM2 - Clinical Study Schedule Master.
    /// </summary>
    public class Cm2Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "CM2";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// CM2.1 - Set ID- CM2.
        /// </summary>
        public uint? SetIdCm2 { get; set; }

        /// <summary>
        /// CM2.2 - Scheduled Time Point.
        /// </summary>
        public CodedElement ScheduledTimePoint { get; set; }

        /// <summary>
        /// CM2.3 - Description of Time Point.
        /// </summary>
        public string DescriptionOfTimePoint { get; set; }

        /// <summary>
        /// CM2.4 - Events Scheduled This Time Point.
        /// </summary>
        public IEnumerable<CodedElement> EventsScheduledThisTimePoint { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}",
                                Id,
                                SetIdCm2.HasValue ? SetIdCm2.Value.ToString(culture) : null,
                                ScheduledTimePoint?.ToDelimitedString(),
                                DescriptionOfTimePoint,
                                EventsScheduledThisTimePoint != null ? string.Join("~", EventsScheduledThisTimePoint.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd('|');
        }
    }
}