using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V231.Types
{
    /// <summary>
    /// HL7 Version 2 LA1 - Location With Address Variation 1.
    /// </summary>
    public class LocationWithAddressVariationOne : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationWithAddressVariationOne"/> class.
        /// </summary>
        public LocationWithAddressVariationOne()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationWithAddressVariationOne"/> class.
        /// </summary>
        /// <param name="pointOfCare">LA1.1 - Point of Care.</param>
        public LocationWithAddressVariationOne(string pointOfCare)
        {
            PointOfCare = pointOfCare;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// LA1.1 - Point of Care.
        /// <para>Suggested: 0302 Point Of Care</para>
        /// </summary>
        public string PointOfCare { get; set; }

        /// <summary>
        /// LA1.2 - Room.
        /// <para>Suggested: 0303 Room</para>
        /// </summary>
        public string Room { get; set; }

        /// <summary>
        /// LA1.3 - Bed.
        /// <para>Suggested: 0304 Bed</para>
        /// </summary>
        public string Bed { get; set; }

        /// <summary>
        /// LA1.4 - Facility.
        /// </summary>
        public HierarchicDesignator Facility { get; set; }

        /// <summary>
        /// LA1.5 - Location Status.
        /// <para>Suggested: 0306 Location Status</para>
        /// </summary>
        public string LocationStatus { get; set; }

        /// <summary>
        /// LA1.6 - Patient Location Type.
        /// <para>Suggested: 0305 Person Location Type</para>
        /// </summary>
        public string PatientLocationType { get; set; }

        /// <summary>
        /// LA1.7 - Building.
        /// <para>Suggested: 0307 Building</para>
        /// </summary>
        public string Building { get; set; }

        /// <summary>
        /// LA1.8 - Floor.
        /// <para>Suggested: 0308 Floor</para>
        /// </summary>
        public string Floor { get; set; }

        /// <summary>
        /// LA1.9 - Address.
        /// </summary>
        public Address Address { get; set; }

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

            PointOfCare = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            Room = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            Bed = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            Facility = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[3], true, seps) : null;
            LocationStatus = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            PatientLocationType = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            Building = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            Floor = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            Address = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<Address>(segments[8], true, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 9, separator),
                                PointOfCare,
                                Room,
                                Bed,
                                Facility?.ToDelimitedString(),
                                LocationStatus,
                                PatientLocationType,
                                Building,
                                Floor,
                                Address?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
