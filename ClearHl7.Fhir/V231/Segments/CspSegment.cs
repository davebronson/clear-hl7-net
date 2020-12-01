using System;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V231.Types;

namespace ClearHl7.Fhir.V231.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment CSP - Clinical Study Phase.
    /// </summary>
    public class CspSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "CSP";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// CSP.1 - Study Phase Identifier.
        /// </summary>
        public CodedElement StudyPhaseIdentifier { get; set; }

        /// <summary>
        /// CSP.2 - Date/time Study Phase Began.
        /// </summary>
        public DateTime? DateTimeStudyPhaseBegan { get; set; }

        /// <summary>
        /// CSP.3 - Date/time Study Phase Ended.
        /// </summary>
        public DateTime? DateTimeStudyPhaseEnded { get; set; }

        /// <summary>
        /// CSP.4 - Study Phase Evaluability.
        /// </summary>
        public CodedElement StudyPhaseEvaluability { get; set; }

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
                                StudyPhaseIdentifier?.ToDelimitedString(),
                                DateTimeStudyPhaseBegan.HasValue ? DateTimeStudyPhaseBegan.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                DateTimeStudyPhaseEnded.HasValue ? DateTimeStudyPhaseEnded.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                StudyPhaseEvaluability?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator);
        }
    }
}