using System;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V250.Types
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
        /// <para>Suggested: 0190 Address Type -&gt; ClearHl7.Codes.V250.CodeAddressType</para>
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
        public string CountyParishCode { get; set; }

        /// <summary>
        /// XAD.10 - Census Tract.
        /// <para>Suggested: 0288 Census Tract</para>
        /// </summary>
        public string CensusTract { get; set; }

        /// <summary>
        /// XAD.11 - Address Representation Code.
        /// <para>Suggested: 0465 Name/Address Representation -&gt; ClearHl7.Codes.V250.CodeNameAddressRepresentation</para>
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
            CountyParishCode = segments.ElementAtOrDefault(8);
            CensusTract = segments.ElementAtOrDefault(9);
            AddressRepresentationCode = segments.ElementAtOrDefault(10);
            AddressValidityRange = segments.Length > 11 ? TypeHelper.Deserialize<DateTimeRange>(segments.ElementAtOrDefault(11), true) : null;
            EffectiveDate = segments.ElementAtOrDefault(12)?.ToNullableDateTime();
            ExpirationDate = segments.ElementAtOrDefault(13)?.ToNullableDateTime();
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
                                StringHelper.StringFormatSequence(0, 14, separator),
                                StreetAddress?.ToDelimitedString(),
                                OtherDesignation,
                                City,
                                StateOrProvince,
                                ZipOrPostalCode,
                                Country,
                                AddressType,
                                OtherGeographicDesignation,
                                CountyParishCode,
                                CensusTract,
                                AddressRepresentationCode,
                                AddressValidityRange?.ToDelimitedString(),
                                EffectiveDate.HasValue ? EffectiveDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ExpirationDate.HasValue ? ExpirationDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
