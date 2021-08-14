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
    /// HL7 Version 2 Segment IN2 - Insurance Additional Information.
    /// </summary>
    public class In2Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "IN2";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// IN2.1 - Insured's Employee ID.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> InsuredsEmployeeId { get; set; }

        /// <summary>
        /// IN2.2 - Insured's Social Security Number.
        /// </summary>
        public string InsuredsSocialSecurityNumber { get; set; }

        /// <summary>
        /// IN2.3 - Insured's Employer's Name and ID.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> InsuredsEmployersNameAndId { get; set; }

        /// <summary>
        /// IN2.4 - Employer Information Data.
        /// <para>Suggested: 0139 Employer Information Data</para>
        /// </summary>
        public string EmployerInformationData { get; set; }

        /// <summary>
        /// IN2.5 - Mail Claim Party.
        /// <para>Suggested: 0137 Mail Claim Party -&gt; ClearHl7.Codes.V231.CodeMailClaimParty</para>
        /// </summary>
        public IEnumerable<string> MailClaimParty { get; set; }

        /// <summary>
        /// IN2.6 - Medicare Health Ins Card Number.
        /// </summary>
        public string MedicareHealthInsCardNumber { get; set; }

        /// <summary>
        /// IN2.7 - Medicaid Case Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> MedicaidCaseName { get; set; }

        /// <summary>
        /// IN2.8 - Medicaid Case Number.
        /// </summary>
        public string MedicaidCaseNumber { get; set; }

        /// <summary>
        /// IN2.9 - Military Sponsor Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> MilitarySponsorName { get; set; }

        /// <summary>
        /// IN2.10 - Military ID Number.
        /// </summary>
        public string MilitaryIdNumber { get; set; }

        /// <summary>
        /// IN2.11 - Dependent Of Military Recipient.
        /// <para>Suggested: 0342 Military Recipient</para>
        /// </summary>
        public CodedElement DependentOfMilitaryRecipient { get; set; }

        /// <summary>
        /// IN2.12 - Military Organization.
        /// </summary>
        public string MilitaryOrganization { get; set; }

        /// <summary>
        /// IN2.13 - Military Station.
        /// </summary>
        public string MilitaryStation { get; set; }

        /// <summary>
        /// IN2.14 - Military Service.
        /// <para>Suggested: 0140 Military Service -&gt; ClearHl7.Codes.V231.CodeMilitaryService</para>
        /// </summary>
        public string MilitaryService { get; set; }

        /// <summary>
        /// IN2.15 - Military Rank/Grade.
        /// <para>Suggested: 0141 Military Rank/Grade -&gt; ClearHl7.Codes.V231.CodeMilitaryRankGrade</para>
        /// </summary>
        public string MilitaryRankGrade { get; set; }

        /// <summary>
        /// IN2.16 - Military Status.
        /// <para>Suggested: 0142 Military Status -&gt; ClearHl7.Codes.V231.CodeMilitaryStatus</para>
        /// </summary>
        public string MilitaryStatus { get; set; }

        /// <summary>
        /// IN2.17 - Military Retire Date.
        /// </summary>
        public DateTime? MilitaryRetireDate { get; set; }

        /// <summary>
        /// IN2.18 - Military Non-Avail Cert On File.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V231.CodeYesNoIndicator</para>
        /// </summary>
        public string MilitaryNonAvailCertOnFile { get; set; }

        /// <summary>
        /// IN2.19 - Baby Coverage.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V231.CodeYesNoIndicator</para>
        /// </summary>
        public string BabyCoverage { get; set; }

        /// <summary>
        /// IN2.20 - Combine Baby Bill.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V231.CodeYesNoIndicator</para>
        /// </summary>
        public string CombineBabyBill { get; set; }

        /// <summary>
        /// IN2.21 - Blood Deductible.
        /// </summary>
        public string BloodDeductible { get; set; }

        /// <summary>
        /// IN2.22 - Special Coverage Approval Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> SpecialCoverageApprovalName { get; set; }

        /// <summary>
        /// IN2.23 - Special Coverage Approval Title.
        /// </summary>
        public string SpecialCoverageApprovalTitle { get; set; }

        /// <summary>
        /// IN2.24 - Non-Covered Insurance Code.
        /// <para>Suggested: 0143 Non-Covered Insurance Code</para>
        /// </summary>
        public IEnumerable<string> NonCoveredInsuranceCode { get; set; }

        /// <summary>
        /// IN2.25 - Payor ID.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> PayorId { get; set; }

        /// <summary>
        /// IN2.26 - Payor Subscriber ID.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> PayorSubscriberId { get; set; }

        /// <summary>
        /// IN2.27 - Eligibility Source.
        /// <para>Suggested: 0144 Eligibility Source -&gt; ClearHl7.Codes.V231.CodeEligibilitySource</para>
        /// </summary>
        public string EligibilitySource { get; set; }

        /// <summary>
        /// IN2.28 - Room Coverage Type/Amount.
        /// </summary>
        public IEnumerable<RoomCoverage> RoomCoverageTypeAmount { get; set; }

        /// <summary>
        /// IN2.29 - Policy Type/Amount.
        /// </summary>
        public IEnumerable<PolicyTypeAndAmount> PolicyTypeAmount { get; set; }

        /// <summary>
        /// IN2.30 - Daily Deductible.
        /// </summary>
        public DailyDeductibleInformation DailyDeductible { get; set; }

        /// <summary>
        /// IN2.31 - Living Dependency.
        /// <para>Suggested: 0223 Living Dependency -&gt; ClearHl7.Codes.V231.CodeLivingDependency</para>
        /// </summary>
        public string LivingDependency { get; set; }

        /// <summary>
        /// IN2.32 - Ambulatory Status.
        /// <para>Suggested: 0009 Ambulatory Status -&gt; ClearHl7.Codes.V231.CodeAmbulatoryStatus</para>
        /// </summary>
        public IEnumerable<string> AmbulatoryStatus { get; set; }

        /// <summary>
        /// IN2.33 - Citizenship.
        /// <para>Suggested: 0171 Citizenship</para>
        /// </summary>
        public IEnumerable<CodedElement> Citizenship { get; set; }

        /// <summary>
        /// IN2.34 - Primary Language.
        /// <para>Suggested: 0296 Primary Language</para>
        /// </summary>
        public CodedElement PrimaryLanguage { get; set; }

        /// <summary>
        /// IN2.35 - Living Arrangement.
        /// <para>Suggested: 0220 Living Arrangement -&gt; ClearHl7.Codes.V231.CodeLivingArrangement</para>
        /// </summary>
        public string LivingArrangement { get; set; }

        /// <summary>
        /// IN2.36 - Publicity Code.
        /// <para>Suggested: 0215 Publicity Code</para>
        /// </summary>
        public CodedElement PublicityCode { get; set; }

        /// <summary>
        /// IN2.37 - Protection Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V231.CodeYesNoIndicator</para>
        /// </summary>
        public string ProtectionIndicator { get; set; }

        /// <summary>
        /// IN2.38 - Student Indicator.
        /// <para>Suggested: 0231 Student Status -&gt; ClearHl7.Codes.V231.CodeStudentStatus</para>
        /// </summary>
        public string StudentIndicator { get; set; }

        /// <summary>
        /// IN2.39 - Religion.
        /// <para>Suggested: 0006 Religion -&gt; ClearHl7.Codes.V231.CodeReligion</para>
        /// </summary>
        public CodedElement Religion { get; set; }

        /// <summary>
        /// IN2.40 - Mother's Maiden Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> MothersMaidenName { get; set; }

        /// <summary>
        /// IN2.41 - Nationality.
        /// <para>Suggested: 0212 Nationality</para>
        /// </summary>
        public CodedElement Nationality { get; set; }

        /// <summary>
        /// IN2.42 - Ethnic Group.
        /// <para>Suggested: 0189 Ethnic Group</para>
        /// </summary>
        public IEnumerable<CodedElement> EthnicGroup { get; set; }

        /// <summary>
        /// IN2.43 - Marital Status.
        /// <para>Suggested: 0002 Marital Status -&gt; ClearHl7.Codes.V231.CodeMaritalStatus</para>
        /// </summary>
        public IEnumerable<CodedElement> MaritalStatus { get; set; }

        /// <summary>
        /// IN2.44 - Insured's Employment Start Date.
        /// </summary>
        public DateTime? InsuredsEmploymentStartDate { get; set; }

        /// <summary>
        /// IN2.45 - Employment Stop Date.
        /// </summary>
        public DateTime? EmploymentStopDate { get; set; }

        /// <summary>
        /// IN2.46 - Job Title.
        /// </summary>
        public string JobTitle { get; set; }

        /// <summary>
        /// IN2.47 - Job Code/Class.
        /// </summary>
        public JobCodeClass JobCodeClass { get; set; }

        /// <summary>
        /// IN2.48 - Job Status.
        /// <para>Suggested: 0311 Job Status</para>
        /// </summary>
        public string JobStatus { get; set; }

        /// <summary>
        /// IN2.49 - Employer Contact Person Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> EmployerContactPersonName { get; set; }

        /// <summary>
        /// IN2.50 - Employer Contact Person Phone Number.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> EmployerContactPersonPhoneNumber { get; set; }

        /// <summary>
        /// IN2.51 - Employer Contact Reason.
        /// <para>Suggested: 0222 Contact Reason</para>
        /// </summary>
        public string EmployerContactReason { get; set; }

        /// <summary>
        /// IN2.52 - Insured's Contact Person's Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> InsuredsContactPersonsName { get; set; }

        /// <summary>
        /// IN2.53 - Insured's Contact Person Phone Number.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> InsuredsContactPersonPhoneNumber { get; set; }

        /// <summary>
        /// IN2.54 - Insured's Contact Person Reason.
        /// <para>Suggested: 0222 Contact Reason</para>
        /// </summary>
        public IEnumerable<string> InsuredsContactPersonReason { get; set; }

        /// <summary>
        /// IN2.55 - Relationship to the Patient Start Date.
        /// </summary>
        public DateTime? RelationshipToThePatientStartDate { get; set; }

        /// <summary>
        /// IN2.56 - Relationship to the Patient Stop Date.
        /// </summary>
        public IEnumerable<DateTime> RelationshipToThePatientStopDate { get; set; }

        /// <summary>
        /// IN2.57 - Insurance Co Contact Reason.
        /// <para>Suggested: 0232 Insurance Company Contact Reason -&gt; ClearHl7.Codes.V231.CodeInsuranceCompanyContactReason</para>
        /// </summary>
        public string InsuranceCoContactReason { get; set; }

        /// <summary>
        /// IN2.58 - Insurance Co Contact Phone Number.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> InsuranceCoContactPhoneNumber { get; set; }

        /// <summary>
        /// IN2.59 - Policy Scope.
        /// <para>Suggested: 0312 Policy Scope</para>
        /// </summary>
        public string PolicyScope { get; set; }

        /// <summary>
        /// IN2.60 - Policy Source.
        /// <para>Suggested: 0313 Policy Source</para>
        /// </summary>
        public string PolicySource { get; set; }

        /// <summary>
        /// IN2.61 - Patient Member Number.
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit PatientMemberNumber { get; set; }

        /// <summary>
        /// IN2.62 - Guarantor's Relationship to Insured.
        /// <para>Suggested: 0063 Relationship</para>
        /// </summary>
        public CodedElement GuarantorsRelationshipToInsured { get; set; }

        /// <summary>
        /// IN2.63 - Insured's Phone Number - Home.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> InsuredsPhoneNumberHome { get; set; }

        /// <summary>
        /// IN2.64 - Insured's Employer Phone Number.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> InsuredsEmployerPhoneNumber { get; set; }

        /// <summary>
        /// IN2.65 - Military Handicapped Program.
        /// <para>Suggested: 0343 Military Handicapped Program Code</para>
        /// </summary>
        public CodedElement MilitaryHandicappedProgram { get; set; }

        /// <summary>
        /// IN2.66 - Suspend Flag.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V231.CodeYesNoIndicator</para>
        /// </summary>
        public string SuspendFlag { get; set; }

        /// <summary>
        /// IN2.67 - Copay Limit Flag.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V231.CodeYesNoIndicator</para>
        /// </summary>
        public string CopayLimitFlag { get; set; }

        /// <summary>
        /// IN2.68 - Stoploss Limit Flag.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V231.CodeYesNoIndicator</para>
        /// </summary>
        public string StoplossLimitFlag { get; set; }

        /// <summary>
        /// IN2.69 - Insured Organization Name and ID.
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> InsuredOrganizationNameAndId { get; set; }

        /// <summary>
        /// IN2.70 - Insured Employer Organization Name and ID.
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> InsuredEmployerOrganizationNameAndId { get; set; }

        /// <summary>
        /// IN2.71 - Race.
        /// <para>Suggested: 0005 Race -&gt; ClearHl7.Codes.V231.CodeRace</para>
        /// </summary>
        public IEnumerable<CodedElement> Race { get; set; }

        /// <summary>
        /// IN2.72 - Patient's Relationship to Insured.
        /// <para>Suggested: 0344 Patient's Relationship to Insured -&gt; ClearHl7.Codes.V231.CodePatientsRelationshiptoInsured</para>
        /// </summary>
        public CodedElement PatientsRelationshipToInsured { get; set; }

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

            InsuredsEmployeeId = segments.Length > 1 ? segments.ElementAtOrDefault(1).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false)) : null;
            InsuredsSocialSecurityNumber = segments.ElementAtOrDefault(2);
            InsuredsEmployersNameAndId = segments.Length > 3 ? segments.ElementAtOrDefault(3).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            EmployerInformationData = segments.ElementAtOrDefault(4);
            MailClaimParty = segments.Length > 5 ? segments.ElementAtOrDefault(5).Split(separator) : null;
            MedicareHealthInsCardNumber = segments.ElementAtOrDefault(6);
            MedicaidCaseName = segments.Length > 7 ? segments.ElementAtOrDefault(7).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedPersonName>(x, false)) : null;
            MedicaidCaseNumber = segments.ElementAtOrDefault(8);
            MilitarySponsorName = segments.Length > 9 ? segments.ElementAtOrDefault(9).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedPersonName>(x, false)) : null;
            MilitaryIdNumber = segments.ElementAtOrDefault(10);
            DependentOfMilitaryRecipient = segments.Length > 11 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(11), false) : null;
            MilitaryOrganization = segments.ElementAtOrDefault(12);
            MilitaryStation = segments.ElementAtOrDefault(13);
            MilitaryService = segments.ElementAtOrDefault(14);
            MilitaryRankGrade = segments.ElementAtOrDefault(15);
            MilitaryStatus = segments.ElementAtOrDefault(16);
            MilitaryRetireDate = segments.ElementAtOrDefault(17)?.ToNullableDateTime();
            MilitaryNonAvailCertOnFile = segments.ElementAtOrDefault(18);
            BabyCoverage = segments.ElementAtOrDefault(19);
            CombineBabyBill = segments.ElementAtOrDefault(20);
            BloodDeductible = segments.ElementAtOrDefault(21);
            SpecialCoverageApprovalName = segments.Length > 22 ? segments.ElementAtOrDefault(22).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedPersonName>(x, false)) : null;
            SpecialCoverageApprovalTitle = segments.ElementAtOrDefault(23);
            NonCoveredInsuranceCode = segments.Length > 24 ? segments.ElementAtOrDefault(24).Split(separator) : null;
            PayorId = segments.Length > 25 ? segments.ElementAtOrDefault(25).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false)) : null;
            PayorSubscriberId = segments.Length > 26 ? segments.ElementAtOrDefault(26).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false)) : null;
            EligibilitySource = segments.ElementAtOrDefault(27);
            RoomCoverageTypeAmount = segments.Length > 28 ? segments.ElementAtOrDefault(28).Split(separator).Select(x => TypeHelper.Deserialize<RoomCoverage>(x, false)) : null;
            PolicyTypeAmount = segments.Length > 29 ? segments.ElementAtOrDefault(29).Split(separator).Select(x => TypeHelper.Deserialize<PolicyTypeAndAmount>(x, false)) : null;
            DailyDeductible = segments.Length > 30 ? TypeHelper.Deserialize<DailyDeductibleInformation>(segments.ElementAtOrDefault(30), false) : null;
            LivingDependency = segments.ElementAtOrDefault(31);
            AmbulatoryStatus = segments.Length > 32 ? segments.ElementAtOrDefault(32).Split(separator) : null;
            Citizenship = segments.Length > 33 ? segments.ElementAtOrDefault(33).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            PrimaryLanguage = segments.Length > 34 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(34), false) : null;
            LivingArrangement = segments.ElementAtOrDefault(35);
            PublicityCode = segments.Length > 36 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(36), false) : null;
            ProtectionIndicator = segments.ElementAtOrDefault(37);
            StudentIndicator = segments.ElementAtOrDefault(38);
            Religion = segments.Length > 39 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(39), false) : null;
            MothersMaidenName = segments.Length > 40 ? segments.ElementAtOrDefault(40).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedPersonName>(x, false)) : null;
            Nationality = segments.Length > 41 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(41), false) : null;
            EthnicGroup = segments.Length > 42 ? segments.ElementAtOrDefault(42).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            MaritalStatus = segments.Length > 43 ? segments.ElementAtOrDefault(43).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            InsuredsEmploymentStartDate = segments.ElementAtOrDefault(44)?.ToNullableDateTime();
            EmploymentStopDate = segments.ElementAtOrDefault(45)?.ToNullableDateTime();
            JobTitle = segments.ElementAtOrDefault(46);
            JobCodeClass = segments.Length > 47 ? TypeHelper.Deserialize<JobCodeClass>(segments.ElementAtOrDefault(47), false) : null;
            JobStatus = segments.ElementAtOrDefault(48);
            EmployerContactPersonName = segments.Length > 49 ? segments.ElementAtOrDefault(49).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedPersonName>(x, false)) : null;
            EmployerContactPersonPhoneNumber = segments.Length > 50 ? segments.ElementAtOrDefault(50).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            EmployerContactReason = segments.ElementAtOrDefault(51);
            InsuredsContactPersonsName = segments.Length > 52 ? segments.ElementAtOrDefault(52).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedPersonName>(x, false)) : null;
            InsuredsContactPersonPhoneNumber = segments.Length > 53 ? segments.ElementAtOrDefault(53).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            InsuredsContactPersonReason = segments.Length > 54 ? segments.ElementAtOrDefault(54).Split(separator) : null;
            RelationshipToThePatientStartDate = segments.ElementAtOrDefault(55)?.ToNullableDateTime();
            RelationshipToThePatientStopDate = segments.Length > 56 ? segments.ElementAtOrDefault(56).Split(separator).Select(x => x.ToDateTime()) : null;
            InsuranceCoContactReason = segments.ElementAtOrDefault(57);
            InsuranceCoContactPhoneNumber = segments.Length > 58 ? segments.ElementAtOrDefault(58).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            PolicyScope = segments.ElementAtOrDefault(59);
            PolicySource = segments.ElementAtOrDefault(60);
            PatientMemberNumber = segments.Length > 61 ? TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments.ElementAtOrDefault(61), false) : null;
            GuarantorsRelationshipToInsured = segments.Length > 62 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(62), false) : null;
            InsuredsPhoneNumberHome = segments.Length > 63 ? segments.ElementAtOrDefault(63).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            InsuredsEmployerPhoneNumber = segments.Length > 64 ? segments.ElementAtOrDefault(64).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            MilitaryHandicappedProgram = segments.Length > 65 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(65), false) : null;
            SuspendFlag = segments.ElementAtOrDefault(66);
            CopayLimitFlag = segments.ElementAtOrDefault(67);
            StoplossLimitFlag = segments.ElementAtOrDefault(68);
            InsuredOrganizationNameAndId = segments.Length > 69 ? segments.ElementAtOrDefault(69).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false)) : null;
            InsuredEmployerOrganizationNameAndId = segments.Length > 70 ? segments.ElementAtOrDefault(70).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false)) : null;
            Race = segments.Length > 71 ? segments.ElementAtOrDefault(71).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            PatientsRelationshipToInsured = segments.Length > 72 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(72), false) : null;
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
                                StringHelper.StringFormatSequence(0, 73, Configuration.FieldSeparator),
                                Id,
                                InsuredsEmployeeId != null ? string.Join(Configuration.FieldRepeatSeparator, InsuredsEmployeeId.Select(x => x.ToDelimitedString())) : null,
                                InsuredsSocialSecurityNumber,
                                InsuredsEmployersNameAndId != null ? string.Join(Configuration.FieldRepeatSeparator, InsuredsEmployersNameAndId.Select(x => x.ToDelimitedString())) : null,
                                EmployerInformationData,
                                MailClaimParty != null ? string.Join(Configuration.FieldRepeatSeparator, MailClaimParty) : null,
                                MedicareHealthInsCardNumber,
                                MedicaidCaseName != null ? string.Join(Configuration.FieldRepeatSeparator, MedicaidCaseName.Select(x => x.ToDelimitedString())) : null,
                                MedicaidCaseNumber,
                                MilitarySponsorName != null ? string.Join(Configuration.FieldRepeatSeparator, MilitarySponsorName.Select(x => x.ToDelimitedString())) : null,
                                MilitaryIdNumber,
                                DependentOfMilitaryRecipient?.ToDelimitedString(),
                                MilitaryOrganization,
                                MilitaryStation,
                                MilitaryService,
                                MilitaryRankGrade,
                                MilitaryStatus,
                                MilitaryRetireDate.HasValue ? MilitaryRetireDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                MilitaryNonAvailCertOnFile,
                                BabyCoverage,
                                CombineBabyBill,
                                BloodDeductible,
                                SpecialCoverageApprovalName != null ? string.Join(Configuration.FieldRepeatSeparator, SpecialCoverageApprovalName.Select(x => x.ToDelimitedString())) : null,
                                SpecialCoverageApprovalTitle,
                                NonCoveredInsuranceCode != null ? string.Join(Configuration.FieldRepeatSeparator, NonCoveredInsuranceCode) : null,
                                PayorId != null ? string.Join(Configuration.FieldRepeatSeparator, PayorId.Select(x => x.ToDelimitedString())) : null,
                                PayorSubscriberId != null ? string.Join(Configuration.FieldRepeatSeparator, PayorSubscriberId.Select(x => x.ToDelimitedString())) : null,
                                EligibilitySource,
                                RoomCoverageTypeAmount != null ? string.Join(Configuration.FieldRepeatSeparator, RoomCoverageTypeAmount.Select(x => x.ToDelimitedString())) : null,
                                PolicyTypeAmount != null ? string.Join(Configuration.FieldRepeatSeparator, PolicyTypeAmount.Select(x => x.ToDelimitedString())) : null,
                                DailyDeductible?.ToDelimitedString(),
                                LivingDependency,
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
                                MaritalStatus != null ? string.Join(Configuration.FieldRepeatSeparator, MaritalStatus.Select(x => x.ToDelimitedString())) : null,
                                InsuredsEmploymentStartDate.HasValue ? InsuredsEmploymentStartDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                EmploymentStopDate.HasValue ? EmploymentStopDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                JobTitle,
                                JobCodeClass?.ToDelimitedString(),
                                JobStatus,
                                EmployerContactPersonName != null ? string.Join(Configuration.FieldRepeatSeparator, EmployerContactPersonName.Select(x => x.ToDelimitedString())) : null,
                                EmployerContactPersonPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, EmployerContactPersonPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                EmployerContactReason,
                                InsuredsContactPersonsName != null ? string.Join(Configuration.FieldRepeatSeparator, InsuredsContactPersonsName.Select(x => x.ToDelimitedString())) : null,
                                InsuredsContactPersonPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, InsuredsContactPersonPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                InsuredsContactPersonReason != null ? string.Join(Configuration.FieldRepeatSeparator, InsuredsContactPersonReason) : null,
                                RelationshipToThePatientStartDate.HasValue ? RelationshipToThePatientStartDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                RelationshipToThePatientStopDate != null ? string.Join(Configuration.FieldRepeatSeparator, RelationshipToThePatientStopDate.Select(x => x.ToString(Consts.DateFormatPrecisionDay, culture))) : null,
                                InsuranceCoContactReason,
                                InsuranceCoContactPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, InsuranceCoContactPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                PolicyScope,
                                PolicySource,
                                PatientMemberNumber?.ToDelimitedString(),
                                GuarantorsRelationshipToInsured?.ToDelimitedString(),
                                InsuredsPhoneNumberHome != null ? string.Join(Configuration.FieldRepeatSeparator, InsuredsPhoneNumberHome.Select(x => x.ToDelimitedString())) : null,
                                InsuredsEmployerPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, InsuredsEmployerPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                MilitaryHandicappedProgram?.ToDelimitedString(),
                                SuspendFlag,
                                CopayLimitFlag,
                                StoplossLimitFlag,
                                InsuredOrganizationNameAndId != null ? string.Join(Configuration.FieldRepeatSeparator, InsuredOrganizationNameAndId.Select(x => x.ToDelimitedString())) : null,
                                InsuredEmployerOrganizationNameAndId != null ? string.Join(Configuration.FieldRepeatSeparator, InsuredEmployerOrganizationNameAndId.Select(x => x.ToDelimitedString())) : null,
                                Race != null ? string.Join(Configuration.FieldRepeatSeparator, Race.Select(x => x.ToDelimitedString())) : null,
                                PatientsRelationshipToInsured?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}