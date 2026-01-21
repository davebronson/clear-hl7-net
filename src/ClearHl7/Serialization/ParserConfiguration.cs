using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace ClearHl7.Serialization
{
    /// <summary>
    /// Provides global configuration for HL7 message parsing.
    /// Thread-safe.
    /// </summary>
    public static class ParserConfiguration
    {
        // Thread-safe backing field for default options
        private static ParserOptions _defaultOptions = new ParserOptions();
        private static readonly object _optionsLock = new object();
        
        // Thread-safe collection of warnings from all parsing operations
        private static ConcurrentBag<ParserWarning> _globalWarnings = new ConcurrentBag<ParserWarning>();
        
        /// <summary>
        /// Gets or sets the default parser options used when none are explicitly specified.
        /// Thread-safe.  Returns a defensive copy to prevent unintended mutations.
        /// </summary>
        public static ParserOptions DefaultOptions 
        { 
            get 
            {
                lock (_optionsLock)
                {
                    return _defaultOptions.Clone();
                }
            }
            set 
            {
                lock (_optionsLock)
                {
                    _defaultOptions = value?.Clone() ?? new ParserOptions();
                }
            }
        }
        
        /// <summary>
        /// Global event raised when any parser warning occurs.
        /// Thread-safe (events are inherently thread-safe in .NET).
        /// </summary>
        public static event EventHandler<ParserWarningEventArgs> ParserWarning;
        
        /// <summary>
        /// Gets all warnings collected globally across all parsing operations.
        /// Thread-safe.  Returns an immutable snapshot of warnings.
        /// </summary>
        public static IReadOnlyList<ParserWarning> GlobalWarnings 
            => _globalWarnings.ToImmutableList();
        
        /// <summary>
        /// Clears all globally collected warnings. Thread-safe. 
        /// </summary>
        public static void ClearGlobalWarnings()
        {
            // ConcurrentBag doesn't have Clear() in .NET Standard 2.0, so we recreate it
            _globalWarnings = new ConcurrentBag<ParserWarning>();
        }
        
        /// <summary>
        /// Adds a warning to the global collection. Thread-safe.  Internal use only.
        /// </summary>
        /// <param name="warning">The warning to add. </param>
        internal static void AddGlobalWarning(ParserWarning warning)
        {
            if (warning == null)
            {
                return;
            }
            
            // Add to global collection if global collection is enabled
            lock (_optionsLock)
            {
                if (_defaultOptions.CollectWarnings)
                {
                    _globalWarnings.Add(warning);
                }
            }
            
            // Raise global event (events are thread-safe in .NET)
            ParserWarning?.Invoke(null, new ParserWarningEventArgs(warning));
        }
        
        /// <summary>
        /// Resets configuration to strict default behavior.
        /// Thread-safe. 
        /// </summary>
        public static void ResetToDefaults()
        {
            lock (_optionsLock)
            {
                _defaultOptions = new ParserOptions();
            }
            ClearGlobalWarnings();
        }
    }
}
