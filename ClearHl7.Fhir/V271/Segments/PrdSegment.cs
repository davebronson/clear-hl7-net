using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V271.Types;

namespace ClearHl7.Fhir.V271.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0286</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0185</remarks>
        public CodedWithExceptions PreferredMethodOfContact { get; set; }

        /// <summary>
        /// PRD.7 - Provider Identifiers.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0338</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0185</remarks>
        public CodedWithExceptions ProviderOrganizationMethodOfContact { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}",
                                Id,
                                ProviderRole != null ? string.Join("~", ProviderRole.Select(x => x.ToDelimitedString())) : null,
                                ProviderName != null ? string.Join("~", ProviderName.Select(x => x.ToDelimitedString())) : null,
                                ProviderAddress != null ? string.Join("~", ProviderAddress.Select(x => x.ToDelimitedString())) : null,
                                ProviderLocation?.ToDelimitedString(),
                                ProviderCommunicationInformation != null ? string.Join("~", ProviderCommunicationInformation.Select(x => x.ToDelimitedString())) : null,
                                PreferredMethodOfContact?.ToDelimitedString(),
                                ProviderIdentifiers != null ? string.Join("~", ProviderIdentifiers.Select(x => x.ToDelimitedString())) : null,
                                EffectiveStartDateOfProviderRole.HasValue ? EffectiveStartDateOfProviderRole.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EffectiveEndDateOfProviderRole != null ? string.Join("~", EffectiveEndDateOfProviderRole.Select(x => x.ToString(Consts.DateTimeFormatPrecisionSecond, culture))) : null,
                                ProviderOrganizationNameAndIdentifier?.ToDelimitedString(),
                                ProviderOrganizationAddress != null ? string.Join("~", ProviderOrganizationAddress.Select(x => x.ToDelimitedString())) : null,
                                ProviderOrganizationLocationInformation != null ? string.Join("~", ProviderOrganizationLocationInformation.Select(x => x.ToDelimitedString())) : null,
                                ProviderOrganizationCommunicationInformation != null ? string.Join("~", ProviderOrganizationCommunicationInformation.Select(x => x.ToDelimitedString())) : null,
                                ProviderOrganizationMethodOfContact?.ToDelimitedString()
                                ).TrimEnd('|');
        }
    }
}