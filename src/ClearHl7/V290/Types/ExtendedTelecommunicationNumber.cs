using System;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V290.Types
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
        /// <para>Suggested: 0201 Telecommunication Use Code -&gt; ClearHl7.Codes.V290.CodeTelecommunicationUseCode</para>
        /// </summary>
        public string TelecommunicationUseCode { get; set; }

        /// <summary>
        /// XTN.3 - Telecommunication Equipment Type.
        /// <para>Suggested: 0202 Telecommunication Equipment Type -&gt; ClearHl7.Codes.V290.CodeTelecommunicationEquipmentType</para>
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
        /// <para>Suggested: 0868 Telecommunication Expiration Reason -&gt; ClearHl7.Codes.V290.CodeTelecommunicationExpirationReason</para>
        /// </summary>
        public CodedWithExceptions ExpirationReason { get; set; }

        /// <summary>
        /// XTN.16 - Protection Code.
        /// <para>Suggested: 0618 Protection Code -&gt; ClearHl7.Codes.V290.CodeProtectionCode</para>
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

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public ExtendedTelecommunicationNumber FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            TelephoneNumber = segments.ElementAtOrDefault(0);
            TelecommunicationUseCode = segments.ElementAtOrDefault(1);
            TelecommunicationEquipmentType = segments.ElementAtOrDefault(2);
            CommunicationAddress = segments.ElementAtOrDefault(3);
            CountryCode = segments.ElementAtOrDefault(4)?.ToNullableInt();
            AreaCityCode = segments.ElementAtOrDefault(5)?.ToNullableInt();
            LocalNumber = segments.ElementAtOrDefault(6)?.ToNullableInt();
            Extension = segments.ElementAtOrDefault(7)?.ToNullableInt();
            AnyText = segments.ElementAtOrDefault(8);
            ExtensionPrefix = segments.ElementAtOrDefault(9);
            SpeedDialCode = segments.ElementAtOrDefault(10);
            UnformattedTelephoneNumber = segments.ElementAtOrDefault(11);
            EffectiveStartDate = segments.ElementAtOrDefault(12)?.ToNullableDateTime();
            ExpirationDate = segments.ElementAtOrDefault(13)?.ToNullableDateTime();
            ExpirationReason = segments.Length > 14 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(14)) : null;
            ProtectionCode = segments.Length > 15 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(15)) : null;
            SharedTelecommunicationIdentifier = segments.Length > 16 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(16)) : null;
            PreferenceOrder = segments.ElementAtOrDefault(17)?.ToNullableDecimal();

            return this;
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
                                EffectiveStartDate.HasValue ? EffectiveStartDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond) : null,
                                ExpirationDate.HasValue ? ExpirationDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond) : null,
                                ExpirationReason?.ToDelimitedString(),
                                ProtectionCode?.ToDelimitedString(),
                                SharedTelecommunicationIdentifier?.ToDelimitedString(),
                                PreferenceOrder.HasValue ? PreferenceOrder.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
