﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ROL - Role.
    /// </summary>
    public class RolSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "ROL";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// ROL.1 - Role Instance ID.
        /// </summary>
        public EntityIdentifier RoleInstanceId { get; set; }

        /// <summary>
        /// ROL.2 - Action Code.
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Codes.V282.CodeSegmentActionCode</para>
        /// </summary>
        public string ActionCode { get; set; }

        /// <summary>
        /// ROL.3 - Role-ROL.
        /// <para>Suggested: 0443 Provider Role -&gt; ClearHl7.Codes.V282.CodeProviderRole</para>
        /// </summary>
        public CodedWithExceptions RoleRol { get; set; }

        /// <summary>
        /// ROL.4 - Role Person.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> RolePerson { get; set; }

        /// <summary>
        /// ROL.5 - Role Begin Date/Time.
        /// </summary>
        public DateTime? RoleBeginDateTime { get; set; }

        /// <summary>
        /// ROL.6 - Role End Date/Time.
        /// </summary>
        public DateTime? RoleEndDateTime { get; set; }

        /// <summary>
        /// ROL.7 - Role Duration.
        /// </summary>
        public CodedWithExceptions RoleDuration { get; set; }

        /// <summary>
        /// ROL.8 - Role Action Reason.
        /// </summary>
        public CodedWithExceptions RoleActionReason { get; set; }

        /// <summary>
        /// ROL.9 - Provider Type.
        /// </summary>
        public IEnumerable<CodedWithExceptions> ProviderType { get; set; }

        /// <summary>
        /// ROL.10 - Organization Unit Type.
        /// <para>Suggested: 0406 Participant Organization Unit Type -&gt; ClearHl7.Codes.V282.CodeParticipantOrganizationUnitType</para>
        /// </summary>
        public CodedWithExceptions OrganizationUnitType { get; set; }

        /// <summary>
        /// ROL.11 - Office/Home Address/Birthplace.
        /// </summary>
        public IEnumerable<ExtendedAddress> OfficeHomeAddressBirthplace { get; set; }

        /// <summary>
        /// ROL.12 - Phone.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> Phone { get; set; }

        /// <summary>
        /// ROL.13 - Person's Location.
        /// </summary>
        public PersonLocation PersonsLocation { get; set; }

        /// <summary>
        /// ROL.14 - Organization.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations Organization { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);
            
            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            RoleInstanceId = segments.Length > 1 && segments[1].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[1], false, seps) : null;
            ActionCode = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            RoleRol = segments.Length > 3 && segments[3].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[3], false, seps) : null;
            RolePerson = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            RoleBeginDateTime = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDateTime() : null;
            RoleEndDateTime = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDateTime() : null;
            RoleDuration = segments.Length > 7 && segments[7].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[7], false, seps) : null;
            RoleActionReason = segments.Length > 8 && segments[8].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[8], false, seps) : null;
            ProviderType = segments.Length > 9 && segments[9].Length > 0 ? segments[9].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            OrganizationUnitType = segments.Length > 10 && segments[10].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[10], false, seps) : null;
            OfficeHomeAddressBirthplace = segments.Length > 11 && segments[11].Length > 0 ? segments[11].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedAddress>(x, false, seps)) : null;
            Phone = segments.Length > 12 && segments[12].Length > 0 ? segments[12].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false, seps)) : null;
            PersonsLocation = segments.Length > 13 && segments[13].Length > 0 ? TypeHelper.Deserialize<PersonLocation>(segments[13], false, seps) : null;
            Organization = segments.Length > 14 && segments[14].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments[14], false, seps) : null;
        }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 15, Configuration.FieldSeparator),
                                Id,
                                RoleInstanceId?.ToDelimitedString(),
                                ActionCode,
                                RoleRol?.ToDelimitedString(),
                                RolePerson != null ? string.Join(Configuration.FieldRepeatSeparator, RolePerson.Select(x => x.ToDelimitedString())) : null,
                                RoleBeginDateTime.HasValue ? RoleBeginDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                RoleEndDateTime.HasValue ? RoleEndDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                RoleDuration?.ToDelimitedString(),
                                RoleActionReason?.ToDelimitedString(),
                                ProviderType != null ? string.Join(Configuration.FieldRepeatSeparator, ProviderType.Select(x => x.ToDelimitedString())) : null,
                                OrganizationUnitType?.ToDelimitedString(),
                                OfficeHomeAddressBirthplace != null ? string.Join(Configuration.FieldRepeatSeparator, OfficeHomeAddressBirthplace.Select(x => x.ToDelimitedString())) : null,
                                Phone != null ? string.Join(Configuration.FieldRepeatSeparator, Phone.Select(x => x.ToDelimitedString())) : null,
                                PersonsLocation?.ToDelimitedString(),
                                Organization?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}