using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 AD - Address.
    /// </summary>
    public class Address : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// AD.1 - Street Address.
        /// </summary>
        public string StreetAddress { get; set; }

        /// <summary>
        /// AD.2 - Other Designation.
        /// </summary>
        public string OtherDesignation { get; set; }

        /// <summary>
        /// AD.3 - City.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// AD.4 - State or Province.
        /// </summary>
        public string StateOrProvince { get; set; }

        /// <summary>
        /// AD.5 - Zip or Postal Code.
        /// </summary>
        public string ZipOrPostalCode { get; set; }

        /// <summary>
        /// AD.6 - Country.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0399</remarks>
        public string Country { get; set; }

        /// <summary>
        /// AD.7 - Address Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0190</remarks>
        public string AddressType { get; set; }

        /// <summary>
        /// AD.8 - Other Geographic Designation.
        /// </summary>
        public string OtherGeographicDesignation { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                IsSubcomponent ? "{0}&{1}&{2}&{3}&{4}&{5}&{6}&{7}" : "{0}^{1}^{2}^{3}^{4}^{5}^{6}^{7}",
                                StreetAddress,
                                OtherDesignation,
                                City,
                                StateOrProvince,
                                ZipOrPostalCode,
                                Country,
                                AddressType,
                                OtherGeographicDesignation
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
