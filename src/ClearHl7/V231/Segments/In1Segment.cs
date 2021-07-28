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
    /// HL7 Version 2 Segment IN1 - Insurance.
    /// </summary>
    public class In1Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "IN1";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// IN1.1 - Set ID - IN1.
        /// </summary>
        public uint? SetIdIn1 { get; set; }

        /// <summary>
        /// IN1.2 - Health Plan ID.
        /// <para>Suggested: 0072 Insurance Plan ID</para>
        /// </summary>
        public CodedElement HealthPlanId { get; set; }

        /// <summary>
        /// IN1.3 - Insurance Company ID.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> InsuranceCompanyId { get; set; }

        /// <summary>
        /// IN1.4 - Insurance Company Name.
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> InsuranceCompanyName { get; set; }

        /// <summary>
        /// IN1.5 - Insurance Company Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> InsuranceCompanyAddress { get; set; }

        /// <summary>
        /// IN1.6 - Insurance Co Contact Person.
        /// </summary>
        public IEnumerable<ExtendedPersonName> InsuranceCoContactPerson { get; set; }

        /// <summary>
        /// IN1.7 - Insurance Co Phone Number.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> InsuranceCoPhoneNumber { get; set; }

        /// <summary>
        /// IN1.8 - Group Number.
        /// </summary>
        public string GroupNumber { get; set; }

        /// <summary>
        /// IN1.9 - Group Name.
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> GroupName { get; set; }

        /// <summary>
        /// IN1.10 - Insured's Group Emp ID.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> InsuredsGroupEmpId { get; set; }

        /// <summary>
        /// IN1.11 - Insured's Group Emp Name.
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> InsuredsGroupEmpName { get; set; }

        /// <summary>
        /// IN1.12 - Plan Effective Date.
        /// </summary>
        public DateTime? PlanEffectiveDate { get; set; }

        /// <summary>
        /// IN1.13 - Plan Expiration Date.
        /// </summary>
        public DateTime? PlanExpirationDate { get; set; }

        /// <summary>
        /// IN1.14 - Authorization Information.
        /// </summary>
        public AuthorizationInformation AuthorizationInformation { get; set; }

        /// <summary>
        /// IN1.15 - Plan Type.
        /// <para>Suggested: 0086 Plan ID</para>
        /// </summary>
        public string PlanType { get; set; }

        /// <summary>
        /// IN1.16 - Name Of Insured.
        /// </summary>
        public IEnumerable<ExtendedPersonName> NameOfInsured { get; set; }

        /// <summary>
        /// IN1.17 - Insured's Relationship To Patient.
        /// <para>Suggested: 0063 Relationship</para>
        /// </summary>
        public CodedElement InsuredsRelationshipToPatient { get; set; }

        /// <summary>
        /// IN1.18 - Insured's Date Of Birth.
        /// </summary>
        public DateTime? InsuredsDateOfBirth { get; set; }

        /// <summary>
        /// IN1.19 - Insured's Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> InsuredsAddress { get; set; }

        /// <summary>
        /// IN1.20 - Assignment Of Benefits.
        /// <para>Suggested: 0135 Assignment Of Benefits -&gt; ClearHl7.Codes.V231.CodeAssignmentOfBenefits</para>
        /// </summary>
        public string AssignmentOfBenefits { get; set; }

        /// <summary>
        /// IN1.21 - Coordination Of Benefits.
        /// <para>Suggested: 0173 Coordination Of Benefits -&gt; ClearHl7.Codes.V231.CodeCoordinationOfBenefits</para>
        /// </summary>
        public string CoordinationOfBenefits { get; set; }

        /// <summary>
        /// IN1.22 - Coord Of Ben. Priority.
        /// </summary>
        public string CoordOfBenPriority { get; set; }

        /// <summary>
        /// IN1.23 - Notice Of Admission Flag.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V231.CodeYesNoIndicator</para>
        /// </summary>
        public string NoticeOfAdmissionFlag { get; set; }

        /// <summary>
        /// IN1.24 - Notice Of Admission Date.
        /// </summary>
        public DateTime? NoticeOfAdmissionDate { get; set; }

        /// <summary>
        /// IN1.25 - Report Of Eligibility Flag.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V231.CodeYesNoIndicator</para>
        /// </summary>
        public string ReportOfEligibilityFlag { get; set; }

        /// <summary>
        /// IN1.26 - Report Of Eligibility Date.
        /// </summary>
        public DateTime? ReportOfEligibilityDate { get; set; }

        /// <summary>
        /// IN1.27 - Release Information Code.
        /// <para>Suggested: 0093 Release Information</para>
        /// </summary>
        public string ReleaseInformationCode { get; set; }

        /// <summary>
        /// IN1.28 - Pre-Admit Cert (PAC).
        /// </summary>
        public string PreAdmitCertPac { get; set; }

        /// <summary>
        /// IN1.29 - Verification Date/Time.
        /// </summary>
        public DateTime? VerificationDateTime { get; set; }

        /// <summary>
        /// IN1.30 - Verification By.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> VerificationBy { get; set; }

        /// <summary>
        /// IN1.31 - Type Of Agreement Code.
        /// <para>Suggested: 0098 Type Of Agreement -&gt; ClearHl7.Codes.V231.CodeTypeOfAgreement</para>
        /// </summary>
        public string TypeOfAgreementCode { get; set; }

        /// <summary>
        /// IN1.32 - Billing Status.
        /// <para>Suggested: 0022 Billing Status</para>
        /// </summary>
        public string BillingStatus { get; set; }

        /// <summary>
        /// IN1.33 - Lifetime Reserve Days.
        /// </summary>
        public decimal? LifetimeReserveDays { get; set; }

        /// <summary>
        /// IN1.34 - Delay Before L.R. Day.
        /// </summary>
        public decimal? DelayBeforeLRDay { get; set; }

        /// <summary>
        /// IN1.35 - Company Plan Code.
        /// <para>Suggested: 0042 Company Plan Code</para>
        /// </summary>
        public string CompanyPlanCode { get; set; }

        /// <summary>
        /// IN1.36 - Policy Number.
        /// </summary>
        public string PolicyNumber { get; set; }

        /// <summary>
        /// IN1.37 - Policy Deductible.
        /// </summary>
        public CompositePrice PolicyDeductible { get; set; }

        /// <summary>
        /// IN1.38 - Policy Limit - Amount.
        /// </summary>
        public CompositePrice PolicyLimitAmount { get; set; }

        /// <summary>
        /// IN1.39 - Policy Limit - Days.
        /// </summary>
        public decimal? PolicyLimitDays { get; set; }

        /// <summary>
        /// IN1.40 - Room Rate - Semi-Private.
        /// </summary>
        public CompositePrice RoomRateSemiPrivate { get; set; }

        /// <summary>
        /// IN1.41 - Room Rate - Private.
        /// </summary>
        public CompositePrice RoomRatePrivate { get; set; }

        /// <summary>
        /// IN1.42 - Insured's Employment Status.
        /// <para>Suggested: 0066 Employment Status</para>
        /// </summary>
        public CodedElement InsuredsEmploymentStatus { get; set; }

        /// <summary>
        /// IN1.43 - Insured's Administrative Sex.
        /// <para>Suggested: 0001 Administrative Sex -&gt; ClearHl7.Codes.V231.CodeAdministrativeSex</para>
        /// </summary>
        public string InsuredsAdministrativeSex { get; set; }

        /// <summary>
        /// IN1.44 - Insured's Employer's Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> InsuredsEmployersAddress { get; set; }

        /// <summary>
        /// IN1.45 - Verification Status.
        /// </summary>
        public string VerificationStatus { get; set; }

        /// <summary>
        /// IN1.46 - Prior Insurance Plan ID.
        /// <para>Suggested: 0072 Insurance Plan ID</para>
        /// </summary>
        public string PriorInsurancePlanId { get; set; }

        /// <summary>
        /// IN1.47 - Coverage Type.
        /// <para>Suggested: 0309 Coverage Type -&gt; ClearHl7.Codes.V231.CodeCoverageType</para>
        /// </summary>
        public string CoverageType { get; set; }

        /// <summary>
        /// IN1.48 - Handicap.
        /// <para>Suggested: 0295 Handicap</para>
        /// </summary>
        public string Handicap { get; set; }

        /// <summary>
        /// IN1.49 - Insured's ID Number.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> InsuredsIdNumber { get; set; }

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

            SetIdIn1 = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            HealthPlanId = segments.Length > 2 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(2), false) : null;
            InsuranceCompanyId = segments.Length > 3 ? segments.ElementAtOrDefault(3).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false)) : null;
            InsuranceCompanyName = segments.Length > 4 ? segments.ElementAtOrDefault(4).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false)) : null;
            InsuranceCompanyAddress = segments.Length > 5 ? segments.ElementAtOrDefault(5).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedAddress>(x, false)) : null;
            InsuranceCoContactPerson = segments.Length > 6 ? segments.ElementAtOrDefault(6).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedPersonName>(x, false)) : null;
            InsuranceCoPhoneNumber = segments.Length > 7 ? segments.ElementAtOrDefault(7).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            GroupNumber = segments.ElementAtOrDefault(8);
            GroupName = segments.Length > 9 ? segments.ElementAtOrDefault(9).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false)) : null;
            InsuredsGroupEmpId = segments.Length > 10 ? segments.ElementAtOrDefault(10).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false)) : null;
            InsuredsGroupEmpName = segments.Length > 11 ? segments.ElementAtOrDefault(11).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false)) : null;
            PlanEffectiveDate = segments.ElementAtOrDefault(12)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            PlanExpirationDate = segments.ElementAtOrDefault(13)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            AuthorizationInformation = segments.Length > 14 ? TypeHelper.Deserialize<AuthorizationInformation>(segments.ElementAtOrDefault(14), false) : null;
            PlanType = segments.ElementAtOrDefault(15);
            NameOfInsured = segments.Length > 16 ? segments.ElementAtOrDefault(16).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedPersonName>(x, false)) : null;
            InsuredsRelationshipToPatient = segments.Length > 17 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(17), false) : null;
            InsuredsDateOfBirth = segments.ElementAtOrDefault(18)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            InsuredsAddress = segments.Length > 19 ? segments.ElementAtOrDefault(19).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedAddress>(x, false)) : null;
            AssignmentOfBenefits = segments.ElementAtOrDefault(20);
            CoordinationOfBenefits = segments.ElementAtOrDefault(21);
            CoordOfBenPriority = segments.ElementAtOrDefault(22);
            NoticeOfAdmissionFlag = segments.ElementAtOrDefault(23);
            NoticeOfAdmissionDate = segments.ElementAtOrDefault(24)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            ReportOfEligibilityFlag = segments.ElementAtOrDefault(25);
            ReportOfEligibilityDate = segments.ElementAtOrDefault(26)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            ReleaseInformationCode = segments.ElementAtOrDefault(27);
            PreAdmitCertPac = segments.ElementAtOrDefault(28);
            VerificationDateTime = segments.ElementAtOrDefault(29)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            VerificationBy = segments.Length > 30 ? segments.ElementAtOrDefault(30).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            TypeOfAgreementCode = segments.ElementAtOrDefault(31);
            BillingStatus = segments.ElementAtOrDefault(32);
            LifetimeReserveDays = segments.ElementAtOrDefault(33)?.ToNullableDecimal();
            DelayBeforeLRDay = segments.ElementAtOrDefault(34)?.ToNullableDecimal();
            CompanyPlanCode = segments.ElementAtOrDefault(35);
            PolicyNumber = segments.ElementAtOrDefault(36);
            PolicyDeductible = segments.Length > 37 ? TypeHelper.Deserialize<CompositePrice>(segments.ElementAtOrDefault(37), false) : null;
            PolicyLimitAmount = segments.Length > 38 ? TypeHelper.Deserialize<CompositePrice>(segments.ElementAtOrDefault(38), false) : null;
            PolicyLimitDays = segments.ElementAtOrDefault(39)?.ToNullableDecimal();
            RoomRateSemiPrivate = segments.Length > 40 ? TypeHelper.Deserialize<CompositePrice>(segments.ElementAtOrDefault(40), false) : null;
            RoomRatePrivate = segments.Length > 41 ? TypeHelper.Deserialize<CompositePrice>(segments.ElementAtOrDefault(41), false) : null;
            InsuredsEmploymentStatus = segments.Length > 42 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(42), false) : null;
            InsuredsAdministrativeSex = segments.ElementAtOrDefault(43);
            InsuredsEmployersAddress = segments.Length > 44 ? segments.ElementAtOrDefault(44).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedAddress>(x, false)) : null;
            VerificationStatus = segments.ElementAtOrDefault(45);
            PriorInsurancePlanId = segments.ElementAtOrDefault(46);
            CoverageType = segments.ElementAtOrDefault(47);
            Handicap = segments.ElementAtOrDefault(48);
            InsuredsIdNumber = segments.Length > 49 ? segments.ElementAtOrDefault(49).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false)) : null;
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
                                StringHelper.StringFormatSequence(0, 50, Configuration.FieldSeparator),
                                Id,
                                SetIdIn1.HasValue ? SetIdIn1.Value.ToString(culture) : null,
                                HealthPlanId?.ToDelimitedString(),
                                InsuranceCompanyId != null ? string.Join(Configuration.FieldRepeatSeparator, InsuranceCompanyId.Select(x => x.ToDelimitedString())) : null,
                                InsuranceCompanyName != null ? string.Join(Configuration.FieldRepeatSeparator, InsuranceCompanyName.Select(x => x.ToDelimitedString())) : null,
                                InsuranceCompanyAddress != null ? string.Join(Configuration.FieldRepeatSeparator, InsuranceCompanyAddress.Select(x => x.ToDelimitedString())) : null,
                                InsuranceCoContactPerson != null ? string.Join(Configuration.FieldRepeatSeparator, InsuranceCoContactPerson.Select(x => x.ToDelimitedString())) : null,
                                InsuranceCoPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, InsuranceCoPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                GroupNumber,
                                GroupName != null ? string.Join(Configuration.FieldRepeatSeparator, GroupName.Select(x => x.ToDelimitedString())) : null,
                                InsuredsGroupEmpId != null ? string.Join(Configuration.FieldRepeatSeparator, InsuredsGroupEmpId.Select(x => x.ToDelimitedString())) : null,
                                InsuredsGroupEmpName != null ? string.Join(Configuration.FieldRepeatSeparator, InsuredsGroupEmpName.Select(x => x.ToDelimitedString())) : null,
                                PlanEffectiveDate.HasValue ? PlanEffectiveDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                PlanExpirationDate.HasValue ? PlanExpirationDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                AuthorizationInformation?.ToDelimitedString(),
                                PlanType,
                                NameOfInsured != null ? string.Join(Configuration.FieldRepeatSeparator, NameOfInsured.Select(x => x.ToDelimitedString())) : null,
                                InsuredsRelationshipToPatient?.ToDelimitedString(),
                                InsuredsDateOfBirth.HasValue ? InsuredsDateOfBirth.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                InsuredsAddress != null ? string.Join(Configuration.FieldRepeatSeparator, InsuredsAddress.Select(x => x.ToDelimitedString())) : null,
                                AssignmentOfBenefits,
                                CoordinationOfBenefits,
                                CoordOfBenPriority,
                                NoticeOfAdmissionFlag,
                                NoticeOfAdmissionDate.HasValue ? NoticeOfAdmissionDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ReportOfEligibilityFlag,
                                ReportOfEligibilityDate.HasValue ? ReportOfEligibilityDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ReleaseInformationCode,
                                PreAdmitCertPac,
                                VerificationDateTime.HasValue ? VerificationDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                VerificationBy != null ? string.Join(Configuration.FieldRepeatSeparator, VerificationBy.Select(x => x.ToDelimitedString())) : null,
                                TypeOfAgreementCode,
                                BillingStatus,
                                LifetimeReserveDays.HasValue ? LifetimeReserveDays.Value.ToString(Consts.NumericFormat, culture) : null,
                                DelayBeforeLRDay.HasValue ? DelayBeforeLRDay.Value.ToString(Consts.NumericFormat, culture) : null,
                                CompanyPlanCode,
                                PolicyNumber,
                                PolicyDeductible?.ToDelimitedString(),
                                PolicyLimitAmount?.ToDelimitedString(),
                                PolicyLimitDays.HasValue ? PolicyLimitDays.Value.ToString(Consts.NumericFormat, culture) : null,
                                RoomRateSemiPrivate?.ToDelimitedString(),
                                RoomRatePrivate?.ToDelimitedString(),
                                InsuredsEmploymentStatus?.ToDelimitedString(),
                                InsuredsAdministrativeSex,
                                InsuredsEmployersAddress != null ? string.Join(Configuration.FieldRepeatSeparator, InsuredsEmployersAddress.Select(x => x.ToDelimitedString())) : null,
                                VerificationStatus,
                                PriorInsurancePlanId,
                                CoverageType,
                                Handicap,
                                InsuredsIdNumber != null ? string.Join(Configuration.FieldRepeatSeparator, InsuredsIdNumber.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}