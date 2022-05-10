using System;
using System.Globalization;
using ClearHl7.Helpers;

namespace ClearHl7.V230.Types
{
    /// <summary>
    /// HL7 Version 2 RI - Repeat Interval.
    /// </summary>
    public class RepeatInterval : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepeatInterval"/> class.
        /// </summary>
        public RepeatInterval()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepeatInterval"/> class.
        /// </summary>
        /// <param name="repeatPattern">RI.1 - Repeat Pattern.</param>
        public RepeatInterval(string repeatPattern)
        {
            RepeatPattern = repeatPattern;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// RI.1 - Repeat Pattern.
        /// <para>Suggested: 0335 Repeat Pattern</para>
        /// </summary>
        public string RepeatPattern { get; set; }

        /// <summary>
        /// RI.2 - Explicit Time Interval.
        /// </summary>
        public string ExplicitTimeInterval { get; set; }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] separator = IsSubcomponent ? seps.SubcomponentSeparator : seps.ComponentSeparator;
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(separator, StringSplitOptions.None);

            RepeatPattern = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            ExplicitTimeInterval = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 2, separator),
                                RepeatPattern,
                                ExplicitTimeInterval
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
