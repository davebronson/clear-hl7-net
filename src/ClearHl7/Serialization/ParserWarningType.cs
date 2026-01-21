namespace ClearHl7.Serialization
{
    /// <summary>
    /// Categorizes the type of parser warning.
    /// </summary>
    public enum ParserWarningType
    {
        /// <summary>
        /// An unknown segment ID was encountered.
        /// </summary>
        UnknownSegment,
        
        /// <summary>
        /// A segment was malformed (e.g., too short, invalid format).
        /// </summary>
        MalformedSegment,
        
        /// <summary>
        /// An error occurred while parsing a segment.
        /// </summary>
        ParseError,
        
        /// <summary>
        /// An error occurred while parsing a specific field within a segment.
        /// </summary>
        FieldParseError
    }
}
