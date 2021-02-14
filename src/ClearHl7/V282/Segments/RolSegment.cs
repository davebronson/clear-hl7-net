using System;
using System.Collections.Generic;
using System.Linq;
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
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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