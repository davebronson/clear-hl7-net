namespace ClearHl7.Serialization
{
    /// <summary>
    /// Defines how the parser handles malformed segments (e.g., too short, parsing errors).
    /// </summary>
    public enum MalformedSegmentHandling
    {
        /// <summary>
        /// Throw an ArgumentException when a malformed segment is encountered.
        /// This is the default behavior and maintains backward compatibility.
        /// </summary>
        Throw = 0,
        
        /// <summary>
        /// Skip the malformed segment and continue parsing.
        /// A warning is added to the warnings collection if CollectWarnings is true.
        /// </summary>
        Skip = 1,
        
        /// <summary>
        /// Attempt to parse what is possible from the malformed segment.
        /// A warning is added for any parsing errors if CollectWarnings is true. 
        /// </summary>
        BestEffort = 2
    }
}
