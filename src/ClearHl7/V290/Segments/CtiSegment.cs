using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment CTI - Clinical Trial Identification.
    /// </summary>
    public class CtiSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "CTI";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// CTI.1 - Sponsor Study ID.
        /// </summary>
        public EntityIdentifier SponsorStudyId { get; set; }

        /// <summary>
        /// CTI.2 - Study Phase Identifier.
        /// </summary>
        public CodedWithExceptions StudyPhaseIdentifier { get; set; }

        /// <summary>
        /// CTI.3 - Study Scheduled Time Point.
        /// <para>Suggested: 0595 Study Scheduled Time Point</para>
        /// </summary>
        public CodedWithExceptions StudyScheduledTimePoint { get; set; }

        /// <summary>
        /// CTI.4 - Action Code.
        /// </summary>
        public string ActionCode { get; set; }

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
                                SponsorStudyId?.ToDelimitedString(),
                                StudyPhaseIdentifier?.ToDelimitedString(),
                                StudyScheduledTimePoint?.ToDelimitedString(),
                                ActionCode
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}