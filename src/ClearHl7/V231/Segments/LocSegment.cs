using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V231.Types;

namespace ClearHl7.V231.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment LOC - Location Identification.
    /// </summary>
    public class LocSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocSegment"/> class.
        /// </summary>
        public LocSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public LocSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id { get; } = "LOC";

        /// <inheritdoc/>
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
        /// <para>Suggested: 0260 Patient Location Type -&gt; ClearHl7.Codes.V231.CodePatientLocationType</para>
        /// </summary>
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
        public IEnumerable<CodedElement> LicenseNumber { get; set; }

        /// <summary>
        /// LOC.8 - Location Equipment.
        /// <para>Suggested: 0261 Location Equipment -&gt; ClearHl7.Codes.V231.CodeLocationEquipment</para>
        /// </summary>
        public IEnumerable<string> LocationEquipment { get; set; }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            PrimaryKeyValueLoc = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<PersonLocation>(segments[1], false, seps) : null;
            LocationDescription = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            LocationTypeLoc = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            OrganizationNameLoc = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false, seps)) : null;
            LocationAddress = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedAddress>(x, false, seps)) : null;
            LocationPhone = segments.Length > 6 && segments[6].Length > 0 ? segments[6].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedTelecommunicationNumber>(x, false, seps)) : null;
            LicenseNumber = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            LocationEquipment = segments.Length > 8 && segments[8].Length > 0 ? segments[8].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 9, Configuration.FieldSeparator),
                                Id,
                                PrimaryKeyValueLoc?.ToDelimitedString(),
                                LocationDescription,
                                LocationTypeLoc != null ? string.Join(Configuration.FieldRepeatSeparator, LocationTypeLoc) : null,
                                OrganizationNameLoc != null ? string.Join(Configuration.FieldRepeatSeparator, OrganizationNameLoc.Select(x => x.ToDelimitedString())) : null,
                                LocationAddress != null ? string.Join(Configuration.FieldRepeatSeparator, LocationAddress.Select(x => x.ToDelimitedString())) : null,
                                LocationPhone != null ? string.Join(Configuration.FieldRepeatSeparator, LocationPhone.Select(x => x.ToDelimitedString())) : null,
                                LicenseNumber != null ? string.Join(Configuration.FieldRepeatSeparator, LicenseNumber.Select(x => x.ToDelimitedString())) : null,
                                LocationEquipment != null ? string.Join(Configuration.FieldRepeatSeparator, LocationEquipment) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
