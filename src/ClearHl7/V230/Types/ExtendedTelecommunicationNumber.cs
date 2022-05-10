using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V230.Types
{
    /// <summary>
    /// HL7 Version 2 XTN - Extended Telecommunication Number.
    /// </summary>
    public class ExtendedTelecommunicationNumber : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedTelecommunicationNumber"/> class.
        /// </summary>
        public ExtendedTelecommunicationNumber()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedTelecommunicationNumber"/> class.
        /// </summary>
        /// <param name="telephoneNumber">XTN.1 - Telephone Number.</param>
        public ExtendedTelecommunicationNumber(string telephoneNumber)
        {
            TelephoneNumber = telephoneNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedTelecommunicationNumber"/> class.
        /// </summary>
        /// <param name="areaCityCode">XTN.6 - Area/City Code.</param>
        /// <param name="localNumber">XTN.7 - Local Number.</param>
        public ExtendedTelecommunicationNumber(int areaCityCode, int localNumber)
        {
            AreaCityCode = areaCityCode;
            LocalNumber = localNumber;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// XTN.1 - Telephone Number.
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// XTN.2 - Telecommunication Use Code.
        /// <para>Suggested: 0201 Telecommunication Use Code -&gt; ClearHl7.Codes.V230.CodeTelecommunicationUseCode</para>
        /// </summary>
        public string TelecommunicationUseCode { get; set; }

        /// <summary>
        /// XTN.3 - Telecommunication Equipment Type.
        /// <para>Suggested: 0202 Telecommunication Equipment Type -&gt; ClearHl7.Codes.V230.CodeTelecommunicationEquipmentType</para>
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

            TelephoneNumber = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            TelecommunicationUseCode = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            TelecommunicationEquipmentType = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            CommunicationAddress = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            CountryCode = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableInt() : null;
            AreaCityCode = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableInt() : null;
            LocalNumber = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableInt() : null;
            Extension = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableInt() : null;
            AnyText = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 9, separator),
                                TelephoneNumber,
                                TelecommunicationUseCode,
                                TelecommunicationEquipmentType,
                                CommunicationAddress,
                                CountryCode.HasValue ? CountryCode.Value.ToString(culture) : null,
                                AreaCityCode.HasValue ? AreaCityCode.Value.ToString(culture) : null,
                                LocalNumber.HasValue ? LocalNumber.Value.ToString(culture) : null,
                                Extension.HasValue ? Extension.Value.ToString(culture) : null,
                                AnyText
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
