using ClearHl7.Fhir.Helpers;

namespace ClearHl7.Fhir.V280.Types
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
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
            char separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 2, separator),
                                SourceOneName,
                                SourceTwoName
                                ).TrimEnd(separator);
        }
    }
}
