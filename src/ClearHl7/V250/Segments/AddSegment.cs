using ClearHl7.Helpers;

namespace ClearHl7.V250.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ADD - Addendum.
    /// </summary>
    public class AddSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "ADD";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// ADD.1 - Addendum Continuation Pointer.
        /// </summary>
        public string AddendumContinuationPointer { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 2, Configuration.FieldSeparator),
                                Id,
                                AddendumContinuationPointer
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}