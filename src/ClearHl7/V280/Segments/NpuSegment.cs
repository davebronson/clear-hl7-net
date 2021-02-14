using ClearHl7.Helpers;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment NPU - Bed Status Update.
    /// </summary>
    public class NpuSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "NPU";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// NPU.1 - Bed Location.
        /// </summary>
        public PersonLocation BedLocation { get; set; }

        /// <summary>
        /// NPU.2 - Bed Status.
        /// <para>Suggested: 0116 Bed Status -&gt; ClearHl7.Codes.V280.CodeBedStatus</para>
        /// </summary>
        public CodedWithExceptions BedStatus { get; set; }
        
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
                                BedLocation?.ToDelimitedString(),
                                BedStatus?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}