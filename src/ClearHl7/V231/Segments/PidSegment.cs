﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V231.Types;

namespace ClearHl7.V231.Segments
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
        public ExtendedCompositeIdWithCheckDigit PatientId { get; set; }

        /// <summary>
        /// PID.3 - Patient Identifier List.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> PatientIdentifierList { get; set; }

        /// <summary>
        /// PID.4 - Alternate Patient ID - PID.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> AlternatePatientIdPid { get; set; }

        /// <summary>
        /// PID.5 - Patient Name.
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
        /// <para>Suggested: 0001 Administrative Sex -&gt; ClearHl7.Codes.V231.CodeAdministrativeSex</para>
        /// </summary>
        public string AdministrativeSex { get; set; }

        /// <summary>
        /// PID.9 - Patient Alias.
        /// </summary>
        public IEnumerable<ExtendedPersonName> PatientAlias { get; set; }

        /// <summary>
        /// PID.10 - Race.
        /// <para>Suggested: 0005 Race -&gt; ClearHl7.Codes.V231.CodeRace</para>
        /// </summary>
        public IEnumerable<CodedElement> Race { get; set; }

        /// <summary>
        /// PID.11 - Patient Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> PatientAddress { get; set; }

        /// <summary>
        /// PID.12 - County Code.
        /// <para>Suggested: 0289 County/Parish</para>
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
        public CodedElement PrimaryLanguage { get; set; }

        /// <summary>
        /// PID.16 - Marital Status.
        /// <para>Suggested: 0002 Marital Status -&gt; ClearHl7.Codes.V231.CodeMaritalStatus</para>
        /// </summary>
        public CodedElement MaritalStatus { get; set; }

        /// <summary>
        /// PID.17 - Religion.
        /// <para>Suggested: 0006 Religion -&gt; ClearHl7.Codes.V231.CodeReligion</para>
        /// </summary>
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
        /// <para>Suggested: 0189 Ethnic Group</para>
        /// </summary>
        public IEnumerable<CodedElement> EthnicGroup { get; set; }

        /// <summary>
        /// PID.23 - Birth Place.
        /// </summary>
        public string BirthPlace { get; set; }

        /// <summary>
        /// PID.24 - Multiple Birth Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V231.CodeYesNoIndicator</para>
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
        public IEnumerable<CodedElement> Citizenship { get; set; }

        /// <summary>
        /// PID.27 - Veterans Military Status.
        /// <para>Suggested: 0172 Veterans Military Status</para>
        /// </summary>
        public CodedElement VeteransMilitaryStatus { get; set; }

        /// <summary>
        /// PID.28 - Nationality.
        /// <para>Suggested: 0212 Nationality</para>
        /// </summary>
        public CodedElement Nationality { get; set; }

        /// <summary>
        /// PID.29 - Patient Death Date and Time.
        /// </summary>
        public DateTime? PatientDeathDateAndTime { get; set; }

        /// <summary>
        /// PID.30 - Patient Death Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V231.CodeYesNoIndicator</para>
        /// </summary>
        public string PatientDeathIndicator { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);
            
            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdPid = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            PatientId = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments[2], false, seps) : null;
            PatientIdentifierList = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false, seps)) : null;
            AlternatePatientIdPid = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false, seps)) : null;
            PatientName = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedPersonName>(x, false, seps)) : null;
            MothersMaidenName = segments.Length > 6 && segments[6].Length > 0 ? segments[6].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedPersonName>(x, false, seps)) : null;
            DateTimeOfBirth = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDateTime() : null;
            AdministrativeSex = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            PatientAlias = segments.Length > 9 && segments[9].Length > 0 ? segments[9].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedPersonName>(x, false, seps)) : null;
            Race = segments.Length > 10 && segments[10].Length > 0 ? segments[10].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedElement>(x, false, seps)) : null;
            PatientAddress = segments.Length > 11 && segments[11].Length > 0 ? segments[11].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedAddress>(x, false, seps)) : null;
            CountyCode = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
            PhoneNumberHome = segments.Length > 13 && segments[13].Length > 0 ? segments[13].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false, seps)) : null;
            PhoneNumberBusiness = segments.Length > 14 && segments[14].Length > 0 ? segments[14].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false, seps)) : null;
            PrimaryLanguage = segments.Length > 15 && segments[15].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[15], false, seps) : null;
            MaritalStatus = segments.Length > 16 && segments[16].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[16], false, seps) : null;
            Religion = segments.Length > 17 && segments[17].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[17], false, seps) : null;
            PatientAccountNumber = segments.Length > 18 && segments[18].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments[18], false, seps) : null;
            SsnNumberPatient = segments.Length > 19 && segments[19].Length > 0 ? segments[19] : null;
            DriversLicenseNumberPatient = segments.Length > 20 && segments[20].Length > 0 ? TypeHelper.Deserialize<DriversLicenseNumber>(segments[20], false, seps) : null;
            MothersIdentifier = segments.Length > 21 && segments[21].Length > 0 ? segments[21].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false, seps)) : null;
            EthnicGroup = segments.Length > 22 && segments[22].Length > 0 ? segments[22].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedElement>(x, false, seps)) : null;
            BirthPlace = segments.Length > 23 && segments[23].Length > 0 ? segments[23] : null;
            MultipleBirthIndicator = segments.Length > 24 && segments[24].Length > 0 ? segments[24] : null;
            BirthOrder = segments.Length > 25 && segments[25].Length > 0 ? segments[25].ToNullableDecimal() : null;
            Citizenship = segments.Length > 26 && segments[26].Length > 0 ? segments[26].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedElement>(x, false, seps)) : null;
            VeteransMilitaryStatus = segments.Length > 27 && segments[27].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[27], false, seps) : null;
            Nationality = segments.Length > 28 && segments[28].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[28], false, seps) : null;
            PatientDeathDateAndTime = segments.Length > 29 && segments[29].Length > 0 ? segments[29].ToNullableDateTime() : null;
            PatientDeathIndicator = segments.Length > 30 && segments[30].Length > 0 ? segments[30] : null;
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
                                StringHelper.StringFormatSequence(0, 31, Configuration.FieldSeparator),
                                Id,
                                SetIdPid.HasValue ? SetIdPid.Value.ToString(culture) : null,
                                PatientId?.ToDelimitedString(),
                                PatientIdentifierList != null ? string.Join(Configuration.FieldRepeatSeparator, PatientIdentifierList.Select(x => x.ToDelimitedString())) : null,
                                AlternatePatientIdPid != null ? string.Join(Configuration.FieldRepeatSeparator, AlternatePatientIdPid.Select(x => x.ToDelimitedString())) : null,
                                PatientName != null ? string.Join(Configuration.FieldRepeatSeparator, PatientName.Select(x => x.ToDelimitedString())) : null,
                                MothersMaidenName != null ? string.Join(Configuration.FieldRepeatSeparator, MothersMaidenName.Select(x => x.ToDelimitedString())) : null,
                                DateTimeOfBirth.HasValue ? DateTimeOfBirth.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                AdministrativeSex,
                                PatientAlias != null ? string.Join(Configuration.FieldRepeatSeparator, PatientAlias.Select(x => x.ToDelimitedString())) : null,
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
                                DriversLicenseNumberPatient?.ToDelimitedString(),
                                MothersIdentifier != null ? string.Join(Configuration.FieldRepeatSeparator, MothersIdentifier.Select(x => x.ToDelimitedString())) : null,
                                EthnicGroup != null ? string.Join(Configuration.FieldRepeatSeparator, EthnicGroup.Select(x => x.ToDelimitedString())) : null,
                                BirthPlace,
                                MultipleBirthIndicator,
                                BirthOrder.HasValue ? BirthOrder.Value.ToString(Consts.NumericFormat, culture) : null,
                                Citizenship != null ? string.Join(Configuration.FieldRepeatSeparator, Citizenship.Select(x => x.ToDelimitedString())) : null,
                                VeteransMilitaryStatus?.ToDelimitedString(),
                                Nationality?.ToDelimitedString(),
                                PatientDeathDateAndTime.HasValue ? PatientDeathDateAndTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                PatientDeathIndicator
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}