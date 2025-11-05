using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment GT1 - Guarantor.
    /// </summary>
    public class Gt1Segment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Gt1Segment"/> class.
        /// </summary>
        public Gt1Segment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Gt1Segment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public Gt1Segment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "GT1";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// GT1.1 - Set ID - GT1.
        /// </summary>
        public uint? SetIdGt1 { get; set; }

        /// <summary>
        /// GT1.2 - Guarantor Number.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> GuarantorNumber { get; set; }

        /// <summary>
        /// GT1.3 - Guarantor Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> GuarantorName { get; set; }

        /// <summary>
        /// GT1.4 - Guarantor Spouse Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> GuarantorSpouseName { get; set; }

        /// <summary>
        /// GT1.5 - Guarantor Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> GuarantorAddress { get; set; }

        /// <summary>
        /// GT1.6 - Guarantor Ph Num - Home.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> GuarantorPhNumHome { get; set; }

        /// <summary>
        /// GT1.7 - Guarantor Ph Num - Business.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> GuarantorPhNumBusiness { get; set; }

        /// <summary>
        /// GT1.8 - Guarantor Date/Time Of Birth.
        /// </summary>
        public DateTime? GuarantorDateTimeOfBirth { get; set; }

        /// <summary>
        /// GT1.9 - Guarantor Administrative Sex.
        /// <para>Suggested: 0001 Administrative Sex -&gt; ClearHl7.Codes.V271.CodeAdministrativeSex</para>
        /// </summary>
        public CodedWithExceptions GuarantorAdministrativeSex { get; set; }

        /// <summary>
        /// GT1.10 - Guarantor Type.
        /// <para>Suggested: 0068 Guarantor Type</para>
        /// </summary>
        public CodedWithExceptions GuarantorType { get; set; }

        /// <summary>
        /// GT1.11 - Guarantor Relationship.
        /// <para>Suggested: 0063 Relationship -&gt; ClearHl7.Codes.V271.CodeRelationship</para>
        /// </summary>
        public CodedWithExceptions GuarantorRelationship { get; set; }

        /// <summary>
        /// GT1.12 - Guarantor SSN.
        /// </summary>
        public string GuarantorSsn { get; set; }

        /// <summary>
        /// GT1.13 - Guarantor Date - Begin.
        /// </summary>
        public DateTime? GuarantorDateBegin { get; set; }

        /// <summary>
        /// GT1.14 - Guarantor Date - End.
        /// </summary>
        public DateTime? GuarantorDateEnd { get; set; }

        /// <summary>
        /// GT1.15 - Guarantor Priority.
        /// </summary>
        public decimal? GuarantorPriority { get; set; }

        /// <summary>
        /// GT1.16 - Guarantor Employer Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> GuarantorEmployerName { get; set; }

        /// <summary>
        /// GT1.17 - Guarantor Employer Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> GuarantorEmployerAddress { get; set; }

        /// <summary>
        /// GT1.18 - Guarantor Employer Phone Number.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> GuarantorEmployerPhoneNumber { get; set; }

        /// <summary>
        /// GT1.19 - Guarantor Employee ID Number.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> GuarantorEmployeeIdNumber { get; set; }

        /// <summary>
        /// GT1.20 - Guarantor Employment Status.
        /// <para>Suggested: 0066 Employment Status -&gt; ClearHl7.Codes.V271.CodeEmploymentStatus</para>
        /// </summary>
        public CodedWithExceptions GuarantorEmploymentStatus { get; set; }

        /// <summary>
        /// GT1.21 - Guarantor Organization Name.
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> GuarantorOrganizationName { get; set; }

        /// <summary>
        /// GT1.22 - Guarantor Billing Hold Flag.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V271.CodeYesNoIndicator</para>
        /// </summary>
        public string GuarantorBillingHoldFlag { get; set; }

        /// <summary>
        /// GT1.23 - Guarantor Credit Rating Code.
        /// <para>Suggested: 0341 Guarantor Credit Rating Code</para>
        /// </summary>
        public CodedWithExceptions GuarantorCreditRatingCode { get; set; }

        /// <summary>
        /// GT1.24 - Guarantor Death Date And Time.
        /// </summary>
        public DateTime? GuarantorDeathDateAndTime { get; set; }

        /// <summary>
        /// GT1.25 - Guarantor Death Flag.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V271.CodeYesNoIndicator</para>
        /// </summary>
        public string GuarantorDeathFlag { get; set; }

        /// <summary>
        /// GT1.26 - Guarantor Charge Adjustment Code.
        /// <para>Suggested: 0218 Patient Charge Adjustment</para>
        /// </summary>
        public CodedWithExceptions GuarantorChargeAdjustmentCode { get; set; }

        /// <summary>
        /// GT1.27 - Guarantor Household Annual Income.
        /// </summary>
        public CompositePrice GuarantorHouseholdAnnualIncome { get; set; }

        /// <summary>
        /// GT1.28 - Guarantor Household Size.
        /// </summary>
        public decimal? GuarantorHouseholdSize { get; set; }

        /// <summary>
        /// GT1.29 - Guarantor Employer ID Number.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> GuarantorEmployerIdNumber { get; set; }

        /// <summary>
        /// GT1.30 - Guarantor Marital Status Code.
        /// <para>Suggested: 0002 Marital Status -&gt; ClearHl7.Codes.V271.CodeMaritalStatus</para>
        /// </summary>
        public CodedWithExceptions GuarantorMaritalStatusCode { get; set; }

        /// <summary>
        /// GT1.31 - Guarantor Hire Effective Date.
        /// </summary>
        public DateTime? GuarantorHireEffectiveDate { get; set; }

        /// <summary>
        /// GT1.32 - Employment Stop Date.
        /// </summary>
        public DateTime? EmploymentStopDate { get; set; }

        /// <summary>
        /// GT1.33 - Living Dependency.
        /// <para>Suggested: 0223 Living Dependency -&gt; ClearHl7.Codes.V271.CodeLivingDependency</para>
        /// </summary>
        public CodedWithExceptions LivingDependency { get; set; }

        /// <summary>
        /// GT1.34 - Ambulatory Status.
        /// <para>Suggested: 0009 Ambulatory Status -&gt; ClearHl7.Codes.V271.CodeAmbulatoryStatus</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> AmbulatoryStatus { get; set; }

        /// <summary>
        /// GT1.35 - Citizenship.
        /// <para>Suggested: 0171 Citizenship</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> Citizenship { get; set; }

        /// <summary>
        /// GT1.36 - Primary Language.
        /// <para>Suggested: 0296 Primary Language</para>
        /// </summary>
        public CodedWithExceptions PrimaryLanguage { get; set; }

        /// <summary>
        /// GT1.37 - Living Arrangement.
        /// <para>Suggested: 0220 Living Arrangement -&gt; ClearHl7.Codes.V271.CodeLivingArrangement</para>
        /// </summary>
        public CodedWithExceptions LivingArrangement { get; set; }

        /// <summary>
        /// GT1.38 - Publicity Code.
        /// <para>Suggested: 0215 Publicity Code -&gt; ClearHl7.Codes.V271.CodePublicityCode</para>
        /// </summary>
        public CodedWithExceptions PublicityCode { get; set; }

        /// <summary>
        /// GT1.39 - Protection Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V271.CodeYesNoIndicator</para>
        /// </summary>
        public string ProtectionIndicator { get; set; }

        /// <summary>
        /// GT1.40 - Student Indicator.
        /// <para>Suggested: 0231 Student Status -&gt; ClearHl7.Codes.V271.CodeStudentStatus</para>
        /// </summary>
        public CodedWithExceptions StudentIndicator { get; set; }

        /// <summary>
        /// GT1.41 - Religion.
        /// <para>Suggested: 0006 Religion -&gt; ClearHl7.Codes.V271.CodeReligion</para>
        /// </summary>
        public CodedWithExceptions Religion { get; set; }

        /// <summary>
        /// GT1.42 - Mother's Maiden Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> MothersMaidenName { get; set; }

        /// <summary>
        /// GT1.43 - Nationality.
        /// <para>Suggested: 0212 Nationality</para>
        /// </summary>
        public CodedWithExceptions Nationality { get; set; }

        /// <summary>
        /// GT1.44 - Ethnic Group.
        /// <para>Suggested: 0189 Ethnic Group -&gt; ClearHl7.Codes.V271.CodeEthnicGroup</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> EthnicGroup { get; set; }

        /// <summary>
        /// GT1.45 - Contact Person's Name.
        /// <para>Suggested: 0200 Name Type -&gt; ClearHl7.Codes.V271.CodeNameType</para>
        /// </summary>
        public IEnumerable<ExtendedPersonName> ContactPersonsName { get; set; }

        /// <summary>
        /// GT1.46 - Contact Person's Telephone Number.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> ContactPersonsTelephoneNumber { get; set; }

        /// <summary>
        /// GT1.47 - Contact Reason.
        /// <para>Suggested: 0222 Contact Reason</para>
        /// </summary>
        public CodedWithExceptions ContactReason { get; set; }

        /// <summary>
        /// GT1.48 - Contact Relationship.
        /// <para>Suggested: 0063 Relationship -&gt; ClearHl7.Codes.V271.CodeRelationship</para>
        /// </summary>
        public CodedWithExceptions ContactRelationship { get; set; }

        /// <summary>
        /// GT1.49 - Job Title.
        /// </summary>
        public string JobTitle { get; set; }

        /// <summary>
        /// GT1.50 - Job Code/Class.
        /// <para>Suggested: 0327 Job Code/Class</para>
        /// </summary>
        public JobCodeClass JobCodeClass { get; set; }

        /// <summary>
        /// GT1.51 - Guarantor Employer's Organization Name.
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> GuarantorEmployersOrganizationName { get; set; }

        /// <summary>
        /// GT1.52 - Handicap.
        /// <para>Suggested: 0295 Handicap</para>
        /// </summary>
        public CodedWithExceptions Handicap { get; set; }

        /// <summary>
        /// GT1.53 - Job Status.
        /// <para>Suggested: 0311 Job Status -&gt; ClearHl7.Codes.V271.CodeJobStatus</para>
        /// </summary>
        public CodedWithExceptions JobStatus { get; set; }

        /// <summary>
        /// GT1.54 - Guarantor Financial Class.
        /// </summary>
        public FinancialClass GuarantorFinancialClass { get; set; }

        /// <summary>
        /// GT1.55 - Guarantor Race.
        /// <para>Suggested: 0005 Race -&gt; ClearHl7.Codes.V271.CodeRace</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> GuarantorRace { get; set; }

        /// <summary>
        /// GT1.56 - Guarantor Birth Place.
        /// </summary>
        public string GuarantorBirthPlace { get; set; }

        /// <summary>
        /// GT1.57 - VIP Indicator.
        /// <para>Suggested: 0099 VIP Indicator</para>
        /// </summary>
        public CodedWithExceptions VipIndicator { get; set; }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (!string.Equals(Id, segments[0], StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdGt1 = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            GuarantorNumber = segments.Length > 2 && segments[2].Length > 0 ? segments[2].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false, seps)) : null;
            GuarantorName = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedPersonName>(x, false, seps)) : null;
            GuarantorSpouseName = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedPersonName>(x, false, seps)) : null;
            GuarantorAddress = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedAddress>(x, false, seps)) : null;
            GuarantorPhNumHome = segments.Length > 6 && segments[6].Length > 0 ? segments[6].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedTelecommunicationNumber>(x, false, seps)) : null;
            GuarantorPhNumBusiness = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedTelecommunicationNumber>(x, false, seps)) : null;
            GuarantorDateTimeOfBirth = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDateTime() : null;
            GuarantorAdministrativeSex = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[9], false, seps) : null;
            GuarantorType = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[10], false, seps) : null;
            GuarantorRelationship = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[11], false, seps) : null;
            GuarantorSsn = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
            GuarantorDateBegin = segments.Length > 13 && segments[13].Length > 0 ? segments[13].ToNullableDateTime() : null;
            GuarantorDateEnd = segments.Length > 14 && segments[14].Length > 0 ? segments[14].ToNullableDateTime() : null;
            GuarantorPriority = segments.Length > 15 && segments[15].Length > 0 ? segments[15].ToNullableDecimal() : null;
            GuarantorEmployerName = segments.Length > 16 && segments[16].Length > 0 ? segments[16].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedPersonName>(x, false, seps)) : null;
            GuarantorEmployerAddress = segments.Length > 17 && segments[17].Length > 0 ? segments[17].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedAddress>(x, false, seps)) : null;
            GuarantorEmployerPhoneNumber = segments.Length > 18 && segments[18].Length > 0 ? segments[18].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedTelecommunicationNumber>(x, false, seps)) : null;
            GuarantorEmployeeIdNumber = segments.Length > 19 && segments[19].Length > 0 ? segments[19].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false, seps)) : null;
            GuarantorEmploymentStatus = segments.Length > 20 && segments[20].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[20], false, seps) : null;
            GuarantorOrganizationName = segments.Length > 21 && segments[21].Length > 0 ? segments[21].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false, seps)) : null;
            GuarantorBillingHoldFlag = segments.Length > 22 && segments[22].Length > 0 ? segments[22] : null;
            GuarantorCreditRatingCode = segments.Length > 23 && segments[23].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[23], false, seps) : null;
            GuarantorDeathDateAndTime = segments.Length > 24 && segments[24].Length > 0 ? segments[24].ToNullableDateTime() : null;
            GuarantorDeathFlag = segments.Length > 25 && segments[25].Length > 0 ? segments[25] : null;
            GuarantorChargeAdjustmentCode = segments.Length > 26 && segments[26].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[26], false, seps) : null;
            GuarantorHouseholdAnnualIncome = segments.Length > 27 && segments[27].Length > 0 ? TypeSerializer.Deserialize<CompositePrice>(segments[27], false, seps) : null;
            GuarantorHouseholdSize = segments.Length > 28 && segments[28].Length > 0 ? segments[28].ToNullableDecimal() : null;
            GuarantorEmployerIdNumber = segments.Length > 29 && segments[29].Length > 0 ? segments[29].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false, seps)) : null;
            GuarantorMaritalStatusCode = segments.Length > 30 && segments[30].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[30], false, seps) : null;
            GuarantorHireEffectiveDate = segments.Length > 31 && segments[31].Length > 0 ? segments[31].ToNullableDateTime() : null;
            EmploymentStopDate = segments.Length > 32 && segments[32].Length > 0 ? segments[32].ToNullableDateTime() : null;
            LivingDependency = segments.Length > 33 && segments[33].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[33], false, seps) : null;
            AmbulatoryStatus = segments.Length > 34 && segments[34].Length > 0 ? segments[34].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            Citizenship = segments.Length > 35 && segments[35].Length > 0 ? segments[35].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            PrimaryLanguage = segments.Length > 36 && segments[36].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[36], false, seps) : null;
            LivingArrangement = segments.Length > 37 && segments[37].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[37], false, seps) : null;
            PublicityCode = segments.Length > 38 && segments[38].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[38], false, seps) : null;
            ProtectionIndicator = segments.Length > 39 && segments[39].Length > 0 ? segments[39] : null;
            StudentIndicator = segments.Length > 40 && segments[40].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[40], false, seps) : null;
            Religion = segments.Length > 41 && segments[41].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[41], false, seps) : null;
            MothersMaidenName = segments.Length > 42 && segments[42].Length > 0 ? segments[42].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedPersonName>(x, false, seps)) : null;
            Nationality = segments.Length > 43 && segments[43].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[43], false, seps) : null;
            EthnicGroup = segments.Length > 44 && segments[44].Length > 0 ? segments[44].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            ContactPersonsName = segments.Length > 45 && segments[45].Length > 0 ? segments[45].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedPersonName>(x, false, seps)) : null;
            ContactPersonsTelephoneNumber = segments.Length > 46 && segments[46].Length > 0 ? segments[46].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedTelecommunicationNumber>(x, false, seps)) : null;
            ContactReason = segments.Length > 47 && segments[47].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[47], false, seps) : null;
            ContactRelationship = segments.Length > 48 && segments[48].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[48], false, seps) : null;
            JobTitle = segments.Length > 49 && segments[49].Length > 0 ? segments[49] : null;
            JobCodeClass = segments.Length > 50 && segments[50].Length > 0 ? TypeSerializer.Deserialize<JobCodeClass>(segments[50], false, seps) : null;
            GuarantorEmployersOrganizationName = segments.Length > 51 && segments[51].Length > 0 ? segments[51].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false, seps)) : null;
            Handicap = segments.Length > 52 && segments[52].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[52], false, seps) : null;
            JobStatus = segments.Length > 53 && segments[53].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[53], false, seps) : null;
            GuarantorFinancialClass = segments.Length > 54 && segments[54].Length > 0 ? TypeSerializer.Deserialize<FinancialClass>(segments[54], false, seps) : null;
            GuarantorRace = segments.Length > 55 && segments[55].Length > 0 ? segments[55].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            GuarantorBirthPlace = segments.Length > 56 && segments[56].Length > 0 ? segments[56] : null;
            VipIndicator = segments.Length > 57 && segments[57].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[57], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 58, Configuration.FieldSeparator),
                                Id,
                                SetIdGt1.HasValue ? SetIdGt1.Value.ToString(culture) : null,
                                GuarantorNumber != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorNumber.Select(x => x.ToDelimitedString())) : null,
                                GuarantorName != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorName.Select(x => x.ToDelimitedString())) : null,
                                GuarantorSpouseName != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorSpouseName.Select(x => x.ToDelimitedString())) : null,
                                GuarantorAddress != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorAddress.Select(x => x.ToDelimitedString())) : null,
                                GuarantorPhNumHome != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorPhNumHome.Select(x => x.ToDelimitedString())) : null,
                                GuarantorPhNumBusiness != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorPhNumBusiness.Select(x => x.ToDelimitedString())) : null,
                                GuarantorDateTimeOfBirth?.ToHl7DateTimeString(typeof(Gt1Segment), nameof(GuarantorDateTimeOfBirth), Consts.DateTimeFormatPrecisionSecond, culture),
                                GuarantorAdministrativeSex?.ToDelimitedString(),
                                GuarantorType?.ToDelimitedString(),
                                GuarantorRelationship?.ToDelimitedString(),
                                GuarantorSsn,
                                GuarantorDateBegin?.ToHl7DateTimeString(typeof(Gt1Segment), nameof(GuarantorDateBegin), Consts.DateFormatPrecisionDay, culture),
                                GuarantorDateEnd?.ToHl7DateTimeString(typeof(Gt1Segment), nameof(GuarantorDateEnd), Consts.DateFormatPrecisionDay, culture),
                                GuarantorPriority.HasValue ? GuarantorPriority.Value.ToString(Consts.NumericFormat, culture) : null,
                                GuarantorEmployerName != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorEmployerName.Select(x => x.ToDelimitedString())) : null,
                                GuarantorEmployerAddress != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorEmployerAddress.Select(x => x.ToDelimitedString())) : null,
                                GuarantorEmployerPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorEmployerPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                GuarantorEmployeeIdNumber != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorEmployeeIdNumber.Select(x => x.ToDelimitedString())) : null,
                                GuarantorEmploymentStatus?.ToDelimitedString(),
                                GuarantorOrganizationName != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorOrganizationName.Select(x => x.ToDelimitedString())) : null,
                                GuarantorBillingHoldFlag,
                                GuarantorCreditRatingCode?.ToDelimitedString(),
                                GuarantorDeathDateAndTime?.ToHl7DateTimeString(typeof(Gt1Segment), nameof(GuarantorDeathDateAndTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                GuarantorDeathFlag,
                                GuarantorChargeAdjustmentCode?.ToDelimitedString(),
                                GuarantorHouseholdAnnualIncome?.ToDelimitedString(),
                                GuarantorHouseholdSize.HasValue ? GuarantorHouseholdSize.Value.ToString(Consts.NumericFormat, culture) : null,
                                GuarantorEmployerIdNumber != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorEmployerIdNumber.Select(x => x.ToDelimitedString())) : null,
                                GuarantorMaritalStatusCode?.ToDelimitedString(),
                                GuarantorHireEffectiveDate?.ToHl7DateTimeString(typeof(Gt1Segment), nameof(GuarantorHireEffectiveDate), Consts.DateFormatPrecisionDay, culture),
                                EmploymentStopDate?.ToHl7DateTimeString(typeof(Gt1Segment), nameof(EmploymentStopDate), Consts.DateFormatPrecisionDay, culture),
                                LivingDependency?.ToDelimitedString(),
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
                                ContactPersonsName != null ? string.Join(Configuration.FieldRepeatSeparator, ContactPersonsName.Select(x => x.ToDelimitedString())) : null,
                                ContactPersonsTelephoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, ContactPersonsTelephoneNumber.Select(x => x.ToDelimitedString())) : null,
                                ContactReason?.ToDelimitedString(),
                                ContactRelationship?.ToDelimitedString(),
                                JobTitle,
                                JobCodeClass?.ToDelimitedString(),
                                GuarantorEmployersOrganizationName != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorEmployersOrganizationName.Select(x => x.ToDelimitedString())) : null,
                                Handicap?.ToDelimitedString(),
                                JobStatus?.ToDelimitedString(),
                                GuarantorFinancialClass?.ToDelimitedString(),
                                GuarantorRace != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorRace.Select(x => x.ToDelimitedString())) : null,
                                GuarantorBirthPlace,
                                VipIndicator?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
