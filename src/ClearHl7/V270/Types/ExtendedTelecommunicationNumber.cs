using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V270.Types
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
        /// <para>Suggested: 0201 Telecommunication Use Code -&gt; ClearHl7.Codes.V270.CodeTelecommunicationUseCode</para>
        /// </summary>
        public string TelecommunicationUseCode { get; set; }

        /// <summary>
        /// XTN.3 - Telecommunication Equipment Type.
        /// <para>Suggested: 0202 Telecommunication Equipment Type -&gt; ClearHl7.Codes.V270.CodeTelecommunicationEquipmentType</para>
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
        /// XTN.13 - Effective Start Date.
        /// </summary>
        public DateTime? EffectiveStartDate { get; set; }

        /// <summary>
        /// XTN.14 - Expiration Date.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// XTN.15 - Expiration Reason.
        /// <para>Suggested: 0868 Telecommunication Expiration Reason -&gt; ClearHl7.Codes.V270.CodeTelecommunicationExpirationReason</para>
        /// </summary>
        public CodedWithExceptions ExpirationReason { get; set; }

        /// <summary>
        /// XTN.16 - Protection Code.
        /// <para>Suggested: 0618 Protection Code -&gt; ClearHl7.Codes.V270.CodeProtectionCode</para>
        /// </summary>
        public CodedWithExceptions ProtectionCode { get; set; }

        /// <summary>
        /// XTN.17 - Shared Telecommunication Identifier.
        /// </summary>
        public EntityIdentifier SharedTelecommunicationIdentifier { get; set; }

        /// <summary>
        /// XTN.18 - Preference Order.
        /// </summary>
        public decimal? PreferenceOrder { get; set; }

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
            ExtensionPrefix = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            SpeedDialCode = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
            UnformattedTelephoneNumber = segments.Length > 11 && segments[11].Length > 0 ? segments[11] : null;
            EffectiveStartDate = segments.Length > 12 && segments[12].Length > 0 ? segments[12].ToNullableDateTime() : null;
            ExpirationDate = segments.Length > 13 && segments[13].Length > 0 ? segments[13].ToNullableDateTime() : null;
            ExpirationReason = segments.Length > 14 && segments[14].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[14], true, seps) : null;
            ProtectionCode = segments.Length > 15 && segments[15].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[15], true, seps) : null;
            SharedTelecommunicationIdentifier = segments.Length > 16 && segments[16].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[16], true, seps) : null;
            PreferenceOrder = segments.Length > 17 && segments[17].Length > 0 ? segments[17].ToNullableDecimal() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 18, separator),
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
                                UnformattedTelephoneNumber,
                                EffectiveStartDate?.ToHl7DateTimeString(typeof(ExtendedTelecommunicationNumber), nameof(EffectiveStartDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                ExpirationDate?.ToHl7DateTimeString(typeof(ExtendedTelecommunicationNumber), nameof(ExpirationDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                ExpirationReason?.ToDelimitedString(),
                                ProtectionCode?.ToDelimitedString(),
                                SharedTelecommunicationIdentifier?.ToDelimitedString(),
                                PreferenceOrder.HasValue ? PreferenceOrder.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
