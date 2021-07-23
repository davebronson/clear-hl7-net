using System.Linq;
using ClearHl7.Helpers;

namespace ClearHl7.V240.Types
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
        /// <para>Suggested: 0302 Point Of Care</para>
        /// </summary>
        public string PointOfCare { get; set; }

        /// <summary>
        /// LA2.2 - Room.
        /// <para>Suggested: 0303 Room</para>
        /// </summary>
        public string Room { get; set; }

        /// <summary>
        /// LA2.3 - Bed.
        /// <para>Suggested: 0304 Bed</para>
        /// </summary>
        public string Bed { get; set; }

        /// <summary>
        /// LA2.4 - Facility.
        /// </summary>
        public HierarchicDesignator Facility { get; set; }

        /// <summary>
        /// LA2.5 - Location Status.
        /// <para>Suggested: 0306 Location Status</para>
        /// </summary>
        public string LocationStatus { get; set; }

        /// <summary>
        /// LA2.6 - Patient Location Type.
        /// <para>Suggested: 0305 Person Location Type -&gt; ClearHl7.Codes.V240.CodePersonLocationType</para>
        /// </summary>
        public string PatientLocationType { get; set; }

        /// <summary>
        /// LA2.7 - Building.
        /// <para>Suggested: 0307 Building</para>
        /// </summary>
        public string Building { get; set; }

        /// <summary>
        /// LA2.8 - Floor.
        /// <para>Suggested: 0308 Floor</para>
        /// </summary>
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
        /// <para>Suggested: 0399 Country Code -&gt; https://www.iso.org/iso-3166-country-codes.html</para>
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// LA2.15 - Address Type.
        /// <para>Suggested: 0190 Address Type -&gt; ClearHl7.Codes.V240.CodeAddressType</para>
        /// </summary>
        public string AddressType { get; set; }

        /// <summary>
        /// LA2.16 - Other Geographic Designation .
        /// </summary>
        public string OtherGeographicDesignation { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            PointOfCare = segments.ElementAtOrDefault(0);
            Room = segments.ElementAtOrDefault(1);
            Bed = segments.ElementAtOrDefault(2);
            Facility = segments.Length > 3 ? TypeHelper.Deserialize<HierarchicDesignator>(segments.ElementAtOrDefault(3), true) : null;
            LocationStatus = segments.ElementAtOrDefault(4);
            PatientLocationType = segments.ElementAtOrDefault(5);
            Building = segments.ElementAtOrDefault(6);
            Floor = segments.ElementAtOrDefault(7);
            StreetAddress = segments.ElementAtOrDefault(8);
            OtherDesignation = segments.ElementAtOrDefault(9);
            City = segments.ElementAtOrDefault(10);
            StateOrProvince = segments.ElementAtOrDefault(11);
            ZipOrPostalCode = segments.ElementAtOrDefault(12);
            Country = segments.ElementAtOrDefault(13);
            AddressType = segments.ElementAtOrDefault(14);
            OtherGeographicDesignation = segments.ElementAtOrDefault(15);
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
                                StringHelper.StringFormatSequence(0, 16, separator),
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
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
