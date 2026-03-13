using System.Collections.Concurrent;
using System.Text;

namespace ClearHl7.Helpers
{
    /// <summary>
    /// Provides static string helper methods.
    /// </summary>
    public class StringHelper
    {
        // Keyed by (start, count, separator). The output is purely deterministic for any given
        // triple, so we build it once and cache it for the lifetime of the process.
        // This eliminates both the repeated Enumerable.Range allocation AND the per-integer
        // boxing that $"{{{x}}}" caused (string interpolation boxes int to object).
        private static readonly ConcurrentDictionary<(int Start, int Count, string Separator), string>
            _formatSequenceCache = new ConcurrentDictionary<(int, int, string), string>();

        /// <summary>
        /// Generates a custom string containing a sequence of placeholders for the .NET String.Format() method, using the given separator.
        /// </summary>
        /// <param name="start">The value of the first integer in the sequence.</param>
        /// <param name="count">The number of sequential integers to generate.</param>
        /// <param name="separator">The character(s) to use as a separator.</param>
        /// <returns>A string.</returns>
        /// <remarks>
        /// For example:  StringFormatSequence(0, 10, "|")
        ///
        /// will output the following:
        /// "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}"
        /// </remarks>
        public static string StringFormatSequence(int start, int count, string separator)
        {
            return _formatSequenceCache.GetOrAdd((start, count, separator), static key =>
            {
                // Build without boxing: ToString() on int does not allocate a boxed object.
                var sb = new StringBuilder(key.Count * (3 + key.Separator.Length));
                int end = key.Start + key.Count;
                for (int i = key.Start; i < end; i++)
                {
                    if (i > key.Start) sb.Append(key.Separator);
                    sb.Append('{');
                    sb.Append(i.ToString());
                    sb.Append('}');
                }
                return sb.ToString();
            });
        }

        /// <summary>
        /// Clears the <see cref="StringFormatSequence"/> cache.
        /// Called automatically by <see cref="Configuration.FieldSeparator"/> when the separator
        /// is changed at runtime so stale format strings are never reused.
        /// </summary>
        public static void InvalidateFormatSequenceCache()
        {
            _formatSequenceCache.Clear();
        }

        /// <summary>
        /// Escapes a string for HL7 encoding characters.
        /// </summary>
        /// <param name="input">The string to escape.</param>
        /// <returns>A string.</returns>
        public static string Escape(string input)
        {
            if (input == null)
            {
                return null;
            }
            if (input.Length == 0)
            {
                return input;
            }

            return input
                .Replace(Configuration.EscapeCharacter, @"\E\")
                .Replace(Configuration.FieldSeparator, @"\F\")
                .Replace(Configuration.ComponentSeparator, @"\S\")
                .Replace(Configuration.SubcomponentSeparator, @"\T\")
                .Replace(Configuration.FieldRepeatSeparator, @"\R\");
        }

        /// <summary>
        /// Unescapes a string for HL7 encoding characters.
        /// </summary>
        /// <param name="input">The string to unescape.</param>
        /// <returns>A string.</returns>
        public static string Unescape(string input)
        {
            if (input == null)
            {
                return null;
            }
            if (input.Length == 0)
            {
                return input;
            }

            return input
                .Replace(@"\F\", Configuration.FieldSeparator)
                .Replace(@"\S\", Configuration.ComponentSeparator)
                .Replace(@"\T\", Configuration.SubcomponentSeparator)
                .Replace(@"\R\", Configuration.FieldRepeatSeparator)
                .Replace(@"\E\", Configuration.EscapeCharacter);
        }
    }
}
