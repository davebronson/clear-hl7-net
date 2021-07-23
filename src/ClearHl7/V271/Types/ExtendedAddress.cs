using System;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V271.Types
{
    /// <summary>
    /// HL7 Version 2 XAD - Extended Address.
    /// </summary>
    public class ExtendedAddress : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// XAD.1 - Street Address.
        /// </summary>
        public StreetAddress StreetAddress { get; set; }

        /// <summary>
        /// XAD.2 - Other Designation.
        /// </summary>
        public string OtherDesignation { get; set; }

        /// <summary>
        /// XAD.3 - City.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// XAD.4 - State or Province.
        /// </summary>
        public string StateOrProvince { get; set; }

        /// <summary>
        /// XAD.5 - Zip or Postal Code.
        /// </summary>
        public string ZipOrPostalCode { get; set; }

        /// <summary>
        /// XAD.6 - Country.
        /// <para>Suggested: 0399 Country Code -&gt; https://www.iso.org/iso-3166-country-codes.html</para>
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// XAD.7 - Address Type.
        /// <para>Suggested: 0190 Address Type -&gt; ClearHl7.Codes.V271.CodeAddressType</para>
        /// </summary>
        public string AddressType { get; set; }

        /// <summary>
        /// XAD.8 - Other Geographic Designation.
        /// </summary>
        public string OtherGeographicDesignation { get; set; }

        /// <summary>
        /// XAD.9 - County/Parish Code.
        /// <para>Suggested: 0289 County/Parish Code</para>
        /// </summary>
        public CodedWithExceptions CountyParishCode { get; set; }

        /// <summary>
        /// XAD.10 - Census Tract.
        /// <para>Suggested: 0288 Census Tract</para>
        /// </summary>
        public CodedWithExceptions CensusTract { get; set; }

        /// <summary>
        /// XAD.11 - Address Representation Code.
        /// <para>Suggested: 0465 Name/Address Representation -&gt; ClearHl7.Codes.V271.CodeNameAddressRepresentation</para>
        /// </summary>
        public string AddressRepresentationCode { get; set; }

        /// <summary>
        /// XAD.12 - Address Validity Range.
        /// </summary>
        public DateTimeRange AddressValidityRange { get; set; }

        /// <summary>
        /// XAD.13 - Effective Date.
        /// </summary>
        public DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// XAD.14 - Expiration Date.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// XAD.15 - Expiration Reason.
        /// <para>Suggested: 0616 Address Expiration Reason -&gt; ClearHl7.Codes.V271.CodeAddressExpirationReason</para>
        /// </summary>
        public CodedWithExceptions ExpirationReason { get; set; }

        /// <summary>
        /// XAD.16 - Temporary Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V271.CodeYesNoIndicator</para>
        /// </summary>
        public string TemporaryIndicator { get; set; }

        /// <summary>
        /// XAD.17 - Bad Address Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V271.CodeYesNoIndicator</para>
        /// </summary>
        public string BadAddressIndicator { get; set; }

        /// <summary>
        /// XAD.18 - Address Usage.
        /// <para>Suggested: 0617 Address Usage -&gt; ClearHl7.Codes.V271.CodeAddressUsage</para>
        /// </summary>
        public string AddressUsage { get; set; }

        /// <summary>
        /// XAD.19 - Addressee.
        /// </summary>
        public string Addressee { get; set; }

        /// <summary>
        /// XAD.20 - Comment.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// XAD.21 - Preference Order.
        /// </summary>
        public decimal? PreferenceOrder { get; set; }

        /// <summary>
        /// XAD.22 - Protection Code.
        /// <para>Suggested: 0618 Protection Code -&gt; ClearHl7.Codes.V271.CodeProtectionCode</para>
        /// </summary>
        public CodedWithExceptions ProtectionCode { get; set; }

        /// <summary>
        /// XAD.23 - Address Identifier.
        /// </summary>
        public EntityIdentifier AddressIdentifier { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            StreetAddress = segments.Length > 0 ? TypeHelper.Deserialize<StreetAddress>(segments.ElementAtOrDefault(0), true) : null;
            OtherDesignation = segments.ElementAtOrDefault(1);
            City = segments.ElementAtOrDefault(2);
            StateOrProvince = segments.ElementAtOrDefault(3);
            ZipOrPostalCode = segments.ElementAtOrDefault(4);
            Country = segments.ElementAtOrDefault(5);
            AddressType = segments.ElementAtOrDefault(6);
            OtherGeographicDesignation = segments.ElementAtOrDefault(7);
            CountyParishCode = segments.Length > 8 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(8), true) : null;
            CensusTract = segments.Length > 9 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(9), true) : null;
            AddressRepresentationCode = segments.ElementAtOrDefault(10);
            AddressValidityRange = segments.Length > 11 ? TypeHelper.Deserialize<DateTimeRange>(segments.ElementAtOrDefault(11), true) : null;
            EffectiveDate = segments.ElementAtOrDefault(12)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            ExpirationDate = segments.ElementAtOrDefault(13)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            ExpirationReason = segments.Length > 14 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(14), true) : null;
            TemporaryIndicator = segments.ElementAtOrDefault(15);
            BadAddressIndicator = segments.ElementAtOrDefault(16);
            AddressUsage = segments.ElementAtOrDefault(17);
            Addressee = segments.ElementAtOrDefault(18);
            Comment = segments.ElementAtOrDefault(19);
            PreferenceOrder = segments.ElementAtOrDefault(20)?.ToNullableDecimal();
            ProtectionCode = segments.Length > 21 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(21), true) : null;
            AddressIdentifier = segments.Length > 22 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(22), true) : null;
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
                                StringHelper.StringFormatSequence(0, 23, separator),
                                StreetAddress?.ToDelimitedString(),
                                OtherDesignation,
                                City,
                                StateOrProvince,
                                ZipOrPostalCode,
                                Country,
                                AddressType,
                                OtherGeographicDesignation,
                                CountyParishCode?.ToDelimitedString(),
                                CensusTract?.ToDelimitedString(),
                                AddressRepresentationCode,
                                AddressValidityRange?.ToDelimitedString(),
                                EffectiveDate.HasValue ? EffectiveDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ExpirationDate.HasValue ? ExpirationDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ExpirationReason?.ToDelimitedString(),
                                TemporaryIndicator,
                                BadAddressIndicator,
                                AddressUsage,
                                Addressee,
                                Comment,
                                PreferenceOrder.HasValue ? PreferenceOrder.Value.ToString(Consts.NumericFormat, culture) : null,
                                ProtectionCode?.ToDelimitedString(),
                                AddressIdentifier?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
