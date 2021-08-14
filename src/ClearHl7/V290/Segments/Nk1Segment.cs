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
    /// HL7 Version 2 Segment NK1 - Next Of Kin   Associated Parties.
    /// </summary>
    public class Nk1Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "NK1";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// NK1.1 - Set ID - NK1.
        /// </summary>
        public uint? SetIdNk1 { get; set; }

        /// <summary>
        /// NK1.2 - Name.
        /// <para>Suggested: 0200 Name Type -&gt; ClearHl7.Codes.V290.CodeNameType</para>
        /// </summary>
        public IEnumerable<ExtendedPersonName> Name { get; set; }

        /// <summary>
        /// NK1.3 - Relationship.
        /// <para>Suggested: 0063 Relationship -&gt; ClearHl7.Codes.V290.CodeRelationship</para>
        /// </summary>
        public CodedWithExceptions Relationship { get; set; }

        /// <summary>
        /// NK1.4 - Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> Address { get; set; }

        /// <summary>
        /// NK1.5 - Phone Number.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> PhoneNumber { get; set; }

        /// <summary>
        /// NK1.6 - Business Phone Number.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> BusinessPhoneNumber { get; set; }

        /// <summary>
        /// NK1.7 - Contact Role.
        /// <para>Suggested: 0131 Contact Role -&gt; ClearHl7.Codes.V290.CodeContactRole</para>
        /// </summary>
        public CodedWithExceptions ContactRole { get; set; }

        /// <summary>
        /// NK1.8 - Start Date.
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// NK1.9 - End Date.
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// NK1.10 - Next of Kin / Associated Parties Job Title.
        /// </summary>
        public string NextOfKinAssociatedPartiesJobTitle { get; set; }

        /// <summary>
        /// NK1.11 - Next of Kin / Associated Parties Job Code/Class.
        /// </summary>
        public JobCodeClass NextOfKinAssociatedPartiesJobCodeClass { get; set; }

        /// <summary>
        /// NK1.12 - Next of Kin / Associated Parties Employee Number.
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit NextOfKinAssociatedPartiesEmployeeNumber { get; set; }

        /// <summary>
        /// NK1.13 - Organization Name - NK1.
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> OrganizationNameNk1 { get; set; }

        /// <summary>
        /// NK1.14 - Marital Status.
        /// <para>Suggested: 0002 Marital Status -&gt; ClearHl7.Codes.V290.CodeMaritalStatus</para>
        /// </summary>
        public CodedWithExceptions MaritalStatus { get; set; }

        /// <summary>
        /// NK1.15 - Administrative Sex.
        /// <para>Suggested: 0001 Administrative Sex -&gt; ClearHl7.Codes.V290.CodeAdministrativeSex</para>
        /// </summary>
        public CodedWithExceptions AdministrativeSex { get; set; }

        /// <summary>
        /// NK1.16 - Date/Time of Birth.
        /// </summary>
        public DateTime? DateTimeOfBirth { get; set; }

        /// <summary>
        /// NK1.17 - Living Dependency.
        /// <para>Suggested: 0223 Living Dependency -&gt; ClearHl7.Codes.V290.CodeLivingDependency</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> LivingDependency { get; set; }

        /// <summary>
        /// NK1.18 - Ambulatory Status.
        /// <para>Suggested: 0009 Ambulatory Status -&gt; ClearHl7.Codes.V290.CodeAmbulatoryStatus</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> AmbulatoryStatus { get; set; }

        /// <summary>
        /// NK1.19 - Citizenship.
        /// <para>Suggested: 0171 Citizenship</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> Citizenship { get; set; }

        /// <summary>
        /// NK1.20 - Primary Language.
        /// <para>Suggested: 0296 Primary Language</para>
        /// </summary>
        public CodedWithExceptions PrimaryLanguage { get; set; }

        /// <summary>
        /// NK1.21 - Living Arrangement.
        /// <para>Suggested: 0220 Living Arrangement -&gt; ClearHl7.Codes.V290.CodeLivingArrangement</para>
        /// </summary>
        public CodedWithExceptions LivingArrangement { get; set; }

        /// <summary>
        /// NK1.22 - Publicity Code.
        /// <para>Suggested: 0215 Publicity Code -&gt; ClearHl7.Codes.V290.CodePublicityCode</para>
        /// </summary>
        public CodedWithExceptions PublicityCode { get; set; }

        /// <summary>
        /// NK1.23 - Protection Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public string ProtectionIndicator { get; set; }

        /// <summary>
        /// NK1.24 - Student Indicator.
        /// <para>Suggested: 0231 Student Status -&gt; ClearHl7.Codes.V290.CodeStudentStatus</para>
        /// </summary>
        public CodedWithExceptions StudentIndicator { get; set; }

        /// <summary>
        /// NK1.25 - Religion.
        /// <para>Suggested: 0006 Religion -&gt; ClearHl7.Codes.V290.CodeReligion</para>
        /// </summary>
        public CodedWithExceptions Religion { get; set; }

        /// <summary>
        /// NK1.26 - Mother's Maiden Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> MothersMaidenName { get; set; }

        /// <summary>
        /// NK1.27 - Nationality.
        /// <para>Suggested: 0212 Nationality</para>
        /// </summary>
        public CodedWithExceptions Nationality { get; set; }

        /// <summary>
        /// NK1.28 - Ethnic Group.
        /// <para>Suggested: 0189 Ethnic Group -&gt; ClearHl7.Codes.V290.CodeEthnicGroup</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> EthnicGroup { get; set; }

        /// <summary>
        /// NK1.29 - Contact Reason.
        /// <para>Suggested: 0222 Contact Reason</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ContactReason { get; set; }

        /// <summary>
        /// NK1.30 - Contact Person's Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> ContactPersonsName { get; set; }

        /// <summary>
        /// NK1.31 - Contact Person's Telephone Number.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> ContactPersonsTelephoneNumber { get; set; }

        /// <summary>
        /// NK1.32 - Contact Person's Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> ContactPersonsAddress { get; set; }

        /// <summary>
        /// NK1.33 - Next of Kin/Associated Party's Identifiers.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> NextOfKinAssociatedPartysIdentifiers { get; set; }

        /// <summary>
        /// NK1.34 - Job Status.
        /// <para>Suggested: 0311 Job Status -&gt; ClearHl7.Codes.V290.CodeJobStatus</para>
        /// </summary>
        public CodedWithExceptions JobStatus { get; set; }

        /// <summary>
        /// NK1.35 - Race.
        /// <para>Suggested: 0005 Race -&gt; ClearHl7.Codes.V290.CodeRace</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> Race { get; set; }

        /// <summary>
        /// NK1.36 - Handicap.
        /// <para>Suggested: 0295 Handicap</para>
        /// </summary>
        public CodedWithExceptions Handicap { get; set; }

        /// <summary>
        /// NK1.37 - Contact Person Social Security Number.
        /// </summary>
        public string ContactPersonSocialSecurityNumber { get; set; }

        /// <summary>
        /// NK1.38 - Next of Kin Birth Place.
        /// </summary>
        public string NextOfKinBirthPlace { get; set; }

        /// <summary>
        /// NK1.39 - VIP Indicator.
        /// <para>Suggested: 0099 VIP Indicator</para>
        /// </summary>
        public CodedWithExceptions VipIndicator { get; set; }

        /// <summary>
        /// NK1.40 - Next of Kin Telecommunication Information.
        /// </summary>
        public ExtendedTelecommunicationNumber NextOfKinTelecommunicationInformation { get; set; }

        /// <summary>
        /// NK1.41 - Contact Person's Telecommunication Information.
        /// </summary>
        public ExtendedTelecommunicationNumber ContactPersonsTelecommunicationInformation { get; set; }

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

            SetIdNk1 = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            Name = segments.Length > 2 ? segments.ElementAtOrDefault(2).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedPersonName>(x, false)) : null;
            Relationship = segments.Length > 3 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(3), false) : null;
            Address = segments.Length > 4 ? segments.ElementAtOrDefault(4).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedAddress>(x, false)) : null;
            PhoneNumber = segments.Length > 5 ? segments.ElementAtOrDefault(5).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            BusinessPhoneNumber = segments.Length > 6 ? segments.ElementAtOrDefault(6).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            ContactRole = segments.Length > 7 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(7), false) : null;
            StartDate = segments.ElementAtOrDefault(8)?.ToNullableDateTime();
            EndDate = segments.ElementAtOrDefault(9)?.ToNullableDateTime();
            NextOfKinAssociatedPartiesJobTitle = segments.ElementAtOrDefault(10);
            NextOfKinAssociatedPartiesJobCodeClass = segments.Length > 11 ? TypeHelper.Deserialize<JobCodeClass>(segments.ElementAtOrDefault(11), false) : null;
            NextOfKinAssociatedPartiesEmployeeNumber = segments.Length > 12 ? TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments.ElementAtOrDefault(12), false) : null;
            OrganizationNameNk1 = segments.Length > 13 ? segments.ElementAtOrDefault(13).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false)) : null;
            MaritalStatus = segments.Length > 14 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(14), false) : null;
            AdministrativeSex = segments.Length > 15 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(15), false) : null;
            DateTimeOfBirth = segments.ElementAtOrDefault(16)?.ToNullableDateTime();
            LivingDependency = segments.Length > 17 ? segments.ElementAtOrDefault(17).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            AmbulatoryStatus = segments.Length > 18 ? segments.ElementAtOrDefault(18).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            Citizenship = segments.Length > 19 ? segments.ElementAtOrDefault(19).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            PrimaryLanguage = segments.Length > 20 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(20), false) : null;
            LivingArrangement = segments.Length > 21 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(21), false) : null;
            PublicityCode = segments.Length > 22 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(22), false) : null;
            ProtectionIndicator = segments.ElementAtOrDefault(23);
            StudentIndicator = segments.Length > 24 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(24), false) : null;
            Religion = segments.Length > 25 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(25), false) : null;
            MothersMaidenName = segments.Length > 26 ? segments.ElementAtOrDefault(26).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedPersonName>(x, false)) : null;
            Nationality = segments.Length > 27 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(27), false) : null;
            EthnicGroup = segments.Length > 28 ? segments.ElementAtOrDefault(28).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            ContactReason = segments.Length > 29 ? segments.ElementAtOrDefault(29).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            ContactPersonsName = segments.Length > 30 ? segments.ElementAtOrDefault(30).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedPersonName>(x, false)) : null;
            ContactPersonsTelephoneNumber = segments.Length > 31 ? segments.ElementAtOrDefault(31).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            ContactPersonsAddress = segments.Length > 32 ? segments.ElementAtOrDefault(3).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedAddress>(x, false)) : null;
            NextOfKinAssociatedPartysIdentifiers = segments.Length > 33 ? segments.ElementAtOrDefault(33).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false)) : null;
            JobStatus = segments.Length > 34 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(34), false) : null;
            Race = segments.Length > 35 ? segments.ElementAtOrDefault(35).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            Handicap = segments.Length > 36 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(36), false) : null;
            ContactPersonSocialSecurityNumber = segments.ElementAtOrDefault(37);
            NextOfKinBirthPlace = segments.ElementAtOrDefault(38);
            VipIndicator = segments.Length > 39 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(39), false) : null;
            NextOfKinTelecommunicationInformation = segments.Length > 40 ? TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(segments.ElementAtOrDefault(40), false) : null;
            ContactPersonsTelecommunicationInformation = segments.Length > 41 ? TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(segments.ElementAtOrDefault(41), false) : null;
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
                                StringHelper.StringFormatSequence(0, 42, Configuration.FieldSeparator),
                                Id,
                                SetIdNk1.HasValue ? SetIdNk1.Value.ToString(culture) : null,
                                Name != null ? string.Join(Configuration.FieldRepeatSeparator, Name.Select(x => x.ToDelimitedString())) : null,
                                Relationship?.ToDelimitedString(),
                                Address != null ? string.Join(Configuration.FieldRepeatSeparator, Address.Select(x => x.ToDelimitedString())) : null,
                                PhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, PhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                BusinessPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, BusinessPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                ContactRole?.ToDelimitedString(),
                                StartDate.HasValue ? StartDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                EndDate.HasValue ? EndDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                NextOfKinAssociatedPartiesJobTitle,
                                NextOfKinAssociatedPartiesJobCodeClass?.ToDelimitedString(),
                                NextOfKinAssociatedPartiesEmployeeNumber?.ToDelimitedString(),
                                OrganizationNameNk1 != null ? string.Join(Configuration.FieldRepeatSeparator, OrganizationNameNk1.Select(x => x.ToDelimitedString())) : null,
                                MaritalStatus?.ToDelimitedString(),
                                AdministrativeSex?.ToDelimitedString(),
                                DateTimeOfBirth.HasValue ? DateTimeOfBirth.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                LivingDependency != null ? string.Join(Configuration.FieldRepeatSeparator, LivingDependency.Select(x => x.ToDelimitedString())) : null,
                                AmbulatoryStatus != null ? string.Join(Configuration.FieldRepeatSeparator, AmbulatoryStatus.Select(x => x.ToDelimitedString())) : null,
                                Citizenship != null ? string.Join(Configuration.FieldRepeatSeparator, Citizenship.Select(x => x.ToDelimitedString())) : null,
                                PrimaryLanguage?.ToDelimitedString(),
                                LivingArrangement?.ToDelimitedString(),
                                PublicityCode?.ToDelimitedString(),
                                ProtectionIndicator,
                                StudentIndicator?.ToDelimitedString(),
                                Religion?.ToDelimitedString(),
                                MothersMaidenName != null ? string.Join(Configuration.FieldRepeatSeparator, MothersMaidenName.Select(x => x.ToDelimitedString())) : null,
                                Nationality?.ToDelimitedString(),
                                EthnicGroup != null ? string.Join(Configuration.FieldRepeatSeparator, EthnicGroup.Select(x => x.ToDelimitedString())) : null,
                                ContactReason != null ? string.Join(Configuration.FieldRepeatSeparator, ContactReason.Select(x => x.ToDelimitedString())) : null,
                                ContactPersonsName != null ? string.Join(Configuration.FieldRepeatSeparator, ContactPersonsName.Select(x => x.ToDelimitedString())) : null,
                                ContactPersonsTelephoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, ContactPersonsTelephoneNumber.Select(x => x.ToDelimitedString())) : null,
                                ContactPersonsAddress != null ? string.Join(Configuration.FieldRepeatSeparator, ContactPersonsAddress.Select(x => x.ToDelimitedString())) : null,
                                NextOfKinAssociatedPartysIdentifiers != null ? string.Join(Configuration.FieldRepeatSeparator, NextOfKinAssociatedPartysIdentifiers.Select(x => x.ToDelimitedString())) : null,
                                JobStatus?.ToDelimitedString(),
                                Race != null ? string.Join(Configuration.FieldRepeatSeparator, Race.Select(x => x.ToDelimitedString())) : null,
                                Handicap?.ToDelimitedString(),
                                ContactPersonSocialSecurityNumber,
                                NextOfKinBirthPlace,
                                VipIndicator?.ToDelimitedString(),
                                NextOfKinTelecommunicationInformation?.ToDelimitedString(),
                                ContactPersonsTelecommunicationInformation?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}