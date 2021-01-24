using ClearHl7.Helpers;

namespace ClearHl7.V281.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment SGH - Segment Group Header.
    /// </summary>
    public class SghSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "SGH";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// SGH.1 - Set ID - SGH.
        /// </summary>
        public uint? SetIdSgh { get; set; }

        /// <summary>
        /// SGH.2 - Segment Group Name.
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
                                SetIdSgh.HasValue ? SetIdSgh.Value.ToString(culture) : null,
                                SegmentGroupName
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}