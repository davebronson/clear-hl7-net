﻿using ClearHl7.Helpers;

namespace ClearHl7.V250.Types
{
    /// <summary>
    /// HL7 Version 2 XTN - Extended Telecommunication Number.
    /// </summary>
    public class ExtendedTelecommunicationNumber : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// XTN.1 - Telephone Number.
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// XTN.2 - Telecommunication Use Code.
        /// <para>Suggested: 0201 Telecommunication Use Code -&gt; ClearHl7.Codes.V250.CodeTelecommunicationUseCode</para>
        /// </summary>
        public string TelecommunicationUseCode { get; set; }

        /// <summary>
        /// XTN.3 - Telecommunication Equipment Type.
        /// <para>Suggested: 0202 Telecommunication Equipment Type -&gt; ClearHl7.Codes.V250.CodeTelecommunicationEquipmentType</para>
        /// </summary>
        public string TelecommunicationEquipmentType { get; set; }

        /// <summary>
        /// XTN.4 - Communication Address.
        /// </summary>
        public string CommunicationAddress { get; set; }

        /// <summary>
        /// XTN.5 - Country Code.
        /// </summary>
        public int? CountryCode { get; set; }

        /// <summary>
        /// XTN.6 - Area/City Code.
        /// </summary>
        public int? AreaCityCode { get; set; }

        /// <summary>
        /// XTN.7 - Local Number.
        /// </summary>
        public int? LocalNumber { get; set; }

        /// <summary>
        /// XTN.8 - Extension.
        /// </summary>
        public int? Extension { get; set; }

        /// <summary>
        /// XTN.9 - Any Text.
        /// </summary>
        public string AnyText { get; set; }

        /// <summary>
        /// XTN.10 - Extension Prefix.
        /// </summary>
        public string ExtensionPrefix { get; set; }

        /// <summary>
        /// XTN.11 - Speed Dial Code.
        /// </summary>
        public string SpeedDialCode { get; set; }

        /// <summary>
        /// XTN.12 - Unformatted Telephone Number.
        /// </summary>
        public string UnformattedTelephoneNumber { get; set; }

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
                                StringHelper.StringFormatSequence(0, 12, separator),
                                TelephoneNumber,
                                TelecommunicationUseCode,
                                TelecommunicationEquipmentType,
                                CommunicationAddress,
                                CountryCode.HasValue ? CountryCode.Value.ToString(culture) : null,
                                AreaCityCode.HasValue ? AreaCityCode.Value.ToString(culture) : null,
                                LocalNumber.HasValue ? LocalNumber.Value.ToString(culture) : null,
                                Extension.HasValue ? Extension.Value.ToString(culture) : null,
                                AnyText,
                                ExtensionPrefix,
                                SpeedDialCode,
                                UnformattedTelephoneNumber
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
