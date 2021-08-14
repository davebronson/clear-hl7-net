using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
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
        /// </summary>
        public string ActionCode { get; set; }

        /// <summary>
        /// ROL.3 - Role-ROL.
        /// <para>Suggested: 0443 Provider Role -&gt; ClearHl7.Codes.V290.CodeProviderRole</para>
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
        /// <para>Suggested: 0406 Participant Organization Unit Type -&gt; ClearHl7.Codes.V290.CodeParticipantOrganizationUnitType</para>
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
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());
            char[] separator = Configuration.FieldRepeatSeparator.ToCharArray();

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            RoleInstanceId = segments.Length > 1 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(1), false) : null;
            ActionCode = segments.ElementAtOrDefault(2);
            RoleRol = segments.Length > 3 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(3), false) : null;
            RolePerson = segments.Length > 4 ? segments.ElementAtOrDefault(4).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            RoleBeginDateTime = segments.ElementAtOrDefault(5)?.ToNullableDateTime();
            RoleEndDateTime = segments.ElementAtOrDefault(6)?.ToNullableDateTime();
            RoleDuration = segments.Length > 7 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(7), false) : null;
            RoleActionReason = segments.Length > 8 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(8), false) : null;
            ProviderType = segments.Length > 9 ? segments.ElementAtOrDefault(9).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            OrganizationUnitType = segments.Length > 10 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(10), false) : null;
            OfficeHomeAddressBirthplace = segments.Length > 11 ? segments.ElementAtOrDefault(11).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedAddress>(x, false)) : null;
            Phone = segments.Length > 12 ? segments.ElementAtOrDefault(12).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            PersonsLocation = segments.Length > 13 ? TypeHelper.Deserialize<PersonLocation>(segments.ElementAtOrDefault(13), false) : null;
            Organization = segments.Length > 14 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments.ElementAtOrDefault(14), false) : null;
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