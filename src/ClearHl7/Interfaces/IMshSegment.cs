namespace ClearHl7
{
    /// <summary>
    /// HL7 Version 2 MSH Segment.
    /// </summary>
    public interface IMshSegment
    {
        /// <summary>
        /// MSH.1 - Field Separator.  This property is read-only.
        /// </summary>
        string FieldSeparator { get; }

        /// <summary>
        /// MSH.2 - Encoding Characters.  This property is read-only.
        /// </summary>
        string EncodingCharacters { get; }
    }
}
