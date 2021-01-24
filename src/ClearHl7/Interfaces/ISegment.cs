namespace ClearHl7
{
    /// <summary>
    /// HL7 Version 2 Segment.
    /// </summary>
    public interface ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        int Ordinal { get; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        string ToDelimitedString();
    }
}