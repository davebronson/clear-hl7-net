namespace ClearHl7.Serialization
{
    /// <summary>
    /// Defines how the parser handles segments with unknown segment IDs.
    /// </summary>
    public enum UnknownSegmentHandling
    {
        /// <summary>
        /// Throw an ArgumentException when an unknown segment is encountered.
        /// This is the default behavior and maintains backward compatibility.
        /// </summary>
        Throw = 0,
        
        /// <summary>
        /// Skip the unknown segment and continue parsing.
        /// A warning is added to the warnings collection if CollectWarnings is true.
        /// </summary>
        Skip = 1,
        
        /// <summary>
        /// Create a generic UnknownSegment instance containing the raw segment data.
        /// A warning is added to the warnings collection if CollectWarnings is true. 
        /// </summary>
        CreateGeneric = 2
    }
}
