﻿using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
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
        /// <para>Suggested: 0260 Patient Location Type -&gt; ClearHl7.Codes.V271.CodePatientLocationType</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> LocationTypeLoc { get; set; }

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
        /// <para>Suggested: 0461 License Number</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> LicenseNumber { get; set; }

        /// <summary>
        /// LOC.8 - Location Equipment.
        /// <para>Suggested: 0261 Location Equipment -&gt; ClearHl7.Codes.V271.CodeLocationEquipment</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> LocationEquipment { get; set; }

        /// <summary>
        /// LOC.9 - Location Service Code.
        /// <para>Suggested: 0442 Location Service Code -&gt; ClearHl7.Codes.V271.CodeLocationServiceCode</para>
        /// </summary>
        public CodedWithExceptions LocationServiceCode { get; set; }
        
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
                                LocationTypeLoc != null ? string.Join(Configuration.FieldRepeatSeparator, LocationTypeLoc.Select(x => x.ToDelimitedString())) : null,
                                OrganizationNameLoc != null ? string.Join(Configuration.FieldRepeatSeparator, OrganizationNameLoc.Select(x => x.ToDelimitedString())) : null,
                                LocationAddress != null ? string.Join(Configuration.FieldRepeatSeparator, LocationAddress.Select(x => x.ToDelimitedString())) : null,
                                LocationPhone != null ? string.Join(Configuration.FieldRepeatSeparator, LocationPhone.Select(x => x.ToDelimitedString())) : null,
                                LicenseNumber != null ? string.Join(Configuration.FieldRepeatSeparator, LicenseNumber.Select(x => x.ToDelimitedString())) : null,
                                LocationEquipment != null ? string.Join(Configuration.FieldRepeatSeparator, LocationEquipment.Select(x => x.ToDelimitedString())) : null,
                                LocationServiceCode?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}