using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V270.Types;

namespace ClearHl7.Fhir.V270.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PID - Patient Identification.
    /// </summary>
    public class PidSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PID";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// PID.1 - Set ID - PID.
        /// </summary>
        public uint? SetIdPid { get; set; }

        /// <summary>
        /// PID.2 - Patient ID.
        /// </summary>
        public string PatientId { get; set; }

        /// <summary>
        /// PID.3 - Patient Identifier List.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> PatientIdentifierList { get; set; }

        /// <summary>
        /// PID.4 - Alternate Patient ID - PID.
        /// </summary>
        public string AlternatePatientIdPid { get; set; }

        /// <summary>
        /// PID.5 - Patient Name.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0200</remarks>
        public IEnumerable<ExtendedPersonName> PatientName { get; set; }

        /// <summary>
        /// PID.6 - Mother's Maiden Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> MothersMaidenName { get; set; }

        /// <summary>
        /// PID.7 - Date/Time of Birth.
        /// </summary>
        public DateTime? DateTimeOfBirth { get; set; }

        /// <summary>
        /// PID.8 - Administrative Sex.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0001</remarks>
        public CodedWithExceptions AdministrativeSex { get; set; }

        /// <summary>
        /// PID.9 - Patient Alias.
        /// </summary>
        public string PatientAlias { get; set; }

        /// <summary>
        /// PID.10 - Race.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0005</remarks>
        public IEnumerable<CodedWithExceptions> Race { get; set; }

        /// <summary>
        /// PID.11 - Patient Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> PatientAddress { get; set; }

        /// <summary>
        /// PID.12 - County Code.
        /// </summary>
        public string CountyCode { get; set; }

        /// <summary>
        /// PID.13 - Phone Number - Home.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> PhoneNumberHome { get; set; }

        /// <summary>
        /// PID.14 - Phone Number - Business.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> PhoneNumberBusiness { get; set; }

        /// <summary>
        /// PID.15 - Primary Language.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0296</remarks>
        public CodedWithExceptions PrimaryLanguage { get; set; }

        /// <summary>
        /// PID.16 - Marital Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0002</remarks>
        public CodedWithExceptions MaritalStatus { get; set; }

        /// <summary>
        /// PID.17 - Religion.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0006</remarks>
        public CodedWithExceptions Religion { get; set; }

        /// <summary>
        /// PID.18 - Patient Account Number.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0061</remarks>
        public ExtendedCompositeIdWithCheckDigit PatientAccountNumber { get; set; }

        /// <summary>
        /// PID.19 - SSN Number - Patient.
        /// </summary>
        public string SsnNumberPatient { get; set; }

        /// <summary>
        /// PID.20 - Driver's License Number - Patient.
        /// </summary>
        public string DriversLicenseNumberPatient { get; set; }

        /// <summary>
        /// PID.21 - Mother's Identifier.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0061</remarks>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> MothersIdentifier { get; set; }

        /// <summary>
        /// PID.22 - Ethnic Group.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0189</remarks>
        public IEnumerable<CodedWithExceptions> EthnicGroup { get; set; }

        /// <summary>
        /// PID.23 - Birth Place.
        /// </summary>
        public string BirthPlace { get; set; }

        /// <summary>
        /// PID.24 - Multiple Birth Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string MultipleBirthIndicator { get; set; }

        /// <summary>
        /// PID.25 - Birth Order.
        /// </summary>
        public decimal? BirthOrder { get; set; }

        /// <summary>
        /// PID.26 - Citizenship.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0171</remarks>
        public IEnumerable<CodedWithExceptions> Citizenship { get; set; }

        /// <summary>
        /// PID.27 - Veterans Military Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0172</remarks>
        public CodedWithExceptions VeteransMilitaryStatus { get; set; }

        /// <summary>
        /// PID.28 - Nationality.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0212</remarks>
        public CodedWithExceptions Nationality { get; set; }

        /// <summary>
        /// PID.29 - Patient Death Date and Time.
        /// </summary>
        public DateTime? PatientDeathDateAndTime { get; set; }

        /// <summary>
        /// PID.30 - Patient Death Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string PatientDeathIndicator { get; set; }

        /// <summary>
        /// PID.31 - Identity Unknown Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string IdentityUnknownIndicator { get; set; }

        /// <summary>
        /// PID.32 - Identity Reliability Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0445</remarks>
        public IEnumerable<CodedWithExceptions> IdentityReliabilityCode { get; set; }

        /// <summary>
        /// PID.33 - Last Update Date/Time.
        /// </summary>
        public DateTime? LastUpdateDateTime { get; set; }

        /// <summary>
        /// PID.34 - Last Update Facility.
        /// </summary>
        public HierarchicDesignator LastUpdateFacility { get; set; }

        /// <summary>
        /// PID.35 - Taxonomic Classification Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0446</remarks>
        public CodedWithExceptions TaxonomicClassificationCode { get; set; }

        /// <summary>
        /// PID.36 - Breed Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0447</remarks>
        public CodedWithExceptions BreedCode { get; set; }

        /// <summary>
        /// PID.37 - Strain.
        /// </summary>
        public string Strain { get; set; }

        /// <summary>
        /// PID.38 - Production Class Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0429</remarks>
        public CodedWithExceptions ProductionClassCode { get; set; }

        /// <summary>
        /// PID.39 - Tribal Citizenship.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0171</remarks>
        public IEnumerable<CodedWithExceptions> TribalCitizenship { get; set; }

        /// <summary>
        /// PID.40 - Patient Telecommunication Information.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> PatientTelecommunicationInformation { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|{27}|{28}|{29}|{30}|{31}|{32}|{33}|{34}|{35}|{36}|{37}|{38}|{39}|{40}",
                                Id,
                                SetIdPid.HasValue ? SetIdPid.Value.ToString(culture) : null,
                                PatientId,
                                PatientIdentifierList != null ? string.Join("~", PatientIdentifierList.Select(x => x.ToDelimitedString())) : null,
                                AlternatePatientIdPid,
                                PatientName != null ? string.Join("~", PatientName.Select(x => x.ToDelimitedString())) : null,
                                MothersMaidenName != null ? string.Join("~", MothersMaidenName.Select(x => x.ToDelimitedString())) : null,
                                DateTimeOfBirth.HasValue ? DateTimeOfBirth.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                AdministrativeSex?.ToDelimitedString(),
                                PatientAlias,
                                Race != null ? string.Join("~", Race.Select(x => x.ToDelimitedString())) : null,
                                PatientAddress != null ? string.Join("~", PatientAddress.Select(x => x.ToDelimitedString())) : null,
                                CountyCode,
                                PhoneNumberHome != null ? string.Join("~", PhoneNumberHome.Select(x => x.ToDelimitedString())) : null,
                                PhoneNumberBusiness != null ? string.Join("~", PhoneNumberBusiness.Select(x => x.ToDelimitedString())) : null,
                                PrimaryLanguage?.ToDelimitedString(),
                                MaritalStatus?.ToDelimitedString(),
                                Religion?.ToDelimitedString(),
                                PatientAccountNumber?.ToDelimitedString(),
                                SsnNumberPatient,
                                DriversLicenseNumberPatient,
                                MothersIdentifier != null ? string.Join("~", MothersIdentifier.Select(x => x.ToDelimitedString())) : null,
                                EthnicGroup != null ? string.Join("~", EthnicGroup.Select(x => x.ToDelimitedString())) : null,
                                BirthPlace,
                                MultipleBirthIndicator,
                                BirthOrder.HasValue ? BirthOrder.Value.ToString(Consts.NumericFormat, culture) : null,
                                Citizenship != null ? string.Join("~", Citizenship.Select(x => x.ToDelimitedString())) : null,
                                VeteransMilitaryStatus?.ToDelimitedString(),
                                Nationality?.ToDelimitedString(),
                                PatientDeathDateAndTime.HasValue ? PatientDeathDateAndTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                PatientDeathIndicator,
                                IdentityUnknownIndicator,
                                IdentityReliabilityCode != null ? string.Join("~", IdentityReliabilityCode.Select(x => x.ToDelimitedString())) : null,
                                LastUpdateDateTime.HasValue ? LastUpdateDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                LastUpdateFacility?.ToDelimitedString(),
                                TaxonomicClassificationCode?.ToDelimitedString(),
                                BreedCode?.ToDelimitedString(),
                                Strain,
                                ProductionClassCode?.ToDelimitedString(),
                                TribalCitizenship != null ? string.Join("~", TribalCitizenship.Select(x => x.ToDelimitedString())) : null,
                                PatientTelecommunicationInformation != null ? string.Join("~", PatientTelecommunicationInformation.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd('|');
        }
    }
}