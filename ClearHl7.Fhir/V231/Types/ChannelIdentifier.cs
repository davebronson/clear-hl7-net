using ClearHl7.Fhir.Helpers;

namespace ClearHl7.Fhir.V231.Types
{
    /// <summary>
    /// HL7 Version 2 WVI - Channel Identifier.
    /// </summary>
    public class ChannelIdentifier : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// WVI.1 - Channel Number.
        /// </summary>
        public decimal? ChannelNumber { get; set; }

        /// <summary>
        /// WVI.2 - Channel Name.
        /// </summary>
        public string ChannelName { get; set; }

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
                                ChannelNumber.HasValue ? ChannelNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                ChannelName
                                ).TrimEnd(separator);
        }
    }
}
