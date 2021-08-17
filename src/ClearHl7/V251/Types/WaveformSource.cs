using System.Linq;
using ClearHl7.Helpers;

namespace ClearHl7.V251.Types
{
    /// <summary>
    /// HL7 Version 2 WVS - Waveform Source.
    /// </summary>
    public class WaveformSource : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// WVS.1 - Source One Name.
        /// </summary>
        public string SourceOneName { get; set; }

        /// <summary>
        /// WVS.2 - Source Two Name.
        /// </summary>
        public string SourceTwoName { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            SourceOneName = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            SourceTwoName = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
        }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
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
