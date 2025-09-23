using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PRD - Provider Data.
    /// </summary>
    public class PrdSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrdSegment"/> class.
        /// </summary>
        public PrdSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrdSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public PrdSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "PRD";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// PRD.1 - Provider Role.
        /// <para>Suggested: 0286 Provider Role</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ProviderRole { get; set; }

        /// <summary>
        /// PRD.2 - Provider Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> ProviderName { get; set; }

        /// <summary>
        /// PRD.3 - Provider Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> ProviderAddress { get; set; }

        /// <summary>
        /// PRD.4 - Provider Location.
        /// </summary>
        public PersonLocation ProviderLocation { get; set; }

        /// <summary>
        /// PRD.5 - Provider Communication Information.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> ProviderCommunicationInformation { get; set; }

        /// <summary>
        /// PRD.6 - Preferred Method of Contact.
        /// <para>Suggested: 0185 Preferred Method Of Contact -&gt; ClearHl7.Codes.V281.CodePreferredMethodOfContact</para>
        /// </summary>
        public CodedWithExceptions PreferredMethodOfContact { get; set; }

        /// <summary>
        /// PRD.7 - Provider Identifiers.
        /// <para>Suggested: 0338 Practitioner ID Number Type -&gt; ClearHl7.Codes.V281.CodePractitionerIdNumberType</para>
        /// </summary>
        public IEnumerable<PractitionerLicenseOrOtherIdNumber> ProviderIdentifiers { get; set; }

        /// <summary>
        /// PRD.8 - Effective Start Date of Provider Role.
        /// </summary>
        public DateTime? EffectiveStartDateOfProviderRole { get; set; }

        /// <summary>
        /// PRD.9 - Effective End Date of Provider Role.
        /// </summary>
        public IEnumerable<DateTime> EffectiveEndDateOfProviderRole { get; set; }

        /// <summary>
        /// PRD.10 - Provider Organization Name and Identifier.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations ProviderOrganizationNameAndIdentifier { get; set; }

        /// <summary>
        /// PRD.11 - Provider Organization Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> ProviderOrganizationAddress { get; set; }

        /// <summary>
        /// PRD.12 - Provider Organization Location Information.
        /// </summary>
        public IEnumerable<PersonLocation> ProviderOrganizationLocationInformation { get; set; }

        /// <summary>
        /// PRD.13 - Provider Organization Communication Information.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> ProviderOrganizationCommunicationInformation { get; set; }

        /// <summary>
        /// PRD.14 - Provider Organization Method of Contact.
        /// <para>Suggested: 0185 Preferred Method Of Contact -&gt; ClearHl7.Codes.V281.CodePreferredMethodOfContact</para>
        /// </summary>
        public CodedWithExceptions ProviderOrganizationMethodOfContact { get; set; }

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
                if (!string.Equals(Id, segments[0], StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            ProviderRole = segments.Length > 1 && segments[1].Length > 0 ? segments[1].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            ProviderName = segments.Length > 2 && segments[2].Length > 0 ? segments[2].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedPersonName>(x, false, seps)) : null;
            ProviderAddress = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedAddress>(x, false, seps)) : null;
            ProviderLocation = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<PersonLocation>(segments[4], false, seps) : null;
            ProviderCommunicationInformation = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedTelecommunicationNumber>(x, false, seps)) : null;
            PreferredMethodOfContact = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[6], false, seps) : null;
            ProviderIdentifiers = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<PractitionerLicenseOrOtherIdNumber>(x, false, seps)) : null;
            EffectiveStartDateOfProviderRole = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDateTime() : null;
            EffectiveEndDateOfProviderRole = segments.Length > 9 && segments[9].Length > 0 ? segments[9].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => x.ToDateTime()) : null;
            ProviderOrganizationNameAndIdentifier = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments[10], false, seps) : null;
            ProviderOrganizationAddress = segments.Length > 11 && segments[11].Length > 0 ? segments[11].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedAddress>(x, false, seps)) : null;
            ProviderOrganizationLocationInformation = segments.Length > 12 && segments[12].Length > 0 ? segments[12].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<PersonLocation>(x, false, seps)) : null;
            ProviderOrganizationCommunicationInformation = segments.Length > 13 && segments[13].Length > 0 ? segments[13].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedTelecommunicationNumber>(x, false, seps)) : null;
            ProviderOrganizationMethodOfContact = segments.Length > 14 && segments[14].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[14], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 15, Configuration.FieldSeparator),
                                Id,
                                ProviderRole != null ? string.Join(Configuration.FieldRepeatSeparator, ProviderRole.Select(x => x.ToDelimitedString())) : null,
                                ProviderName != null ? string.Join(Configuration.FieldRepeatSeparator, ProviderName.Select(x => x.ToDelimitedString())) : null,
                                ProviderAddress != null ? string.Join(Configuration.FieldRepeatSeparator, ProviderAddress.Select(x => x.ToDelimitedString())) : null,
                                ProviderLocation?.ToDelimitedString(),
                                ProviderCommunicationInformation != null ? string.Join(Configuration.FieldRepeatSeparator, ProviderCommunicationInformation.Select(x => x.ToDelimitedString())) : null,
                                PreferredMethodOfContact?.ToDelimitedString(),
                                ProviderIdentifiers != null ? string.Join(Configuration.FieldRepeatSeparator, ProviderIdentifiers.Select(x => x.ToDelimitedString())) : null,
                                EffectiveStartDateOfProviderRole.ToHl7DateTimeString(typeof(PrdSegment), nameof(EffectiveStartDateOfProviderRole), Consts.DateTimeFormatPrecisionSecond, culture),
                                EffectiveEndDateOfProviderRole != null ? string.Join(Configuration.FieldRepeatSeparator, EffectiveEndDateOfProviderRole.Select(x => x.ToString(Consts.DateTimeFormatPrecisionSecond, culture))) : null,
                                ProviderOrganizationNameAndIdentifier?.ToDelimitedString(),
                                ProviderOrganizationAddress != null ? string.Join(Configuration.FieldRepeatSeparator, ProviderOrganizationAddress.Select(x => x.ToDelimitedString())) : null,
                                ProviderOrganizationLocationInformation != null ? string.Join(Configuration.FieldRepeatSeparator, ProviderOrganizationLocationInformation.Select(x => x.ToDelimitedString())) : null,
                                ProviderOrganizationCommunicationInformation != null ? string.Join(Configuration.FieldRepeatSeparator, ProviderOrganizationCommunicationInformation.Select(x => x.ToDelimitedString())) : null,
                                ProviderOrganizationMethodOfContact?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
