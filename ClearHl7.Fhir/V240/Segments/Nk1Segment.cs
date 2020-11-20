using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V240.Types;

namespace ClearHl7.Fhir.V240.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0063</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0131</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0002</remarks>
        public CodedElement MaritalStatus { get; set; }

        /// <summary>
        /// NK1.15 - Administrative Sex.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0001</remarks>
        public string AdministrativeSex { get; set; }

        /// <summary>
        /// NK1.16 - Date/Time of Birth.
        /// </summary>
        public DateTime? DateTimeOfBirth { get; set; }

        /// <summary>
        /// NK1.17 - Living Dependency.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0223</remarks>
        public IEnumerable<string> LivingDependency { get; set; }

        /// <summary>
        /// NK1.18 - Ambulatory Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0009</remarks>
        public IEnumerable<string> AmbulatoryStatus { get; set; }

        /// <summary>
        /// NK1.19 - Citizenship.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0171</remarks>
        public IEnumerable<CodedElement> Citizenship { get; set; }

        /// <summary>
        /// NK1.20 - Primary Language.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0296</remarks>
        public CodedElement PrimaryLanguage { get; set; }

        /// <summary>
        /// NK1.21 - Living Arrangement.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0220</remarks>
        public string LivingArrangement { get; set; }

        /// <summary>
        /// NK1.22 - Publicity Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0215</remarks>
        public CodedElement PublicityCode { get; set; }

        /// <summary>
        /// NK1.23 - Protection Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string ProtectionIndicator { get; set; }

        /// <summary>
        /// NK1.24 - Student Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0231</remarks>
        public string StudentIndicator { get; set; }

        /// <summary>
        /// NK1.25 - Religion.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0006</remarks>
        public CodedElement Religion { get; set; }

        /// <summary>
        /// NK1.26 - Mother's Maiden Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> MothersMaidenName { get; set; }

        /// <summary>
        /// NK1.27 - Nationality.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0212</remarks>
        public CodedElement Nationality { get; set; }

        /// <summary>
        /// NK1.28 - Ethnic Group.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0189</remarks>
        public IEnumerable<CodedElement> EthnicGroup { get; set; }

        /// <summary>
        /// NK1.29 - Contact Reason.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0222</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0311</remarks>
        public string JobStatus { get; set; }

        /// <summary>
        /// NK1.35 - Race.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0005</remarks>
        public IEnumerable<CodedElement> Race { get; set; }

        /// <summary>
        /// NK1.36 - Handicap.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0295</remarks>
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
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|{27}|{28}|{29}|{30}|{31}|{32}|{33}|{34}|{35}|{36}|{37}",
                                Id,
                                SetIdNk1.HasValue ? SetIdNk1.Value.ToString(culture) : null,
                                Name != null ? string.Join("~", Name.Select(x => x.ToDelimitedString())) : null,
                                Relationship?.ToDelimitedString(),
                                Address != null ? string.Join("~", Address.Select(x => x.ToDelimitedString())) : null,
                                PhoneNumber != null ? string.Join("~", PhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                BusinessPhoneNumber != null ? string.Join("~", BusinessPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                ContactRole?.ToDelimitedString(),
                                StartDate.HasValue ? StartDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                EndDate.HasValue ? EndDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                NextOfKinAssociatedPartiesJobTitle,
                                NextOfKinAssociatedPartiesJobCodeClass?.ToDelimitedString(),
                                NextOfKinAssociatedPartiesEmployeeNumber?.ToDelimitedString(),
                                OrganizationNameNk1 != null ? string.Join("~", OrganizationNameNk1.Select(x => x.ToDelimitedString())) : null,
                                MaritalStatus?.ToDelimitedString(),
                                AdministrativeSex,
                                DateTimeOfBirth.HasValue ? DateTimeOfBirth.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                LivingDependency != null ? string.Join("~", LivingDependency) : null,
                                AmbulatoryStatus != null ? string.Join("~", AmbulatoryStatus) : null,
                                Citizenship != null ? string.Join("~", Citizenship.Select(x => x.ToDelimitedString())) : null,
                                PrimaryLanguage?.ToDelimitedString(),
                                LivingArrangement,
                                PublicityCode?.ToDelimitedString(),
                                ProtectionIndicator,
                                StudentIndicator,
                                Religion?.ToDelimitedString(),
                                MothersMaidenName != null ? string.Join("~", MothersMaidenName.Select(x => x.ToDelimitedString())) : null,
                                Nationality?.ToDelimitedString(),
                                EthnicGroup != null ? string.Join("~", EthnicGroup.Select(x => x.ToDelimitedString())) : null,
                                ContactReason != null ? string.Join("~", ContactReason.Select(x => x.ToDelimitedString())) : null,
                                ContactPersonsName != null ? string.Join("~", ContactPersonsName.Select(x => x.ToDelimitedString())) : null,
                                ContactPersonsTelephoneNumber != null ? string.Join("~", ContactPersonsTelephoneNumber.Select(x => x.ToDelimitedString())) : null,
                                ContactPersonsAddress != null ? string.Join("~", ContactPersonsAddress.Select(x => x.ToDelimitedString())) : null,
                                NextOfKinAssociatedPartysIdentifiers != null ? string.Join("~", NextOfKinAssociatedPartysIdentifiers.Select(x => x.ToDelimitedString())) : null,
                                JobStatus,
                                Race != null ? string.Join("~", Race.Select(x => x.ToDelimitedString())) : null,
                                Handicap,
                                ContactPersonSocialSecurityNumber
                                ).TrimEnd('|');
        }
    }
}