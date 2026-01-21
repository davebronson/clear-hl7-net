using System;

namespace ClearHl7.Serialization
{
    /// <summary>
    /// Represents a warning that occurred during HL7 message parsing.
    /// </summary>
    public class ParserWarning
    {
        /// <summary>
        /// Gets or sets the type of warning.
        /// </summary>
        public ParserWarningType Type { get; set; }
        
        /// <summary>
        /// Gets or sets the segment ID where the warning occurred (e.g., "PID", "ZXX").
        /// </summary>
        public string SegmentId { get; set; }
        
        /// <summary>
        /// Gets or sets the line number (segment index) where the warning occurred.
        /// </summary>
        public int LineNumber { get; set; }
        
        /// <summary>
        /// Gets or sets a human-readable description of the warning.
        /// </summary>
        public string Message { get; set; }
        
        /// <summary>
        /// Gets or sets the raw segment string that caused the warning.
        /// </summary>
        public string RawSegment { get; set; }
        
        /// <summary>
        /// Gets or sets the exception that caused the warning, if applicable.
        /// </summary>
        public Exception Exception { get; set; }
        
        /// <summary>
        /// Gets or sets the timestamp when the warning was created.
        /// </summary>
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
