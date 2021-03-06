﻿using System;
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
