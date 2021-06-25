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
    /// HL7 Version 2 Segment PRD - Provider Data.
    /// </summary>
    public class PrdSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PRD";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// PRD.1 - Provider Role.
        /// <para>Suggested: 0286 Provider Role -&gt; ClearHl7.Codes.V290.CodeProviderRole</para>
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
        /// <para>Suggested: 0185 Preferred Method Of Contact -&gt; ClearHl7.Codes.V290.CodePreferredMethodOfContact</para>
        /// </summary>
        public CodedWithExceptions PreferredMethodOfContact { get; set; }

        /// <summary>
        /// PRD.7 - Provider Identifiers.
        /// <para>Suggested: 0338 Practitioner ID Number Type -&gt; ClearHl7.Codes.V290.CodePractitionerIdNumberType</para>
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
        /// <para>Suggested: 0185 Preferred Method Of Contact -&gt; ClearHl7.Codes.V290.CodePreferredMethodOfContact</para>
        /// </summary>
        public CodedWithExceptions ProviderOrganizationMethodOfContact { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public PrdSegment FromDelimitedString(string delimitedString)
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

            ProviderRole = segments.Length > 1 ? segments.ElementAtOrDefault(1).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            ProviderName = segments.Length > 2 ? segments.ElementAtOrDefault(2).Split(separator).Select(x => new ExtendedPersonName().FromDelimitedString(x)) : null;
            ProviderAddress = segments.Length > 3 ? segments.ElementAtOrDefault(3).Split(separator).Select(x => new ExtendedAddress().FromDelimitedString(x)) : null;
            ProviderLocation = segments.Length > 4 ? new PersonLocation().FromDelimitedString(segments.ElementAtOrDefault(4)) : null;
            ProviderCommunicationInformation = segments.Length > 5 ? segments.ElementAtOrDefault(5).Split(separator).Select(x => new ExtendedTelecommunicationNumber().FromDelimitedString(x)) : null;
            PreferredMethodOfContact = segments.Length > 6 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(6)) : null;
            ProviderIdentifiers = segments.Length > 7 ? segments.ElementAtOrDefault(7).Split(separator).Select(x => new PractitionerLicenseOrOtherIdNumber().FromDelimitedString(x)) : null;
            EffectiveStartDateOfProviderRole = segments.ElementAtOrDefault(8)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            EffectiveEndDateOfProviderRole = segments.Length > 9 ? segments.ElementAtOrDefault(9).Split(separator).Select(x => x.ToDateTime(Consts.DateTimeFormatPrecisionSecond)) : null;
            ProviderOrganizationNameAndIdentifier = segments.Length > 10 ? new ExtendedCompositeNameAndIdNumberForOrganizations().FromDelimitedString(segments.ElementAtOrDefault(10)) : null;
            ProviderOrganizationAddress = segments.Length > 11 ? segments.ElementAtOrDefault(11).Split(separator).Select(x => new ExtendedAddress().FromDelimitedString(x)) : null;
            ProviderOrganizationLocationInformation = segments.Length > 12 ? segments.ElementAtOrDefault(12).Split(separator).Select(x => new PersonLocation().FromDelimitedString(x)) : null;
            ProviderOrganizationCommunicationInformation = segments.Length > 13 ? segments.ElementAtOrDefault(13).Split(separator).Select(x => new ExtendedTelecommunicationNumber().FromDelimitedString(x)) : null;
            ProviderOrganizationMethodOfContact = segments.Length > 14 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(14)) : null;
            
            return this;
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
                                ProviderRole != null ? string.Join(Configuration.FieldRepeatSeparator, ProviderRole.Select(x => x.ToDelimitedString())) : null,
                                ProviderName != null ? string.Join(Configuration.FieldRepeatSeparator, ProviderName.Select(x => x.ToDelimitedString())) : null,
                                ProviderAddress != null ? string.Join(Configuration.FieldRepeatSeparator, ProviderAddress.Select(x => x.ToDelimitedString())) : null,
                                ProviderLocation?.ToDelimitedString(),
                                ProviderCommunicationInformation != null ? string.Join(Configuration.FieldRepeatSeparator, ProviderCommunicationInformation.Select(x => x.ToDelimitedString())) : null,
                                PreferredMethodOfContact?.ToDelimitedString(),
                                ProviderIdentifiers != null ? string.Join(Configuration.FieldRepeatSeparator, ProviderIdentifiers.Select(x => x.ToDelimitedString())) : null,
                                EffectiveStartDateOfProviderRole.HasValue ? EffectiveStartDateOfProviderRole.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
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