using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V230.Types;

namespace ClearHl7.Fhir.V230.Segments
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
        public CompositeIdWithCheckDigit PatientId { get; set; }

        /// <summary>
        /// PID.3 - Patient Identifier List.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> PatientIdentifierList { get; set; }

        /// <summary>
        /// PID.4 - Alternate Patient ID - PID.
        /// </summary>
        public IEnumerable<string> AlternatePatientIdPid { get; set; }

        /// <summary>
        /// PID.5 - Patient Name.
        /// </summary>
        public ExtendedPersonName PatientName { get; set; }

        /// <summary>
        /// PID.6 - Mother's Maiden Name.
        /// </summary>
        public ExtendedPersonName MothersMaidenName { get; set; }

        /// <summary>
        /// PID.7 - Date/Time of Birth.
        /// </summary>
        public DateTime? DateTimeOfBirth { get; set; }

        /// <summary>
        /// PID.8 - Administrative Sex.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0001</remarks>
        public string AdministrativeSex { get; set; }

        /// <summary>
        /// PID.9 - Patient Alias.
        /// </summary>
        public IEnumerable<ExtendedPersonName> PatientAlias { get; set; }

        /// <summary>
        /// PID.10 - Race.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0005</remarks>
        public string Race { get; set; }

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
        public CodedElement PrimaryLanguage { get; set; }

        /// <summary>
        /// PID.16 - Marital Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0002</remarks>
        public CodedElement MaritalStatus { get; set; }

        /// <summary>
        /// PID.17 - Religion.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0006</remarks>
        public CodedElement Religion { get; set; }

        /// <summary>
        /// PID.18 - Patient Account Number.
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit PatientAccountNumber { get; set; }

        /// <summary>
        /// PID.19 - SSN Number - Patient.
        /// </summary>
        public string SsnNumberPatient { get; set; }

        /// <summary>
        /// PID.20 - Driver's License Number - Patient.
        /// </summary>
        public DriversLicenseNumber DriversLicenseNumberPatient { get; set; }

        /// <summary>
        /// PID.21 - Mother's Identifier.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> MothersIdentifier { get; set; }

        /// <summary>
        /// PID.22 - Ethnic Group.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0189</remarks>
        public string EthnicGroup { get; set; }

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
        public IEnumerable<string> Citizenship { get; set; }

        /// <summary>
        /// PID.27 - Veterans Military Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0172</remarks>
        public CodedElement VeteransMilitaryStatus { get; set; }

        /// <summary>
        /// PID.28 - Nationality.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0212</remarks>
        public CodedElement Nationality { get; set; }

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
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|{27}|{28}|{29}|{30}",
                                Id,
                                SetIdPid.HasValue ? SetIdPid.Value.ToString(culture) : null,
                                PatientId?.ToDelimitedString(),
                                PatientIdentifierList != null ? string.Join("~", PatientIdentifierList.Select(x => x.ToDelimitedString())) : null,
                                AlternatePatientIdPid != null ? string.Join("~", AlternatePatientIdPid) : null,
                                PatientName?.ToDelimitedString(),
                                MothersMaidenName?.ToDelimitedString(),
                                DateTimeOfBirth.HasValue ? DateTimeOfBirth.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                AdministrativeSex,
                                PatientAlias != null ? string.Join("~", PatientAlias.Select(x => x.ToDelimitedString())) : null,
                                Race,
                                PatientAddress != null ? string.Join("~", PatientAddress.Select(x => x.ToDelimitedString())) : null,
                                CountyCode,
                                PhoneNumberHome != null ? string.Join("~", PhoneNumberHome.Select(x => x.ToDelimitedString())) : null,
                                PhoneNumberBusiness != null ? string.Join("~", PhoneNumberBusiness.Select(x => x.ToDelimitedString())) : null,
                                PrimaryLanguage?.ToDelimitedString(),
                                MaritalStatus?.ToDelimitedString(),
                                Religion?.ToDelimitedString(),
                                PatientAccountNumber?.ToDelimitedString(),
                                SsnNumberPatient,
                                DriversLicenseNumberPatient?.ToDelimitedString(),
                                MothersIdentifier != null ? string.Join("~", MothersIdentifier.Select(x => x.ToDelimitedString())) : null,
                                EthnicGroup,
                                BirthPlace,
                                MultipleBirthIndicator,
                                BirthOrder.HasValue ? BirthOrder.Value.ToString(Consts.NumericFormat, culture) : null,
                                Citizenship != null ? string.Join("~", Citizenship) : null,
                                VeteransMilitaryStatus?.ToDelimitedString(),
                                Nationality?.ToDelimitedString(),
                                PatientDeathDateAndTime.HasValue ? PatientDeathDateAndTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                PatientDeathIndicator
                                ).TrimEnd('|');
        }
    }
}