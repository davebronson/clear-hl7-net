using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V270.Types;

namespace ClearHl7.V270.Segments
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
        public CodedWithExceptions EmployerInformationData { get; set; }

        /// <summary>
        /// IN2.5 - Mail Claim Party.
        /// <para>Suggested: 0137 Mail Claim Party -&gt; ClearHl7.Codes.V270.CodeMailClaimParty</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> MailClaimParty { get; set; }

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
        public CodedWithExceptions DependentOfMilitaryRecipient { get; set; }

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
        /// <para>Suggested: 0140 Military Service -&gt; ClearHl7.Codes.V270.CodeMilitaryService</para>
        /// </summary>
        public CodedWithExceptions MilitaryService { get; set; }

        /// <summary>
        /// IN2.15 - Military Rank/Grade.
        /// <para>Suggested: 0141 Military Rank/Grade -&gt; ClearHl7.Codes.V270.CodeMilitaryRankGrade</para>
        /// </summary>
        public CodedWithExceptions MilitaryRankGrade { get; set; }

        /// <summary>
        /// IN2.16 - Military Status.
        /// <para>Suggested: 0142 Military Status -&gt; ClearHl7.Codes.V270.CodeMilitaryStatus</para>
        /// </summary>
        public CodedWithExceptions MilitaryStatus { get; set; }

        /// <summary>
        /// IN2.17 - Military Retire Date.
        /// </summary>
        public DateTime? MilitaryRetireDate { get; set; }

        /// <summary>
        /// IN2.18 - Military Non-Avail Cert On File.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeYesNoIndicator</para>
        /// </summary>
        public string MilitaryNonAvailCertOnFile { get; set; }

        /// <summary>
        /// IN2.19 - Baby Coverage.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeYesNoIndicator</para>
        /// </summary>
        public string BabyCoverage { get; set; }

        /// <summary>
        /// IN2.20 - Combine Baby Bill.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeYesNoIndicator</para>
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
        public IEnumerable<CodedWithExceptions> NonCoveredInsuranceCode { get; set; }

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
        /// <para>Suggested: 0144 Eligibility Source -&gt; ClearHl7.Codes.V270.CodeEligibilitySource</para>
        /// </summary>
        public CodedWithExceptions EligibilitySource { get; set; }

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
        /// <para>Suggested: 0223 Living Dependency -&gt; ClearHl7.Codes.V270.CodeLivingDependency</para>
        /// </summary>
        public CodedWithExceptions LivingDependency { get; set; }

        /// <summary>
        /// IN2.32 - Ambulatory Status.
        /// <para>Suggested: 0009 Ambulatory Status -&gt; ClearHl7.Codes.V270.CodeAmbulatoryStatus</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> AmbulatoryStatus { get; set; }

        /// <summary>
        /// IN2.33 - Citizenship.
        /// <para>Suggested: 0171 Citizenship</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> Citizenship { get; set; }

        /// <summary>
        /// IN2.34 - Primary Language.
        /// <para>Suggested: 0296 Primary Language</para>
        /// </summary>
        public CodedWithExceptions PrimaryLanguage { get; set; }

        /// <summary>
        /// IN2.35 - Living Arrangement.
        /// <para>Suggested: 0220 Living Arrangement -&gt; ClearHl7.Codes.V270.CodeLivingArrangement</para>
        /// </summary>
        public CodedWithExceptions LivingArrangement { get; set; }

        /// <summary>
        /// IN2.36 - Publicity Code.
        /// <para>Suggested: 0215 Publicity Code -&gt; ClearHl7.Codes.V270.CodePublicityCode</para>
        /// </summary>
        public CodedWithExceptions PublicityCode { get; set; }

        /// <summary>
        /// IN2.37 - Protection Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeYesNoIndicator</para>
        /// </summary>
        public string ProtectionIndicator { get; set; }

        /// <summary>
        /// IN2.38 - Student Indicator.
        /// <para>Suggested: 0231 Student Status -&gt; ClearHl7.Codes.V270.CodeStudentStatus</para>
        /// </summary>
        public CodedWithExceptions StudentIndicator { get; set; }

        /// <summary>
        /// IN2.39 - Religion.
        /// <para>Suggested: 0006 Religion -&gt; ClearHl7.Codes.V270.CodeReligion</para>
        /// </summary>
        public CodedWithExceptions Religion { get; set; }

        /// <summary>
        /// IN2.40 - Mother's Maiden Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> MothersMaidenName { get; set; }

        /// <summary>
        /// IN2.41 - Nationality.
        /// <para>Suggested: 0212 Nationality</para>
        /// </summary>
        public CodedWithExceptions Nationality { get; set; }

        /// <summary>
        /// IN2.42 - Ethnic Group.
        /// <para>Suggested: 0189 Ethnic Group -&gt; ClearHl7.Codes.V270.CodeEthnicGroup</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> EthnicGroup { get; set; }

        /// <summary>
        /// IN2.43 - Marital Status.
        /// <para>Suggested: 0002 Marital Status -&gt; ClearHl7.Codes.V270.CodeMaritalStatus</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> MaritalStatus { get; set; }

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
        /// <para>Suggested: 0327 Job Code/Class</para>
        /// </summary>
        public JobCodeClass JobCodeClass { get; set; }

        /// <summary>
        /// IN2.48 - Job Status.
        /// <para>Suggested: 0311 Job Status -&gt; ClearHl7.Codes.V270.CodeJobStatus</para>
        /// </summary>
        public CodedWithExceptions JobStatus { get; set; }

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
        public CodedWithExceptions EmployerContactReason { get; set; }

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
        public IEnumerable<CodedWithExceptions> InsuredsContactPersonReason { get; set; }

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
        /// <para>Suggested: 0232 Insurance Company Contact Reason -&gt; ClearHl7.Codes.V270.CodeInsuranceCompanyContactReason</para>
        /// </summary>
        public CodedWithExceptions InsuranceCoContactReason { get; set; }

        /// <summary>
        /// IN2.58 - Insurance Co Contact Phone Number.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> InsuranceCoContactPhoneNumber { get; set; }

        /// <summary>
        /// IN2.59 - Policy Scope.
        /// <para>Suggested: 0312 Policy Scope</para>
        /// </summary>
        public CodedWithExceptions PolicyScope { get; set; }

        /// <summary>
        /// IN2.60 - Policy Source.
        /// <para>Suggested: 0313 Policy Source</para>
        /// </summary>
        public CodedWithExceptions PolicySource { get; set; }

        /// <summary>
        /// IN2.61 - Patient Member Number.
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit PatientMemberNumber { get; set; }

        /// <summary>
        /// IN2.62 - Guarantor's Relationship to Insured.
        /// <para>Suggested: 0063 Relationship -&gt; ClearHl7.Codes.V270.CodeRelationship</para>
        /// </summary>
        public CodedWithExceptions GuarantorsRelationshipToInsured { get; set; }

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
        public CodedWithExceptions MilitaryHandicappedProgram { get; set; }

        /// <summary>
        /// IN2.66 - Suspend Flag.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeYesNoIndicator</para>
        /// </summary>
        public string SuspendFlag { get; set; }

        /// <summary>
        /// IN2.67 - Copay Limit Flag.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeYesNoIndicator</para>
        /// </summary>
        public string CopayLimitFlag { get; set; }

        /// <summary>
        /// IN2.68 - Stoploss Limit Flag.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeYesNoIndicator</para>
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
        /// <para>Suggested: 0005 Race -&gt; ClearHl7.Codes.V270.CodeRace</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> Race { get; set; }

        /// <summary>
        /// IN2.72 - Patient's Relationship to Insured.
        /// <para>Suggested: 0344 Patient's Relationship to Insured -&gt; ClearHl7.Codes.V270.CodePatientsRelationshiptoInsured</para>
        /// </summary>
        public CodedWithExceptions PatientsRelationshipToInsured { get; set; }

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
        internal void FromDelimitedString(string delimitedString, Separators separators)
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

            InsuredsEmployeeId = segments.Length > 1 && segments[1].Length > 0 ? segments[1].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false)) : null;
            InsuredsSocialSecurityNumber = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            InsuredsEmployersNameAndId = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            EmployerInformationData = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[4], false) : null;
            MailClaimParty = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            MedicareHealthInsCardNumber = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            MedicaidCaseName = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedPersonName>(x, false)) : null;
            MedicaidCaseNumber = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            MilitarySponsorName = segments.Length > 9 && segments[9].Length > 0 ? segments[9].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedPersonName>(x, false)) : null;
            MilitaryIdNumber = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
            DependentOfMilitaryRecipient = segments.Length > 11 && segments[11].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[11], false) : null;
            MilitaryOrganization = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
            MilitaryStation = segments.Length > 13 && segments[13].Length > 0 ? segments[13] : null;
            MilitaryService = segments.Length > 14 && segments[14].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[14], false) : null;
            MilitaryRankGrade = segments.Length > 15 && segments[15].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[15], false) : null;
            MilitaryStatus = segments.Length > 16 && segments[16].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[16], false) : null;
            MilitaryRetireDate = segments.Length > 17 && segments[17].Length > 0 ? segments[17].ToNullableDateTime() : null;
            MilitaryNonAvailCertOnFile = segments.Length > 18 && segments[18].Length > 0 ? segments[18] : null;
            BabyCoverage = segments.Length > 19 && segments[19].Length > 0 ? segments[19] : null;
            CombineBabyBill = segments.Length > 20 && segments[20].Length > 0 ? segments[20] : null;
            BloodDeductible = segments.Length > 21 && segments[21].Length > 0 ? segments[21] : null;
            SpecialCoverageApprovalName = segments.Length > 22 && segments[22].Length > 0 ? segments[22].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedPersonName>(x, false)) : null;
            SpecialCoverageApprovalTitle = segments.Length > 23 && segments[23].Length > 0 ? segments[23] : null;
            NonCoveredInsuranceCode = segments.Length > 24 && segments[24].Length > 0 ? segments[24].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            PayorId = segments.Length > 25 && segments[25].Length > 0 ? segments[25].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false)) : null;
            PayorSubscriberId = segments.Length > 26 && segments[26].Length > 0 ? segments[26].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false)) : null;
            EligibilitySource = segments.Length > 27 && segments[27].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[27], false) : null;
            RoomCoverageTypeAmount = segments.Length > 28 && segments[28].Length > 0 ? segments[28].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<RoomCoverage>(x, false)) : null;
            PolicyTypeAmount = segments.Length > 29 && segments[29].Length > 0 ? segments[29].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<PolicyTypeAndAmount>(x, false)) : null;
            DailyDeductible = segments.Length > 30 && segments[30].Length > 0 ? TypeHelper.Deserialize<DailyDeductibleInformation>(segments[30], false) : null;
            LivingDependency = segments.Length > 31 && segments[31].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[31], false) : null;
            AmbulatoryStatus = segments.Length > 32 && segments[32].Length > 0 ? segments[32].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            Citizenship = segments.Length > 33 && segments[33].Length > 0 ? segments[33].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            PrimaryLanguage = segments.Length > 34 && segments[34].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[34], false) : null;
            LivingArrangement = segments.Length > 35 && segments[35].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[35], false) : null;
            PublicityCode = segments.Length > 36 && segments[36].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[36], false) : null;
            ProtectionIndicator = segments.Length > 37 && segments[37].Length > 0 ? segments[37] : null;
            StudentIndicator = segments.Length > 38 && segments[38].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[38], false) : null;
            Religion = segments.Length > 39 && segments[39].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[39], false) : null;
            MothersMaidenName = segments.Length > 40 && segments[40].Length > 0 ? segments[40].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedPersonName>(x, false)) : null;
            Nationality = segments.Length > 41 && segments[41].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[41], false) : null;
            EthnicGroup = segments.Length > 42 && segments[42].Length > 0 ? segments[42].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            MaritalStatus = segments.Length > 43 && segments[43].Length > 0 ? segments[43].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            InsuredsEmploymentStartDate = segments.Length > 44 && segments[44].Length > 0 ? segments[44].ToNullableDateTime() : null;
            EmploymentStopDate = segments.Length > 45 && segments[45].Length > 0 ? segments[45].ToNullableDateTime() : null;
            JobTitle = segments.Length > 46 && segments[46].Length > 0 ? segments[46] : null;
            JobCodeClass = segments.Length > 47 && segments[47].Length > 0 ? TypeHelper.Deserialize<JobCodeClass>(segments[47], false) : null;
            JobStatus = segments.Length > 48 && segments[48].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[48], false) : null;
            EmployerContactPersonName = segments.Length > 49 && segments[49].Length > 0 ? segments[49].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedPersonName>(x, false)) : null;
            EmployerContactPersonPhoneNumber = segments.Length > 50 && segments[50].Length > 0 ? segments[50].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            EmployerContactReason = segments.Length > 51 && segments[51].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[51], false) : null;
            InsuredsContactPersonsName = segments.Length > 52 && segments[52].Length > 0 ? segments[52].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedPersonName>(x, false)) : null;
            InsuredsContactPersonPhoneNumber = segments.Length > 53 && segments[53].Length > 0 ? segments[53].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            InsuredsContactPersonReason = segments.Length > 54 && segments[54].Length > 0 ? segments[54].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            RelationshipToThePatientStartDate = segments.Length > 55 && segments[55].Length > 0 ? segments[55].ToNullableDateTime() : null;
            RelationshipToThePatientStopDate = segments.Length > 56 && segments[56].Length > 0 ? segments[56].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => x.ToDateTime()) : null;
            InsuranceCoContactReason = segments.Length > 57 && segments[57].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[57], false) : null;
            InsuranceCoContactPhoneNumber = segments.Length > 58 && segments[58].Length > 0 ? segments[58].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            PolicyScope = segments.Length > 59 && segments[59].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[59], false) : null;
            PolicySource = segments.Length > 60 && segments[60].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[60], false) : null;
            PatientMemberNumber = segments.Length > 61 && segments[61].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments[61], false) : null;
            GuarantorsRelationshipToInsured = segments.Length > 62 && segments[62].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[62], false) : null;
            InsuredsPhoneNumberHome = segments.Length > 63 && segments[63].Length > 0 ? segments[63].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            InsuredsEmployerPhoneNumber = segments.Length > 64 && segments[64].Length > 0 ? segments[64].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            MilitaryHandicappedProgram = segments.Length > 65 && segments[65].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[65], false) : null;
            SuspendFlag = segments.Length > 66 && segments[66].Length > 0 ? segments[66] : null;
            CopayLimitFlag = segments.Length > 67 && segments[67].Length > 0 ? segments[67] : null;
            StoplossLimitFlag = segments.Length > 68 && segments[68].Length > 0 ? segments[68] : null;
            InsuredOrganizationNameAndId = segments.Length > 69 && segments[69].Length > 0 ? segments[69].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false)) : null;
            InsuredEmployerOrganizationNameAndId = segments.Length > 70 && segments[70].Length > 0 ? segments[70].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false)) : null;
            Race = segments.Length > 71 && segments[71].Length > 0 ? segments[71].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            PatientsRelationshipToInsured = segments.Length > 72 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[72], false) : null;
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
                                EmployerInformationData?.ToDelimitedString(),
                                MailClaimParty != null ? string.Join(Configuration.FieldRepeatSeparator, MailClaimParty.Select(x => x.ToDelimitedString())) : null,
                                MedicareHealthInsCardNumber,
                                MedicaidCaseName != null ? string.Join(Configuration.FieldRepeatSeparator, MedicaidCaseName.Select(x => x.ToDelimitedString())) : null,
                                MedicaidCaseNumber,
                                MilitarySponsorName != null ? string.Join(Configuration.FieldRepeatSeparator, MilitarySponsorName.Select(x => x.ToDelimitedString())) : null,
                                MilitaryIdNumber,
                                DependentOfMilitaryRecipient?.ToDelimitedString(),
                                MilitaryOrganization,
                                MilitaryStation,
                                MilitaryService?.ToDelimitedString(),
                                MilitaryRankGrade?.ToDelimitedString(),
                                MilitaryStatus?.ToDelimitedString(),
                                MilitaryRetireDate.HasValue ? MilitaryRetireDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                MilitaryNonAvailCertOnFile,
                                BabyCoverage,
                                CombineBabyBill,
                                BloodDeductible,
                                SpecialCoverageApprovalName != null ? string.Join(Configuration.FieldRepeatSeparator, SpecialCoverageApprovalName.Select(x => x.ToDelimitedString())) : null,
                                SpecialCoverageApprovalTitle,
                                NonCoveredInsuranceCode != null ? string.Join(Configuration.FieldRepeatSeparator, NonCoveredInsuranceCode.Select(x => x.ToDelimitedString())) : null,
                                PayorId != null ? string.Join(Configuration.FieldRepeatSeparator, PayorId.Select(x => x.ToDelimitedString())) : null,
                                PayorSubscriberId != null ? string.Join(Configuration.FieldRepeatSeparator, PayorSubscriberId.Select(x => x.ToDelimitedString())) : null,
                                EligibilitySource?.ToDelimitedString(),
                                RoomCoverageTypeAmount != null ? string.Join(Configuration.FieldRepeatSeparator, RoomCoverageTypeAmount.Select(x => x.ToDelimitedString())) : null,
                                PolicyTypeAmount != null ? string.Join(Configuration.FieldRepeatSeparator, PolicyTypeAmount.Select(x => x.ToDelimitedString())) : null,
                                DailyDeductible?.ToDelimitedString(),
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
                                MaritalStatus != null ? string.Join(Configuration.FieldRepeatSeparator, MaritalStatus.Select(x => x.ToDelimitedString())) : null,
                                InsuredsEmploymentStartDate.HasValue ? InsuredsEmploymentStartDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                EmploymentStopDate.HasValue ? EmploymentStopDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                JobTitle,
                                JobCodeClass?.ToDelimitedString(),
                                JobStatus?.ToDelimitedString(),
                                EmployerContactPersonName != null ? string.Join(Configuration.FieldRepeatSeparator, EmployerContactPersonName.Select(x => x.ToDelimitedString())) : null,
                                EmployerContactPersonPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, EmployerContactPersonPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                EmployerContactReason?.ToDelimitedString(),
                                InsuredsContactPersonsName != null ? string.Join(Configuration.FieldRepeatSeparator, InsuredsContactPersonsName.Select(x => x.ToDelimitedString())) : null,
                                InsuredsContactPersonPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, InsuredsContactPersonPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                InsuredsContactPersonReason != null ? string.Join(Configuration.FieldRepeatSeparator, InsuredsContactPersonReason.Select(x => x.ToDelimitedString())) : null,
                                RelationshipToThePatientStartDate.HasValue ? RelationshipToThePatientStartDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                RelationshipToThePatientStopDate != null ? string.Join(Configuration.FieldRepeatSeparator, RelationshipToThePatientStopDate.Select(x => x.ToString(Consts.DateFormatPrecisionDay, culture))) : null,
                                InsuranceCoContactReason?.ToDelimitedString(),
                                InsuranceCoContactPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, InsuranceCoContactPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                PolicyScope?.ToDelimitedString(),
                                PolicySource?.ToDelimitedString(),
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