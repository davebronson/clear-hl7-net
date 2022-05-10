using System;
using System.Globalization;
using ClearHl7.Helpers;

namespace ClearHl7.V240.Types
{
    /// <summary>
    /// HL7 Version 2 WVS - Waveform Source.
    /// </summary>
    public class WaveformSource : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WaveformSource"/> class.
        /// </summary>
        public WaveformSource()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WaveformSource"/> class.
        /// </summary>
        /// <param name="sourceOneName">WVS.1 - Source One Name.</param>
        public WaveformSource(string sourceOneName)
        {
            SourceOneName = sourceOneName;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// WVS.1 - Source One Name.
        /// </summary>
        public string SourceOneName { get; set; }

        /// <summary>
        /// WVS.2 - Source Two Name.
        /// </summary>
        public string SourceTwoName { get; set; }

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

            SourceOneName = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            SourceTwoName = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 2, separator),
                                SourceOneName,
                                SourceTwoName
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
