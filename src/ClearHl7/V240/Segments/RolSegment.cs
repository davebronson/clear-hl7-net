using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V240.Types;

namespace ClearHl7.V240.Segments
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
        /// <para>Suggested: 0287 Problem/Goal Action Code -&gt; ClearHl7.Codes.V240.CodeProblemGoalActionCode</para>
        /// </summary>
        public string ActionCode { get; set; }

        /// <summary>
        /// ROL.3 - Role-ROL.
        /// <para>Suggested: 0443 Provider Role -&gt; ClearHl7.Codes.V240.CodeProviderRole</para>
        /// </summary>
        public CodedElement RoleRol { get; set; }

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
        public CodedElement RoleDuration { get; set; }

        /// <summary>
        /// ROL.8 - Role Action Reason.
        /// </summary>
        public CodedElement RoleActionReason { get; set; }

        /// <summary>
        /// ROL.9 - Provider Type.
        /// </summary>
        public IEnumerable<CodedElement> ProviderType { get; set; }

        /// <summary>
        /// ROL.10 - Organization Unit Type.
        /// <para>Suggested: 0406 Participant Organization Unit Type -&gt; ClearHl7.Codes.V240.CodeParticipantOrganizationUnitType</para>
        /// </summary>
        public CodedElement OrganizationUnitType { get; set; }

        /// <summary>
        /// ROL.11 - Office/Home Address/Birthplace.
        /// </summary>
        public IEnumerable<ExtendedAddress> OfficeHomeAddressBirthplace { get; set; }

        /// <summary>
        /// ROL.12 - Phone.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> Phone { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 13, Configuration.FieldSeparator),
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
                                Phone != null ? string.Join(Configuration.FieldRepeatSeparator, Phone.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}