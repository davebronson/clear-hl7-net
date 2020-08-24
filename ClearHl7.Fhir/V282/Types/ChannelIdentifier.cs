using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 WVI - Channel Identifier.
    /// </summary>
    public class ChannelIdentifier
    {
        /// <summary>
        /// WVI.1 - Channel Number.
        /// </summary>
        public decimal? ChannelNumber { get; set; }

        /// <summary>
        /// WVI.2 - Channel Name.
        /// </summary>
        public string ChannelName { get; set; }

        /// <summary>
        /// Returns a pipe-delimited representation of this instance. 
        /// </summary>
        /// <param name="isSubcomponent">Whether this instance is a subcomponent of another component instance.</param>
        /// <returns>A string.</returns>
        public string ToPipeString(bool isSubcomponent)
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
            string format = isSubcomponent ? "{0}&{1}" : "{0}^{1}";

            return string.Format(
                                culture,
                                format,
                                ChannelNumber.HasValue ? ChannelNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                ChannelName
                                ).TrimEnd(isSubcomponent ? '&' : '^');
        }
    }
}
