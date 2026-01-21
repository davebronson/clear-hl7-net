using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace ClearHl7.Serialization
{
    /// <summary>
    /// Configures parser behavior for HL7 message deserialization.
    /// Thread-safe. 
    /// </summary>
    public class ParserOptions : ICloneable
    {
        // Thread-safe instance-level warning collection
        private ConcurrentBag<ParserWarning> _warnings = new ConcurrentBag<ParserWarning>();
        
        /// <summary>
        /// Gets or sets how unknown segments are handled during parsing.
        /// Default: Throw (maintains backward compatibility).
        /// </summary>
        public UnknownSegmentHandling UnknownSegmentHandling { get; set; } = UnknownSegmentHandling.Throw;
        
        /// <summary>
        /// Gets or sets how malformed segments are handled during parsing. 
        /// Default: Throw (maintains backward compatibility).
        /// </summary>
        public MalformedSegmentHandling MalformedSegmentHandling { get; set; } = MalformedSegmentHandling.Throw;
        
        /// <summary>
        /// Gets or sets whether warnings should be collected during parsing.
        /// Default: false.
        /// </summary>
        public bool CollectWarnings { get; set; } = false;
        
        /// <summary>
        /// Event raised when a warning occurs during parsing. 
        /// </summary>
        public event EventHandler<ParserWarningEventArgs> ParserWarning;
        
        /// <summary>
        /// Gets warnings collected during parsing.  Thread-safe.
        /// Returns an immutable snapshot of the warnings collection.
        /// </summary>
        public IReadOnlyList<ParserWarning> Warnings 
            => _warnings.ToImmutableList();
        
        /// <summary>
        /// Clears all collected warnings.  Thread-safe.
        /// </summary>
        public void ClearWarnings()
        {
            // ConcurrentBag doesn't have Clear() in .NET Standard 2.0, so we recreate it
            _warnings = new ConcurrentBag<ParserWarning>();
        }
        
        /// <summary>
        /// Adds a warning to the collection.  Thread-safe.  Internal use only.
        /// </summary>
        /// <param name="warning">The warning to add.</param>
        internal void AddWarning(ParserWarning warning)
        {
            if (warning == null)
            {
                return;
            }
            
            // Add to instance collection if enabled
            if (CollectWarnings)
            {
                _warnings.Add(warning);
            }
            
            // Raise instance event
            ParserWarning?.Invoke(this, new ParserWarningEventArgs(warning));
            
            // Also raise global event
            ParserConfiguration.AddGlobalWarning(warning);
        }
        
        /// <summary>
        /// Creates a deep copy of the parser options.
        /// Note: Does NOT copy the warnings collection or event handlers.
        /// </summary>
        /// <returns>A new ParserOptions instance with the same configuration.</returns>
        public ParserOptions Clone()
        {
            return new ParserOptions
            {
                UnknownSegmentHandling = this.UnknownSegmentHandling,
                MalformedSegmentHandling = this.MalformedSegmentHandling,
                CollectWarnings = this.CollectWarnings
                // Intentionally do NOT copy: _warnings, ParserWarning event
            };
        }
        
        object ICloneable.Clone() => Clone();
    }
}
