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
    /// HL7 Version 2 Segment GT1 - Guarantor.
    /// </summary>
    public class Gt1Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "GT1";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
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
        /// <para>Suggested: 0001 Administrative Sex -&gt; ClearHl7.Codes.V290.CodeAdministrativeSex</para>
        /// </summary>
        public CodedWithExceptions GuarantorAdministrativeSex { get; set; }

        /// <summary>
        /// GT1.10 - Guarantor Type.
        /// <para>Suggested: 0068 Guarantor Type</para>
        /// </summary>
        public CodedWithExceptions GuarantorType { get; set; }

        /// <summary>
        /// GT1.11 - Guarantor Relationship.
        /// <para>Suggested: 0063 Relationship -&gt; ClearHl7.Codes.V290.CodeRelationship</para>
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
        /// <para>Suggested: 0066 Employment Status -&gt; ClearHl7.Codes.V290.CodeEmploymentStatus</para>
        /// </summary>
        public CodedWithExceptions GuarantorEmploymentStatus { get; set; }

        /// <summary>
        /// GT1.21 - Guarantor Organization Name.
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> GuarantorOrganizationName { get; set; }

        /// <summary>
        /// GT1.22 - Guarantor Billing Hold Flag.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
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
        /// <para>Suggested: 0002 Marital Status -&gt; ClearHl7.Codes.V290.CodeMaritalStatus</para>
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
        /// <para>Suggested: 0223 Living Dependency -&gt; ClearHl7.Codes.V290.CodeLivingDependency</para>
        /// </summary>
        public CodedWithExceptions LivingDependency { get; set; }

        /// <summary>
        /// GT1.34 - Ambulatory Status.
        /// <para>Suggested: 0009 Ambulatory Status -&gt; ClearHl7.Codes.V290.CodeAmbulatoryStatus</para>
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
        /// <para>Suggested: 0220 Living Arrangement -&gt; ClearHl7.Codes.V290.CodeLivingArrangement</para>
        /// </summary>
        public CodedWithExceptions LivingArrangement { get; set; }

        /// <summary>
        /// GT1.38 - Publicity Code.
        /// <para>Suggested: 0215 Publicity Code -&gt; ClearHl7.Codes.V290.CodePublicityCode</para>
        /// </summary>
        public CodedWithExceptions PublicityCode { get; set; }

        /// <summary>
        /// GT1.39 - Protection Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public string ProtectionIndicator { get; set; }

        /// <summary>
        /// GT1.40 - Student Indicator.
        /// <para>Suggested: 0231 Student Status -&gt; ClearHl7.Codes.V290.CodeStudentStatus</para>
        /// </summary>
        public CodedWithExceptions StudentIndicator { get; set; }

        /// <summary>
        /// GT1.41 - Religion.
        /// <para>Suggested: 0006 Religion -&gt; ClearHl7.Codes.V290.CodeReligion</para>
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
        /// <para>Suggested: 0189 Ethnic Group -&gt; ClearHl7.Codes.V290.CodeEthnicGroup</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> EthnicGroup { get; set; }

        /// <summary>
        /// GT1.45 - Contact Person's Name.
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
        /// <para>Suggested: 0063 Relationship -&gt; ClearHl7.Codes.V290.CodeRelationship</para>
        /// </summary>
        public CodedWithExceptions ContactRelationship { get; set; }

        /// <summary>
        /// GT1.49 - Job Title.
        /// </summary>
        public string JobTitle { get; set; }

        /// <summary>
        /// GT1.50 - Job Code/Class.
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
        /// <para>Suggested: 0311 Job Status -&gt; ClearHl7.Codes.V290.CodeJobStatus</para>
        /// </summary>
        public CodedWithExceptions JobStatus { get; set; }

        /// <summary>
        /// GT1.54 - Guarantor Financial Class.
        /// </summary>
        public FinancialClass GuarantorFinancialClass { get; set; }

        /// <summary>
        /// GT1.55 - Guarantor Race.
        /// <para>Suggested: 0005 Race -&gt; ClearHl7.Codes.V290.CodeRace</para>
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

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public Gt1Segment FromDelimitedString(string delimitedString)
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

            SetIdGt1 = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            GuarantorNumber = segments.Length > 2 ? segments.ElementAtOrDefault(2).Split(separator).Select(x => new ExtendedCompositeIdWithCheckDigit().FromDelimitedString(x)) : null;
            GuarantorName = segments.Length > 3 ? segments.ElementAtOrDefault(3).Split(separator).Select(x => new ExtendedPersonName().FromDelimitedString(x)) : null;
            GuarantorSpouseName = segments.Length > 4 ? segments.ElementAtOrDefault(4).Split(separator).Select(x => new ExtendedPersonName().FromDelimitedString(x)) : null;
            GuarantorAddress = segments.Length > 5 ? segments.ElementAtOrDefault(5).Split(separator).Select(x => new ExtendedAddress().FromDelimitedString(x)) : null;
            GuarantorPhNumHome = segments.Length > 6 ? segments.ElementAtOrDefault(6).Split(separator).Select(x => new ExtendedTelecommunicationNumber().FromDelimitedString(x)) : null;
            GuarantorPhNumBusiness = segments.Length > 7 ? segments.ElementAtOrDefault(7).Split(separator).Select(x => new ExtendedTelecommunicationNumber().FromDelimitedString(x)) : null;
            GuarantorDateTimeOfBirth = segments.ElementAtOrDefault(8)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            GuarantorAdministrativeSex = segments.Length > 9 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(9)) : null;
            GuarantorType = segments.Length > 10 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(10)) : null;
            GuarantorRelationship = segments.Length > 11 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(11)) : null;
            GuarantorSsn = segments.ElementAtOrDefault(12);
            GuarantorDateBegin = segments.ElementAtOrDefault(13)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            GuarantorDateEnd = segments.ElementAtOrDefault(14)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            GuarantorPriority = segments.ElementAtOrDefault(15)?.ToNullableDecimal();
            GuarantorEmployerName = segments.Length > 16 ? segments.ElementAtOrDefault(16).Split(separator).Select(x => new ExtendedPersonName().FromDelimitedString(x)) : null;
            GuarantorEmployerAddress = segments.Length > 17 ? segments.ElementAtOrDefault(17).Split(separator).Select(x => new ExtendedAddress().FromDelimitedString(x)) : null;
            GuarantorEmployerPhoneNumber = segments.Length > 18 ? segments.ElementAtOrDefault(18).Split(separator).Select(x => new ExtendedTelecommunicationNumber().FromDelimitedString(x)) : null;
            GuarantorEmployeeIdNumber = segments.Length > 19 ? segments.ElementAtOrDefault(19).Split(separator).Select(x => new ExtendedCompositeIdWithCheckDigit().FromDelimitedString(x)) : null;
            GuarantorEmploymentStatus = segments.Length > 20 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(20)) : null;
            GuarantorOrganizationName = segments.Length > 21 ? segments.ElementAtOrDefault(21).Split(separator).Select(x => new ExtendedCompositeNameAndIdNumberForOrganizations().FromDelimitedString(x)) : null;
            GuarantorBillingHoldFlag = segments.ElementAtOrDefault(22);
            GuarantorCreditRatingCode = segments.Length > 23 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(23)) : null;
            GuarantorDeathDateAndTime = segments.ElementAtOrDefault(24)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            GuarantorDeathFlag = segments.ElementAtOrDefault(25);
            GuarantorChargeAdjustmentCode = segments.Length > 26 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(26)) : null;
            GuarantorHouseholdAnnualIncome = segments.Length > 27 ? new CompositePrice().FromDelimitedString(segments.ElementAtOrDefault(27)) : null;
            GuarantorHouseholdSize = segments.ElementAtOrDefault(28)?.ToNullableDecimal();
            GuarantorEmployerIdNumber = segments.Length > 29 ? segments.ElementAtOrDefault(29).Split(separator).Select(x => new ExtendedCompositeIdWithCheckDigit().FromDelimitedString(x)) : null;
            GuarantorMaritalStatusCode = segments.Length > 30 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(30)) : null;
            GuarantorHireEffectiveDate = segments.ElementAtOrDefault(31)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            EmploymentStopDate = segments.ElementAtOrDefault(32)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            LivingDependency = segments.Length > 33 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(33)) : null;
            AmbulatoryStatus = segments.Length > 34 ? segments.ElementAtOrDefault(34).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            Citizenship = segments.Length > 35 ? segments.ElementAtOrDefault(35).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            PrimaryLanguage = segments.Length > 36 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(36)) : null;
            LivingArrangement = segments.Length > 37 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(37)) : null;
            PublicityCode = segments.Length > 38 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(38)) : null;
            ProtectionIndicator = segments.ElementAtOrDefault(39);
            StudentIndicator = segments.Length > 40 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(40)) : null;
            Religion = segments.Length > 41 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(41)) : null;
            MothersMaidenName = segments.Length > 42 ? segments.ElementAtOrDefault(42).Split(separator).Select(x => new ExtendedPersonName().FromDelimitedString(x)) : null;
            Nationality = segments.Length > 43 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(43)) : null;
            EthnicGroup = segments.Length > 44 ? segments.ElementAtOrDefault(44).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            ContactPersonsName = segments.Length > 45 ? segments.ElementAtOrDefault(45).Split(separator).Select(x => new ExtendedPersonName().FromDelimitedString(x)) : null;
            ContactPersonsTelephoneNumber = segments.Length > 46 ? segments.ElementAtOrDefault(46).Split(separator).Select(x => new ExtendedTelecommunicationNumber().FromDelimitedString(x)) : null;
            ContactReason = segments.Length > 47 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(47)) : null;
            ContactRelationship = segments.Length > 48 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(48)) : null;
            JobTitle = segments.ElementAtOrDefault(49);
            JobCodeClass = segments.Length > 50 ? new JobCodeClass().FromDelimitedString(segments.ElementAtOrDefault(50)) : null;
            GuarantorEmployersOrganizationName = segments.Length > 51 ? segments.ElementAtOrDefault(51).Split(separator).Select(x => new ExtendedCompositeNameAndIdNumberForOrganizations().FromDelimitedString(x)) : null;
            Handicap = segments.Length > 52 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(52)) : null;
            JobStatus = segments.Length > 53 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(53)) : null;
            GuarantorFinancialClass = segments.Length > 54 ? new FinancialClass().FromDelimitedString(segments.ElementAtOrDefault(54)) : null;
            GuarantorRace = segments.Length > 55 ? segments.ElementAtOrDefault(55).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            GuarantorBirthPlace = segments.ElementAtOrDefault(56);
            VipIndicator = segments.Length > 57 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(57)) : null;

            return this;
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
                                StringHelper.StringFormatSequence(0, 58, Configuration.FieldSeparator),
                                Id,
                                SetIdGt1.HasValue ? SetIdGt1.Value.ToString(culture) : null,
                                GuarantorNumber != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorNumber.Select(x => x.ToDelimitedString())) : null,
                                GuarantorName != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorName.Select(x => x.ToDelimitedString())) : null,
                                GuarantorSpouseName != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorSpouseName.Select(x => x.ToDelimitedString())) : null,
                                GuarantorAddress != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorAddress.Select(x => x.ToDelimitedString())) : null,
                                GuarantorPhNumHome != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorPhNumHome.Select(x => x.ToDelimitedString())) : null,
                                GuarantorPhNumBusiness != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorPhNumBusiness.Select(x => x.ToDelimitedString())) : null,
                                GuarantorDateTimeOfBirth.HasValue ? GuarantorDateTimeOfBirth.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                GuarantorAdministrativeSex?.ToDelimitedString(),
                                GuarantorType?.ToDelimitedString(),
                                GuarantorRelationship?.ToDelimitedString(),
                                GuarantorSsn,
                                GuarantorDateBegin.HasValue ? GuarantorDateBegin.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                GuarantorDateEnd.HasValue ? GuarantorDateEnd.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                GuarantorPriority.HasValue ? GuarantorPriority.Value.ToString(Consts.NumericFormat, culture) : null,
                                GuarantorEmployerName != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorEmployerName.Select(x => x.ToDelimitedString())) : null,
                                GuarantorEmployerAddress != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorEmployerAddress.Select(x => x.ToDelimitedString())) : null,
                                GuarantorEmployerPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorEmployerPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                GuarantorEmployeeIdNumber != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorEmployeeIdNumber.Select(x => x.ToDelimitedString())) : null,
                                GuarantorEmploymentStatus?.ToDelimitedString(),
                                GuarantorOrganizationName != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorOrganizationName.Select(x => x.ToDelimitedString())) : null,
                                GuarantorBillingHoldFlag,
                                GuarantorCreditRatingCode?.ToDelimitedString(),
                                GuarantorDeathDateAndTime.HasValue ? GuarantorDeathDateAndTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                GuarantorDeathFlag,
                                GuarantorChargeAdjustmentCode?.ToDelimitedString(),
                                GuarantorHouseholdAnnualIncome?.ToDelimitedString(),
                                GuarantorHouseholdSize.HasValue ? GuarantorHouseholdSize.Value.ToString(Consts.NumericFormat, culture) : null,
                                GuarantorEmployerIdNumber != null ? string.Join(Configuration.FieldRepeatSeparator, GuarantorEmployerIdNumber.Select(x => x.ToDelimitedString())) : null,
                                GuarantorMaritalStatusCode?.ToDelimitedString(),
                                GuarantorHireEffectiveDate.HasValue ? GuarantorHireEffectiveDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                EmploymentStopDate.HasValue ? EmploymentStopDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
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