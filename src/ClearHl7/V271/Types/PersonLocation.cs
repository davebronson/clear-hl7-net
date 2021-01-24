using ClearHl7.Helpers;

namespace ClearHl7.V271.Types
{
    /// <summary>
    /// HL7 Version 2 PL - Person Location.
    /// </summary>
    public class PersonLocation : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// PL.1 - Point of Care.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0302</remarks>
        public HierarchicDesignator PointOfCare { get; set; }

        /// <summary>
        /// PL.2 - Room.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0303</remarks>
        public HierarchicDesignator Room { get; set; }

        /// <summary>
        /// PL.3 - Bed.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0304</remarks>
        public HierarchicDesignator Bed { get; set; }

        /// <summary>
        /// PL.4 - Facility.
        /// </summary>
        public HierarchicDesignator Facility { get; set; }

        /// <summary>
        /// PL.5 - Location Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0306</remarks>
        public string LocationStatus { get; set; }

        /// <summary>
        /// PL.6 - Person Location Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0305</remarks>
        public string PersonLocationType { get; set; }

        /// <summary>
        /// PL.7 - Building.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0307</remarks>
        public HierarchicDesignator Building { get; set; }

        /// <summary>
        /// PL.8 - Floor.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0308</remarks>
        public HierarchicDesignator Floor { get; set; }

        /// <summary>
        /// PL.9 - Location Description.
        /// </summary>
        public string LocationDescription { get; set; }

        /// <summary>
        /// PL.10 - Comprehensive Location Identifier.
        /// </summary>
        public EntityIdentifier ComprehensiveLocationIdentifier { get; set; }

        /// <summary>
        /// PL.11 - Assigning Authority for Location.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0363</remarks>
        public HierarchicDesignator AssigningAuthorityForLocation { get; set; }

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
                                StringHelper.StringFormatSequence(0, 11, separator),
                                PointOfCare?.ToDelimitedString(),
                                Room?.ToDelimitedString(),
                                Bed?.ToDelimitedString(),
                                Facility?.ToDelimitedString(),
                                LocationStatus,
                                PersonLocationType,
                                Building?.ToDelimitedString(),
                                Floor?.ToDelimitedString(),
                                LocationDescription,
                                ComprehensiveLocationIdentifier?.ToDelimitedString(),
                                AssigningAuthorityForLocation?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
