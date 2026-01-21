using System;

namespace ClearHl7.Serialization
{
    /// <summary>
    /// Event arguments for parser warning events.
    /// </summary>
    public class ParserWarningEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the warning that triggered the event.
        /// </summary>
        public ParserWarning Warning { get; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ParserWarningEventArgs"/> class.
        /// </summary>
        /// <param name="warning">The warning that triggered the event.</param>
        public ParserWarningEventArgs(ParserWarning warning)
        {
            Warning = warning ?? throw new ArgumentNullException(nameof(warning));
        }
    }
}
