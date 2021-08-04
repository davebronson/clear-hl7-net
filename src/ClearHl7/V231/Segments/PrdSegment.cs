using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V231.Types;

namespace ClearHl7.V231.Segments
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
        /// <para>Suggested: 0286 Provider Role -&gt; ClearHl7.Codes.V231.CodeProviderRole</para>
        /// </summary>
        public IEnumerable<CodedElement> ProviderRole { get; set; }

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
        /// <para>Suggested: 0185 Preferred Method Of Contact -&gt; ClearHl7.Codes.V231.CodePreferredMethodOfContact</para>
        /// </summary>
        public CodedElement PreferredMethodOfContact { get; set; }

        /// <summary>
        /// PRD.7 - Provider Identifiers.
        /// </summary>
        public IEnumerable<PractitionerLicenseOrOtherIdNumber> ProviderIdentifiers { get; set; }

        /// <summary>
        /// PRD.8 - Effective Start Date of Provider Role.
        /// </summary>
        public DateTime? EffectiveStartDateOfProviderRole { get; set; }

        /// <summary>
        /// PRD.9 - Effective End Date of Provider Role.
        /// </summary>
        public DateTime? EffectiveEndDateOfProviderRole { get; set; }

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

            ProviderRole = segments.Length > 1 ? segments.ElementAtOrDefault(1).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            ProviderName = segments.Length > 2 ? segments.ElementAtOrDefault(2).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedPersonName>(x, false)) : null;
            ProviderAddress = segments.Length > 3 ? segments.ElementAtOrDefault(3).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedAddress>(x, false)) : null;
            ProviderLocation = segments.Length > 4 ? TypeHelper.Deserialize<PersonLocation>(segments.ElementAtOrDefault(4), false) : null;
            ProviderCommunicationInformation = segments.Length > 5 ? segments.ElementAtOrDefault(5).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            PreferredMethodOfContact = segments.Length > 6 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(6), false) : null;
            ProviderIdentifiers = segments.Length > 7 ? segments.ElementAtOrDefault(7).Split(separator).Select(x => TypeHelper.Deserialize<PractitionerLicenseOrOtherIdNumber>(x, false)) : null;
            EffectiveStartDateOfProviderRole = segments.ElementAtOrDefault(8)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            EffectiveEndDateOfProviderRole = segments.ElementAtOrDefault(9)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
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
                                StringHelper.StringFormatSequence(0, 10, Configuration.FieldSeparator),
                                Id,
                                ProviderRole != null ? string.Join(Configuration.FieldRepeatSeparator, ProviderRole.Select(x => x.ToDelimitedString())) : null,
                                ProviderName != null ? string.Join(Configuration.FieldRepeatSeparator, ProviderName.Select(x => x.ToDelimitedString())) : null,
                                ProviderAddress != null ? string.Join(Configuration.FieldRepeatSeparator, ProviderAddress.Select(x => x.ToDelimitedString())) : null,
                                ProviderLocation?.ToDelimitedString(),
                                ProviderCommunicationInformation != null ? string.Join(Configuration.FieldRepeatSeparator, ProviderCommunicationInformation.Select(x => x.ToDelimitedString())) : null,
                                PreferredMethodOfContact?.ToDelimitedString(),
                                ProviderIdentifiers != null ? string.Join(Configuration.FieldRepeatSeparator, ProviderIdentifiers.Select(x => x.ToDelimitedString())) : null,
                                EffectiveStartDateOfProviderRole.HasValue ? EffectiveStartDateOfProviderRole.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EffectiveEndDateOfProviderRole.HasValue ? EffectiveEndDateOfProviderRole.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}