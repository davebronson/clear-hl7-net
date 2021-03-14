using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment URD - Results/Update Definition.
    /// </summary>
    public class UrdSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "URD";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// URD.1 - R/U Date/Time.
        /// </summary>
        public DateTime? RuDateTime { get; set; }

        /// <summary>
        /// URD.2 - Report Priority.
        /// <para>Suggested: 0109 Report Priority -&gt; ClearHl7.Codes.V230.CodeReportPriority</para>
        /// </summary>
        public string ReportPriority { get; set; }

        /// <summary>
        /// URD.3 - R/U Who Subject Definition.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> RuWhoSubjectDefinition { get; set; }

        /// <summary>
        /// URD.4 - R/U What Subject Definition.
        /// <para>Suggested: 0048 What Subject Filter -&gt; ClearHl7.Codes.V230.CodeWhatSubjectFilter</para>
        /// </summary>
        public IEnumerable<CodedElement> RuWhatSubjectDefinition { get; set; }

        /// <summary>
        /// URD.5 - R/U What Department Code.
        /// </summary>
        public IEnumerable<CodedElement> RuWhatDepartmentCode { get; set; }

        /// <summary>
        /// URD.6 - R/U Display/Print Locations.
        /// </summary>
        public IEnumerable<string> RuDisplayPrintLocations { get; set; }

        /// <summary>
        /// URD.7 - R/U Results Level.
        /// <para>Suggested: 0108 Query Results Level -&gt; ClearHl7.Codes.V230.CodeQueryResultsLevel</para>
        /// </summary>
        public string RuResultsLevel { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 8, Configuration.FieldSeparator),
                                Id,
                                RuDateTime.HasValue ? RuDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ReportPriority,
                                RuWhoSubjectDefinition != null ? string.Join(Configuration.FieldRepeatSeparator, RuWhoSubjectDefinition.Select(x => x.ToDelimitedString())) : null,
                                RuWhatSubjectDefinition != null ? string.Join(Configuration.FieldRepeatSeparator, RuWhatSubjectDefinition.Select(x => x.ToDelimitedString())) : null,
                                RuWhatDepartmentCode != null ? string.Join(Configuration.FieldRepeatSeparator, RuWhatDepartmentCode.Select(x => x.ToDelimitedString())) : null,
                                RuDisplayPrintLocations != null ? string.Join(Configuration.FieldRepeatSeparator, RuDisplayPrintLocations) : null,
                                RuResultsLevel
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}