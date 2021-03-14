using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V231.Types;

namespace ClearHl7.V231.Segments
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
        /// </summary>
        public IEnumerable<ExtendedPersonName> Name { get; set; }

        /// <summary>
        /// NK1.3 - Relationship.
        /// <para>Suggested: 0063 Relationship</para>
        /// </summary>
        public CodedElement Relationship { get; set; }

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
        /// <para>Suggested: 0131 Contact Role</para>
        /// </summary>
        public CodedElement ContactRole { get; set; }

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
        /// <para>Suggested: 0002 Marital Status -&gt; ClearHl7.Codes.V231.CodeMaritalStatus</para>
        /// </summary>
        public CodedElement MaritalStatus { get; set; }

        /// <summary>
        /// NK1.15 - Administrative Sex.
        /// <para>Suggested: 0001 Administrative Sex -&gt; ClearHl7.Codes.V231.CodeAdministrativeSex</para>
        /// </summary>
        public string AdministrativeSex { get; set; }

        /// <summary>
        /// NK1.16 - Date/Time of Birth.
        /// </summary>
        public DateTime? DateTimeOfBirth { get; set; }

        /// <summary>
        /// NK1.17 - Living Dependency.
        /// <para>Suggested: 0223 Living Dependency -&gt; ClearHl7.Codes.V231.CodeLivingDependency</para>
        /// </summary>
        public IEnumerable<string> LivingDependency { get; set; }

        /// <summary>
        /// NK1.18 - Ambulatory Status.
        /// <para>Suggested: 0009 Ambulatory Status -&gt; ClearHl7.Codes.V231.CodeAmbulatoryStatus</para>
        /// </summary>
        public IEnumerable<string> AmbulatoryStatus { get; set; }

        /// <summary>
        /// NK1.19 - Citizenship.
        /// <para>Suggested: 0171 Citizenship</para>
        /// </summary>
        public IEnumerable<CodedElement> Citizenship { get; set; }

        /// <summary>
        /// NK1.20 - Primary Language.
        /// <para>Suggested: 0296 Primary Language</para>
        /// </summary>
        public CodedElement PrimaryLanguage { get; set; }

        /// <summary>
        /// NK1.21 - Living Arrangement.
        /// <para>Suggested: 0220 Living Arrangement -&gt; ClearHl7.Codes.V231.CodeLivingArrangement</para>
        /// </summary>
        public string LivingArrangement { get; set; }

        /// <summary>
        /// NK1.22 - Publicity Code.
        /// <para>Suggested: 0215 Publicity Code</para>
        /// </summary>
        public CodedElement PublicityCode { get; set; }

        /// <summary>
        /// NK1.23 - Protection Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V231.CodeYesNoIndicator</para>
        /// </summary>
        public string ProtectionIndicator { get; set; }

        /// <summary>
        /// NK1.24 - Student Indicator.
        /// <para>Suggested: 0231 Student Status -&gt; ClearHl7.Codes.V231.CodeStudentStatus</para>
        /// </summary>
        public string StudentIndicator { get; set; }

        /// <summary>
        /// NK1.25 - Religion.
        /// <para>Suggested: 0006 Religion -&gt; ClearHl7.Codes.V231.CodeReligion</para>
        /// </summary>
        public CodedElement Religion { get; set; }

        /// <summary>
        /// NK1.26 - Mother's Maiden Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> MothersMaidenName { get; set; }

        /// <summary>
        /// NK1.27 - Nationality.
        /// <para>Suggested: 0212 Nationality</para>
        /// </summary>
        public CodedElement Nationality { get; set; }

        /// <summary>
        /// NK1.28 - Ethnic Group.
        /// <para>Suggested: 0189 Ethnic Group</para>
        /// </summary>
        public IEnumerable<CodedElement> EthnicGroup { get; set; }

        /// <summary>
        /// NK1.29 - Contact Reason.
        /// <para>Suggested: 0222 Contact Reason</para>
        /// </summary>
        public IEnumerable<CodedElement> ContactReason { get; set; }

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
        /// <para>Suggested: 0311 Job Status</para>
        /// </summary>
        public string JobStatus { get; set; }

        /// <summary>
        /// NK1.35 - Race.
        /// <para>Suggested: 0005 Race -&gt; ClearHl7.Codes.V231.CodeRace</para>
        /// </summary>
        public IEnumerable<CodedElement> Race { get; set; }

        /// <summary>
        /// NK1.36 - Handicap.
        /// <para>Suggested: 0295 Handicap</para>
        /// </summary>
        public string Handicap { get; set; }

        /// <summary>
        /// NK1.37 - Contact Person Social Security Number.
        /// </summary>
        public string ContactPersonSocialSecurityNumber { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 38, Configuration.FieldSeparator),
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
                                AdministrativeSex,
                                DateTimeOfBirth.HasValue ? DateTimeOfBirth.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                LivingDependency != null ? string.Join(Configuration.FieldRepeatSeparator, LivingDependency) : null,
                                AmbulatoryStatus != null ? string.Join(Configuration.FieldRepeatSeparator, AmbulatoryStatus) : null,
                                Citizenship != null ? string.Join(Configuration.FieldRepeatSeparator, Citizenship.Select(x => x.ToDelimitedString())) : null,
                                PrimaryLanguage?.ToDelimitedString(),
                                LivingArrangement,
                                PublicityCode?.ToDelimitedString(),
                                ProtectionIndicator,
                                StudentIndicator,
                                Religion?.ToDelimitedString(),
                                MothersMaidenName != null ? string.Join(Configuration.FieldRepeatSeparator, MothersMaidenName.Select(x => x.ToDelimitedString())) : null,
                                Nationality?.ToDelimitedString(),
                                EthnicGroup != null ? string.Join(Configuration.FieldRepeatSeparator, EthnicGroup.Select(x => x.ToDelimitedString())) : null,
                                ContactReason != null ? string.Join(Configuration.FieldRepeatSeparator, ContactReason.Select(x => x.ToDelimitedString())) : null,
                                ContactPersonsName != null ? string.Join(Configuration.FieldRepeatSeparator, ContactPersonsName.Select(x => x.ToDelimitedString())) : null,
                                ContactPersonsTelephoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, ContactPersonsTelephoneNumber.Select(x => x.ToDelimitedString())) : null,
                                ContactPersonsAddress != null ? string.Join(Configuration.FieldRepeatSeparator, ContactPersonsAddress.Select(x => x.ToDelimitedString())) : null,
                                NextOfKinAssociatedPartysIdentifiers != null ? string.Join(Configuration.FieldRepeatSeparator, NextOfKinAssociatedPartysIdentifiers.Select(x => x.ToDelimitedString())) : null,
                                JobStatus,
                                Race != null ? string.Join(Configuration.FieldRepeatSeparator, Race.Select(x => x.ToDelimitedString())) : null,
                                Handicap,
                                ContactPersonSocialSecurityNumber
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}