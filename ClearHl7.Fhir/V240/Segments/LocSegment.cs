using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V240.Types;

namespace ClearHl7.Fhir.V240.Segments
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
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> OrganizationNameLoc { get; set; }

        /// <summary>
        /// LOC.5 - Location Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> LocationAddress { get; set; }

        /// <summary>
        /// LOC.6 - Location Phone.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> LocationPhone { get; set; }

        /// <summary>
        /// LOC.7 - License Number.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0461</remarks>
        public IEnumerable<CodedElement> LicenseNumber { get; set; }

        /// <summary>
        /// LOC.8 - Location Equipment.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0261</remarks>
        public IEnumerable<string> LocationEquipment { get; set; }

        /// <summary>
        /// LOC.9 - Location Service Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0442</remarks>
        public string LocationServiceCode { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 10, Configuration.FieldSeparator),
                                Id,
                                PrimaryKeyValueLoc?.ToDelimitedString(),
                                LocationDescription,
                                LocationTypeLoc != null ? string.Join(Configuration.FieldRepeatSeparator, LocationTypeLoc) : null,
                                OrganizationNameLoc != null ? string.Join(Configuration.FieldRepeatSeparator, OrganizationNameLoc.Select(x => x.ToDelimitedString())) : null,
                                LocationAddress != null ? string.Join(Configuration.FieldRepeatSeparator, LocationAddress.Select(x => x.ToDelimitedString())) : null,
                                LocationPhone != null ? string.Join(Configuration.FieldRepeatSeparator, LocationPhone.Select(x => x.ToDelimitedString())) : null,
                                LicenseNumber != null ? string.Join(Configuration.FieldRepeatSeparator, LicenseNumber.Select(x => x.ToDelimitedString())) : null,
                                LocationEquipment != null ? string.Join(Configuration.FieldRepeatSeparator, LocationEquipment) : null,
                                LocationServiceCode
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}