using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V250.Types;

namespace ClearHl7.Fhir.V250.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0109</remarks>
        public string ReportPriority { get; set; }

        /// <summary>
        /// URD.3 - R/U Who Subject Definition.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> RuWhoSubjectDefinition { get; set; }

        /// <summary>
        /// URD.4 - R/U What Subject Definition.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0048</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0108</remarks>
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
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}",
                                Id,
                                RuDateTime.HasValue ? RuDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ReportPriority,
                                RuWhoSubjectDefinition != null ? string.Join("~", RuWhoSubjectDefinition.Select(x => x.ToDelimitedString())) : null,
                                RuWhatSubjectDefinition != null ? string.Join("~", RuWhatSubjectDefinition.Select(x => x.ToDelimitedString())) : null,
                                RuWhatDepartmentCode != null ? string.Join("~", RuWhatDepartmentCode.Select(x => x.ToDelimitedString())) : null,
                                RuDisplayPrintLocations != null ? string.Join("~", RuDisplayPrintLocations) : null,
                                RuResultsLevel
                                ).TrimEnd('|');
        }
    }
}