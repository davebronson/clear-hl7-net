using System.Collections.Generic;

namespace ClearHl7.Serialization
{
    /// <summary>
    /// Represents the result of a message deserialization operation with warnings.
    /// </summary>
    /// <typeparam name="T">The message type.</typeparam>
    public class ParseResult<T> where T : IMessage
    {
        /// <summary>
        /// Gets or sets the parsed message.
        /// </summary>
        public T Message { get; set; }
        
        /// <summary>
        /// Gets or sets the warnings that occurred during parsing.
        /// </summary>
        public IReadOnlyList<ParserWarning> Warnings { get; set; }
        
        /// <summary>
        /// Gets whether any warnings occurred during parsing.
        /// </summary>
        public bool HasWarnings => Warnings?.Count > 0;
    }
}
