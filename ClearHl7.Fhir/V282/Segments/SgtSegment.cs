using ClearHl7.Fhir.Helpers;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment SGT - Segment Group Trailer.
    /// </summary>
    public class SgtSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "SGT";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// SGT.1 - Set ID - SGT.
        /// </summary>
        public uint? SetIdSgt { get; set; }

        /// <summary>
        /// SGT.2 - Segment Group Name.
        /// </summary>
        public string SegmentGroupName { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 3, Configuration.FieldSeparator),
                                Id,
                                SetIdSgt.HasValue ? SetIdSgt.Value.ToString(culture) : null,
                                SegmentGroupName
                                ).TrimEnd(Configuration.FieldSeparator);
        }
    }
}