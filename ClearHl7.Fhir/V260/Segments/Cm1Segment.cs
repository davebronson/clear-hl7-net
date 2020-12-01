using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V260.Types;

namespace ClearHl7.Fhir.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment CM1 - Clinical Study Phase Master.
    /// </summary>
    public class Cm1Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "CM1";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// CM1.1 - Set ID - CM1.
        /// </summary>
        public uint? SetIdCm1 { get; set; }

        /// <summary>
        /// CM1.2 - Study Phase Identifier.
        /// </summary>
        public CodedWithExceptions StudyPhaseIdentifier { get; set; }

        /// <summary>
        /// CM1.3 - Description of Study Phase.
        /// </summary>
        public string DescriptionOfStudyPhase { get; set; }

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
                                SetIdCm1.HasValue ? SetIdCm1.Value.ToString(culture) : null,
                                StudyPhaseIdentifier?.ToDelimitedString(),
                                DescriptionOfStudyPhase
                                ).TrimEnd(Configuration.FieldSeparator);
        }
    }
}