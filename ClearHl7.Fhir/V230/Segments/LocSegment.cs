using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V230.Types;

namespace ClearHl7.Fhir.V230.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment LOC - Location Identification.
    /// </summary>
    public class LocSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "LOC";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// LOC.1 - Primary Key Value - LOC.
        /// </summary>
        public PersonLocation PrimaryKeyValueLoc { get; set; }

        /// <summary>
        /// LOC.2 - Location Description.
        /// </summary>
        public string LocationDescription { get; set; }

        /// <summary>
        /// LOC.3 - Location Type - LOC.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0260</remarks>
        public IEnumerable<string> LocationTypeLoc { get; set; }

        /// <summary>
        /// LOC.4 - Organization Name - LOC.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations OrganizationNameLoc { get; set; }

        /// <summary>
        /// LOC.5 - Location Address.
        /// </summary>
        public ExtendedAddress LocationAddress { get; set; }

        /// <summary>
        /// LOC.6 - Location Phone.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> LocationPhone { get; set; }

        /// <summary>
        /// LOC.7 - License Number.
        /// </summary>
        public IEnumerable<CodedElement> LicenseNumber { get; set; }

        /// <summary>
        /// LOC.8 - Location Equipment.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0261</remarks>
        public IEnumerable<string> LocationEquipment { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}",
                                Id,
                                PrimaryKeyValueLoc?.ToDelimitedString(),
                                LocationDescription,
                                LocationTypeLoc != null ? string.Join("~", LocationTypeLoc) : null,
                                OrganizationNameLoc?.ToDelimitedString(),
                                LocationAddress?.ToDelimitedString(),
                                LocationPhone != null ? string.Join("~", LocationPhone.Select(x => x.ToDelimitedString())) : null,
                                LicenseNumber != null ? string.Join("~", LicenseNumber.Select(x => x.ToDelimitedString())) : null,
                                LocationEquipment != null ? string.Join("~", LocationEquipment) : null
                                ).TrimEnd('|');
        }
    }
}