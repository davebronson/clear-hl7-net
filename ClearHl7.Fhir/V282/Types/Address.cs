using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 AD - Address.
    /// </summary>
    public class Address
    {
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
    }
}
