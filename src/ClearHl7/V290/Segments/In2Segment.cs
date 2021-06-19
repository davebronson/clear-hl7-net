﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
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
        /// <para>Suggested: 0137 Mail Claim Party -&gt; ClearHl7.Codes.V290.CodeMailClaimParty</para>
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
        /// <para>Suggested: 0140 Military Service -&gt; ClearHl7.Codes.V290.CodeMilitaryService</para>
        /// </summary>
        public CodedWithExceptions MilitaryService { get; set; }

        /// <summary>
        /// IN2.15 - Military Rank/Grade.
        /// <para>Suggested: 0141 Military Rank/Grade</para>
        /// </summary>
        public CodedWithExceptions MilitaryRankGrade { get; set; }

        /// <summary>
        /// IN2.16 - Military Status.
        /// <para>Suggested: 0142 Military Status -&gt; ClearHl7.Codes.V290.CodeMilitaryStatus</para>
        /// </summary>
        public CodedWithExceptions MilitaryStatus { get; set; }

        /// <summary>
        /// IN2.17 - Military Retire Date.
        /// </summary>
        public DateTime? MilitaryRetireDate { get; set; }

        /// <summary>
        /// IN2.18 - Military Non-Avail Cert On File.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public string MilitaryNonAvailCertOnFile { get; set; }

        /// <summary>
        /// IN2.19 - Baby Coverage.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public string BabyCoverage { get; set; }

        /// <summary>
        /// IN2.20 - Combine Baby Bill.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
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
        /// <para>Suggested: 0144 Eligibility Source -&gt; ClearHl7.Codes.V290.CodeEligibilitySource</para>
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
        /// <para>Suggested: 0223 Living Dependency -&gt; ClearHl7.Codes.V290.CodeLivingDependency</para>
        /// </summary>
        public CodedWithExceptions LivingDependency { get; set; }

        /// <summary>
        /// IN2.32 - Ambulatory Status.
        /// <para>Suggested: 0009 Ambulatory Status -&gt; ClearHl7.Codes.V290.CodeAmbulatoryStatus</para>
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
        /// <para>Suggested: 0220 Living Arrangement -&gt; ClearHl7.Codes.V290.CodeLivingArrangement</para>
        /// </summary>
        public CodedWithExceptions LivingArrangement { get; set; }

        /// <summary>
        /// IN2.36 - Publicity Code.
        /// <para>Suggested: 0215 Publicity Code -&gt; ClearHl7.Codes.V290.CodePublicityCode</para>
        /// </summary>
        public CodedWithExceptions PublicityCode { get; set; }

        /// <summary>
        /// IN2.37 - Protection Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public string ProtectionIndicator { get; set; }

        /// <summary>
        /// IN2.38 - Student Indicator.
        /// <para>Suggested: 0231 Student Status -&gt; ClearHl7.Codes.V290.CodeStudentStatus</para>
        /// </summary>
        public CodedWithExceptions StudentIndicator { get; set; }

        /// <summary>
        /// IN2.39 - Religion.
        /// <para>Suggested: 0006 Religion -&gt; ClearHl7.Codes.V290.CodeReligion</para>
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
        /// <para>Suggested: 0189 Ethnic Group -&gt; ClearHl7.Codes.V290.CodeEthnicGroup</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> EthnicGroup { get; set; }

        /// <summary>
        /// IN2.43 - Marital Status.
        /// <para>Suggested: 0002 Marital Status -&gt; ClearHl7.Codes.V290.CodeMaritalStatus</para>
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
        /// </summary>
        public JobCodeClass JobCodeClass { get; set; }

        /// <summary>
        /// IN2.48 - Job Status.
        /// <para>Suggested: 0311 Job Status -&gt; ClearHl7.Codes.V290.CodeJobStatus</para>
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
        /// <para>Suggested: 0232 Insurance Company Contact Reason -&gt; ClearHl7.Codes.V290.CodeInsuranceCompanyContactReason</para>
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
        /// <para>Suggested: 0063 Relationship -&gt; ClearHl7.Codes.V290.CodeRelationship</para>
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public string SuspendFlag { get; set; }

        /// <summary>
        /// IN2.67 - Copay Limit Flag.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public string CopayLimitFlag { get; set; }

        /// <summary>
        /// IN2.68 - Stoploss Limit Flag.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
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
        /// <para>Suggested: 0005 Race -&gt; ClearHl7.Codes.V290.CodeRace</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> Race { get; set; }

        /// <summary>
        /// IN2.72 - Patient's Relationship to Insured.
        /// <para>Suggested: 0344 Patient’s Relationship to Insured -&gt; ClearHl7.Codes.V290.CodePatientsRelationshiptoInsured</para>
        /// </summary>
        public CodedWithExceptions PatientsRelationshipToInsured { get; set; }

        /// <summary>
        /// IN2.73 - Co-Pay Amount.
        /// </summary>
        public CompositePrice CoPayAmount { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public In2Segment FromDelimitedString(string delimitedString)
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

            InsuredsEmployeeId = segments.Length > 1 ? segments.ElementAtOrDefault(1).Split(separator).Select(x => new ExtendedCompositeIdWithCheckDigit().FromDelimitedString(x)) : null;
            InsuredsSocialSecurityNumber = segments.ElementAtOrDefault(2);
            InsuredsEmployersNameAndId = segments.Length > 3 ? segments.ElementAtOrDefault(3).Split(separator).Select(x => new ExtendedCompositeIdNumberAndNameForPersons().FromDelimitedString(x)) : null;
            EmployerInformationData = segments.Length > 4 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(4)) : null;
            MailClaimParty = segments.Length > 5 ? segments.ElementAtOrDefault(5).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            MedicareHealthInsCardNumber = segments.ElementAtOrDefault(6);
            MedicaidCaseName = segments.Length > 7 ? segments.ElementAtOrDefault(7).Split(separator).Select(x => new ExtendedPersonName().FromDelimitedString(x)) : null;
            MedicaidCaseNumber = segments.ElementAtOrDefault(8);
            MilitarySponsorName = segments.Length > 9 ? segments.ElementAtOrDefault(9).Split(separator).Select(x => new ExtendedPersonName().FromDelimitedString(x)) : null;
            MilitaryIdNumber = segments.ElementAtOrDefault(10);
            DependentOfMilitaryRecipient = segments.Length > 11 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(11)) : null;
            MilitaryOrganization = segments.ElementAtOrDefault(12);
            MilitaryStation = segments.ElementAtOrDefault(13);
            MilitaryService = segments.Length > 14 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(14)) : null;
            MilitaryRankGrade = segments.Length > 15 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(15)) : null;
            MilitaryStatus = segments.Length > 16 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(16)) : null;
            MilitaryRetireDate = segments.ElementAtOrDefault(17)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            MilitaryNonAvailCertOnFile = segments.ElementAtOrDefault(18);
            BabyCoverage = segments.ElementAtOrDefault(19);
            CombineBabyBill = segments.ElementAtOrDefault(20);
            BloodDeductible = segments.ElementAtOrDefault(21);
            SpecialCoverageApprovalName = segments.Length > 22 ? segments.ElementAtOrDefault(22).Split(separator).Select(x => new ExtendedPersonName().FromDelimitedString(x)) : null;
            SpecialCoverageApprovalTitle = segments.ElementAtOrDefault(23);
            NonCoveredInsuranceCode = segments.Length > 24 ? segments.ElementAtOrDefault(24).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            PayorId = segments.Length > 25 ? segments.ElementAtOrDefault(25).Split(separator).Select(x => new ExtendedCompositeIdWithCheckDigit().FromDelimitedString(x)) : null;
            PayorSubscriberId = segments.Length > 26 ? segments.ElementAtOrDefault(26).Split(separator).Select(x => new ExtendedCompositeIdWithCheckDigit().FromDelimitedString(x)) : null;
            EligibilitySource = segments.Length > 27 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(27)) : null;
            RoomCoverageTypeAmount = segments.Length > 28 ? segments.ElementAtOrDefault(28).Split(separator).Select(x => new RoomCoverage().FromDelimitedString(x)) : null;
            PolicyTypeAmount = segments.Length > 29 ? segments.ElementAtOrDefault(29).Split(separator).Select(x => new PolicyTypeAndAmount().FromDelimitedString(x)) : null;
            DailyDeductible = segments.Length > 30 ? new DailyDeductibleInformation().FromDelimitedString(segments.ElementAtOrDefault(30)) : null;
            LivingDependency = segments.Length > 31 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(31)) : null;
            AmbulatoryStatus = segments.Length > 32 ? segments.ElementAtOrDefault(32).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            Citizenship = segments.Length > 33 ? segments.ElementAtOrDefault(33).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            PrimaryLanguage = segments.Length > 34 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(34)) : null;
            LivingArrangement = segments.Length > 35 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(35)) : null;
            PublicityCode = segments.Length > 36 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(36)) : null;
            ProtectionIndicator = segments.ElementAtOrDefault(37);
            StudentIndicator = segments.Length > 38 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(38)) : null;
            Religion = segments.Length > 39 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(39)) : null;
            MothersMaidenName = segments.Length > 40 ? segments.ElementAtOrDefault(40).Split(separator).Select(x => new ExtendedPersonName().FromDelimitedString(x)) : null;
            Nationality = segments.Length > 41 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(41)) : null;
            EthnicGroup = segments.Length > 42 ? segments.ElementAtOrDefault(42).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            MaritalStatus = segments.Length > 43 ? segments.ElementAtOrDefault(43).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            InsuredsEmploymentStartDate = segments.ElementAtOrDefault(44)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            EmploymentStopDate = segments.ElementAtOrDefault(45)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            JobTitle = segments.ElementAtOrDefault(46);
            JobCodeClass = segments.Length > 47 ? new JobCodeClass().FromDelimitedString(segments.ElementAtOrDefault(47)) : null;
            JobStatus = segments.Length > 48 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(48)) : null;
            EmployerContactPersonName = segments.Length > 49 ? segments.ElementAtOrDefault(49).Split(separator).Select(x => new ExtendedPersonName().FromDelimitedString(x)) : null;
            EmployerContactPersonPhoneNumber = segments.Length > 50 ? segments.ElementAtOrDefault(50).Split(separator).Select(x => new ExtendedTelecommunicationNumber().FromDelimitedString(x)) : null;
            EmployerContactReason = segments.Length > 51 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(51)) : null;
            InsuredsContactPersonsName = segments.Length > 52 ? segments.ElementAtOrDefault(52).Split(separator).Select(x => new ExtendedPersonName().FromDelimitedString(x)) : null;
            InsuredsContactPersonPhoneNumber = segments.Length > 53 ? segments.ElementAtOrDefault(53).Split(separator).Select(x => new ExtendedTelecommunicationNumber().FromDelimitedString(x)) : null;
            InsuredsContactPersonReason = segments.Length > 54 ? segments.ElementAtOrDefault(54).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            RelationshipToThePatientStartDate = segments.ElementAtOrDefault(55)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            RelationshipToThePatientStopDate = segments.Length > 56 ? segments.ElementAtOrDefault(56).Split(separator).Select(x => x.ToDateTime(Consts.DateFormatPrecisionDay)) : null;
            InsuranceCoContactReason = segments.Length > 57 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(57)) : null;
            InsuranceCoContactPhoneNumber = segments.Length > 58 ? segments.ElementAtOrDefault(58).Split(separator).Select(x => new ExtendedTelecommunicationNumber().FromDelimitedString(x)) : null;
            PolicyScope = segments.Length > 59 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(59)) : null;
            PolicySource = segments.Length > 60 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(60)) : null;
            PatientMemberNumber = segments.Length > 61 ? new ExtendedCompositeIdWithCheckDigit().FromDelimitedString(segments.ElementAtOrDefault(61)) : null;
            GuarantorsRelationshipToInsured = segments.Length > 62 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(62)) : null;
            InsuredsPhoneNumberHome = segments.Length > 63 ? segments.ElementAtOrDefault(63).Split(separator).Select(x => new ExtendedTelecommunicationNumber().FromDelimitedString(x)) : null;
            InsuredsEmployerPhoneNumber = segments.Length > 64 ? segments.ElementAtOrDefault(64).Split(separator).Select(x => new ExtendedTelecommunicationNumber().FromDelimitedString(x)) : null;
            MilitaryHandicappedProgram = segments.Length > 65 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(65)) : null;
            SuspendFlag = segments.ElementAtOrDefault(66);
            CopayLimitFlag = segments.ElementAtOrDefault(67);
            StoplossLimitFlag = segments.ElementAtOrDefault(68);
            InsuredOrganizationNameAndId = segments.Length > 69 ? segments.ElementAtOrDefault(69).Split(separator).Select(x => new ExtendedCompositeNameAndIdNumberForOrganizations().FromDelimitedString(x)) : null;
            InsuredEmployerOrganizationNameAndId = segments.Length > 70 ? segments.ElementAtOrDefault(70).Split(separator).Select(x => new ExtendedCompositeNameAndIdNumberForOrganizations().FromDelimitedString(x)) : null;
            Race = segments.Length > 71 ? segments.ElementAtOrDefault(71).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            PatientsRelationshipToInsured = segments.Length > 72 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(72)) : null;
            CoPayAmount = segments.Length > 73 ? new CompositePrice().FromDelimitedString(segments.ElementAtOrDefault(73)) : null;

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
                                StringHelper.StringFormatSequence(0, 74, Configuration.FieldSeparator),
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
                                PatientsRelationshipToInsured?.ToDelimitedString(),
                                CoPayAmount?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}