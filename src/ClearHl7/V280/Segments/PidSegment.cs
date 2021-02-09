using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
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
        /// <para>Suggested: 0200 Name Type -&gt; ClearHl7.Fhir.Codes.V280.CodeNameType</para>
        /// </summary>
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
        /// <para>Suggested: 0001 Administrative Sex -&gt; ClearHl7.Fhir.Codes.V280.CodeAdministrativeSex</para>
        /// </summary>
        public CodedWithExceptions AdministrativeSex { get; set; }

        /// <summary>
        /// PID.9 - Patient Alias.
        /// </summary>
        public string PatientAlias { get; set; }

        /// <summary>
        /// PID.10 - Race.
        /// <para>Suggested: 0005 Race -&gt; ClearHl7.Fhir.Codes.V280.CodeRace</para>
        /// </summary>
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
        /// <para>Suggested: 0296 Primary Language</para>
        /// </summary>
        public CodedWithExceptions PrimaryLanguage { get; set; }

        /// <summary>
        /// PID.16 - Marital Status.
        /// <para>Suggested: 0002 Marital Status -&gt; ClearHl7.Fhir.Codes.V280.CodeMaritalStatus</para>
        /// </summary>
        public CodedWithExceptions MaritalStatus { get; set; }

        /// <summary>
        /// PID.17 - Religion.
        /// <para>Suggested: 0006 Religion -&gt; ClearHl7.Fhir.Codes.V280.CodeReligion</para>
        /// </summary>
        public CodedWithExceptions Religion { get; set; }

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
        public string DriversLicenseNumberPatient { get; set; }

        /// <summary>
        /// PID.21 - Mother's Identifier.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> MothersIdentifier { get; set; }

        /// <summary>
        /// PID.22 - Ethnic Group.
        /// <para>Suggested: 0189 Ethnic Group -&gt; ClearHl7.Fhir.Codes.V280.CodeEthnicGroup</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> EthnicGroup { get; set; }

        /// <summary>
        /// PID.23 - Birth Place.
        /// </summary>
        public string BirthPlace { get; set; }

        /// <summary>
        /// PID.24 - Multiple Birth Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Fhir.Codes.V280.CodeYesNoIndicator</para>
        /// </summary>
        public string MultipleBirthIndicator { get; set; }

        /// <summary>
        /// PID.25 - Birth Order.
        /// </summary>
        public decimal? BirthOrder { get; set; }

        /// <summary>
        /// PID.26 - Citizenship.
        /// <para>Suggested: 0171 Citizenship</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> Citizenship { get; set; }

        /// <summary>
        /// PID.27 - Veterans Military Status.
        /// <para>Suggested: 0172 Veterans Military Status</para>
        /// </summary>
        public CodedWithExceptions VeteransMilitaryStatus { get; set; }

        /// <summary>
        /// PID.28 - Nationality.
        /// <para>Suggested: 0212 Nationality</para>
        /// </summary>
        public CodedWithExceptions Nationality { get; set; }

        /// <summary>
        /// PID.29 - Patient Death Date and Time.
        /// </summary>
        public DateTime? PatientDeathDateAndTime { get; set; }

        /// <summary>
        /// PID.30 - Patient Death Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Fhir.Codes.V280.CodeYesNoIndicator</para>
        /// </summary>
        public string PatientDeathIndicator { get; set; }

        /// <summary>
        /// PID.31 - Identity Unknown Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Fhir.Codes.V280.CodeYesNoIndicator</para>
        /// </summary>
        public string IdentityUnknownIndicator { get; set; }

        /// <summary>
        /// PID.32 - Identity Reliability Code.
        /// <para>Suggested: 0445 Identity Reliability Code -&gt; ClearHl7.Fhir.Codes.V280.CodeIdentityReliabilityCode</para>
        /// </summary>
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
        public CodedWithExceptions TaxonomicClassificationCode { get; set; }

        /// <summary>
        /// PID.36 - Breed Code.
        /// <para>Suggested: 0447 Breed Code</para>
        /// </summary>
        public CodedWithExceptions BreedCode { get; set; }

        /// <summary>
        /// PID.37 - Strain.
        /// </summary>
        public string Strain { get; set; }

        /// <summary>
        /// PID.38 - Production Class Code.
        /// <para>Suggested: 0429 Production Class Code -&gt; ClearHl7.Fhir.Codes.V280.CodeProductionClassCode</para>
        /// </summary>
        public CodedWithExceptions ProductionClassCode { get; set; }

        /// <summary>
        /// PID.39 - Tribal Citizenship.
        /// <para>Suggested: 0171 Citizenship</para>
        /// </summary>
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
                                StringHelper.StringFormatSequence(0, 41, Configuration.FieldSeparator),
                                Id,
                                SetIdPid.HasValue ? SetIdPid.Value.ToString(culture) : null,
                                PatientId,
                                PatientIdentifierList != null ? string.Join(Configuration.FieldRepeatSeparator, PatientIdentifierList.Select(x => x.ToDelimitedString())) : null,
                                AlternatePatientIdPid,
                                PatientName != null ? string.Join(Configuration.FieldRepeatSeparator, PatientName.Select(x => x.ToDelimitedString())) : null,
                                MothersMaidenName != null ? string.Join(Configuration.FieldRepeatSeparator, MothersMaidenName.Select(x => x.ToDelimitedString())) : null,
                                DateTimeOfBirth.HasValue ? DateTimeOfBirth.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                AdministrativeSex?.ToDelimitedString(),
                                PatientAlias,
                                Race != null ? string.Join(Configuration.FieldRepeatSeparator, Race.Select(x => x.ToDelimitedString())) : null,
                                PatientAddress != null ? string.Join(Configuration.FieldRepeatSeparator, PatientAddress.Select(x => x.ToDelimitedString())) : null,
                                CountyCode,
                                PhoneNumberHome != null ? string.Join(Configuration.FieldRepeatSeparator, PhoneNumberHome.Select(x => x.ToDelimitedString())) : null,
                                PhoneNumberBusiness != null ? string.Join(Configuration.FieldRepeatSeparator, PhoneNumberBusiness.Select(x => x.ToDelimitedString())) : null,
                                PrimaryLanguage?.ToDelimitedString(),
                                MaritalStatus?.ToDelimitedString(),
                                Religion?.ToDelimitedString(),
                                PatientAccountNumber?.ToDelimitedString(),
                                SsnNumberPatient,
                                DriversLicenseNumberPatient,
                                MothersIdentifier != null ? string.Join(Configuration.FieldRepeatSeparator, MothersIdentifier.Select(x => x.ToDelimitedString())) : null,
                                EthnicGroup != null ? string.Join(Configuration.FieldRepeatSeparator, EthnicGroup.Select(x => x.ToDelimitedString())) : null,
                                BirthPlace,
                                MultipleBirthIndicator,
                                BirthOrder.HasValue ? BirthOrder.Value.ToString(Consts.NumericFormat, culture) : null,
                                Citizenship != null ? string.Join(Configuration.FieldRepeatSeparator, Citizenship.Select(x => x.ToDelimitedString())) : null,
                                VeteransMilitaryStatus?.ToDelimitedString(),
                                Nationality?.ToDelimitedString(),
                                PatientDeathDateAndTime.HasValue ? PatientDeathDateAndTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                PatientDeathIndicator,
                                IdentityUnknownIndicator,
                                IdentityReliabilityCode != null ? string.Join(Configuration.FieldRepeatSeparator, IdentityReliabilityCode.Select(x => x.ToDelimitedString())) : null,
                                LastUpdateDateTime.HasValue ? LastUpdateDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                LastUpdateFacility?.ToDelimitedString(),
                                TaxonomicClassificationCode?.ToDelimitedString(),
                                BreedCode?.ToDelimitedString(),
                                Strain,
                                ProductionClassCode?.ToDelimitedString(),
                                TribalCitizenship != null ? string.Join(Configuration.FieldRepeatSeparator, TribalCitizenship.Select(x => x.ToDelimitedString())) : null,
                                PatientTelecommunicationInformation != null ? string.Join(Configuration.FieldRepeatSeparator, PatientTelecommunicationInformation.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}