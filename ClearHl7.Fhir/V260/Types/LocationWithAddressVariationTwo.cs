using System;

namespace ClearHl7.Fhir.V260.Types
{
    /// <summary>
    /// HL7 Version 2 LA2 - Location With Address Variation 2.
    /// </summary>
    public class LocationWithAddressVariationTwo : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// LA2.1 - Point of Care.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0302</remarks>
        public string PointOfCare { get; set; }

        /// <summary>
        /// LA2.2 - Room.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0303</remarks>
        public string Room { get; set; }

        /// <summary>
        /// LA2.3 - Bed.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0304</remarks>
        public string Bed { get; set; }

        /// <summary>
        /// LA2.4 - Facility.
        /// </summary>
        public HierarchicDesignator Facility { get; set; }

        /// <summary>
        /// LA2.5 - Location Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0306</remarks>
        public string LocationStatus { get; set; }

        /// <summary>
        /// LA2.6 - Patient Location Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0305</remarks>
        public string PatientLocationType { get; set; }

        /// <summary>
        /// LA2.7 - Building.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0307</remarks>
        public string Building { get; set; }

        /// <summary>
        /// LA2.8 - Floor.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0308</remarks>
        public string Floor { get; set; }

        /// <summary>
        /// LA2.9 - Street Address.
        /// </summary>
        public string StreetAddress { get; set; }

        /// <summary>
        /// LA2.10 - Other Designation.
        /// </summary>
        public string OtherDesignation { get; set; }

        /// <summary>
        /// LA2.11 - City.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// LA2.12 - State or Province.
        /// </summary>
        public string StateOrProvince { get; set; }

        /// <summary>
        /// LA2.13 - Zip or Postal Code.
        /// </summary>
        public string ZipOrPostalCode { get; set; }

        /// <summary>
        /// LA2.14 - Country.
        /// </summary>
        /// <remarks>https://www.iso.org/iso-3166-country-codes.html</remarks>
        public string Country { get; set; }

        /// <summary>
        /// LA2.15 - Address Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0190</remarks>
        public string AddressType { get; set; }

        /// <summary>
        /// LA2.16 - Other Geographic Designation .
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
                                IsSubcomponent ? "{0}&{1}&{2}&{3}&{4}&{5}&{6}&{7}&{8}&{9}&{10}&{11}&{12}&{13}&{14}&{15}" : "{0}^{1}^{2}^{3}^{4}^{5}^{6}^{7}^{8}^{9}^{10}^{11}^{12}^{13}^{14}^{15}",
                                PointOfCare,
                                Room,
                                Bed,
                                Facility?.ToDelimitedString(),
                                LocationStatus,
                                PatientLocationType,
                                Building,
                                Floor,
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