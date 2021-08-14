using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment STF - Staff Identification.
    /// </summary>
    public class StfSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "STF";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// STF.1 - Primary Key Value - STF.
        /// </summary>
        public CodedWithExceptions PrimaryKeyValueStf { get; set; }

        /// <summary>
        /// STF.2 - Staff Identifier List.
        /// <para>Suggested: 0061 Check Digit Scheme -&gt; ClearHl7.Codes.V280.CodeCheckDigitScheme</para>
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> StaffIdentifierList { get; set; }

        /// <summary>
        /// STF.3 - Staff Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> StaffName { get; set; }

        /// <summary>
        /// STF.4 - Staff Type.
        /// <para>Suggested: 0182 Staff Type</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> StaffType { get; set; }

        /// <summary>
        /// STF.5 - Administrative Sex.
        /// <para>Suggested: 0001 Administrative Sex -&gt; ClearHl7.Codes.V280.CodeAdministrativeSex</para>
        /// </summary>
        public CodedWithExceptions AdministrativeSex { get; set; }

        /// <summary>
        /// STF.6 - Date/Time of Birth.
        /// </summary>
        public DateTime? DateTimeOfBirth { get; set; }

        /// <summary>
        /// STF.7 - Active/Inactive Flag.
        /// <para>Suggested: 0183 Active/Inactive -&gt; ClearHl7.Codes.V280.CodeActiveInactive</para>
        /// </summary>
        public string ActiveInactiveFlag { get; set; }

        /// <summary>
        /// STF.8 - Department.
        /// <para>Suggested: 0184 Department</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> Department { get; set; }

        /// <summary>
        /// STF.9 - Hospital Service - STF.
        /// <para>Suggested: 0069 Hospital Service -&gt; ClearHl7.Codes.V280.CodeHospitalService</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> HospitalServiceStf { get; set; }

        /// <summary>
        /// STF.10 - Phone.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> Phone { get; set; }

        /// <summary>
        /// STF.11 - Office/Home Address/Birthplace.
        /// </summary>
        public IEnumerable<ExtendedAddress> OfficeHomeAddressBirthplace { get; set; }

        /// <summary>
        /// STF.12 - Institution Activation Date.
        /// <para>Suggested: 0537 Institution</para>
        /// </summary>
        public IEnumerable<DateAndInstitutionName> InstitutionActivationDate { get; set; }

        /// <summary>
        /// STF.13 - Institution Inactivation Date.
        /// <para>Suggested: 0537 Institution</para>
        /// </summary>
        public IEnumerable<DateAndInstitutionName> InstitutionInactivationDate { get; set; }

        /// <summary>
        /// STF.14 - Backup Person ID.
        /// </summary>
        public IEnumerable<CodedWithExceptions> BackupPersonId { get; set; }

        /// <summary>
        /// STF.15 - E-Mail Address.
        /// </summary>
        public IEnumerable<string> EmailAddress { get; set; }

        /// <summary>
        /// STF.16 - Preferred Method of Contact.
        /// <para>Suggested: 0185 Preferred Method Of Contact -&gt; ClearHl7.Codes.V280.CodePreferredMethodOfContact</para>
        /// </summary>
        public CodedWithExceptions PreferredMethodOfContact { get; set; }

        /// <summary>
        /// STF.17 - Marital Status.
        /// <para>Suggested: 0002 Marital Status -&gt; ClearHl7.Codes.V280.CodeMaritalStatus</para>
        /// </summary>
        public CodedWithExceptions MaritalStatus { get; set; }

        /// <summary>
        /// STF.18 - Job Title.
        /// </summary>
        public string JobTitle { get; set; }

        /// <summary>
        /// STF.19 - Job Code/Class.
        /// </summary>
        public JobCodeClass JobCodeClass { get; set; }

        /// <summary>
        /// STF.20 - Employment Status Code.
        /// <para>Suggested: 0066 Employment Status -&gt; ClearHl7.Codes.V280.CodeEmploymentStatus</para>
        /// </summary>
        public CodedWithExceptions EmploymentStatusCode { get; set; }

        /// <summary>
        /// STF.21 - Additional Insured on Auto.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V280.CodeYesNoIndicator</para>
        /// </summary>
        public string AdditionalInsuredOnAuto { get; set; }

        /// <summary>
        /// STF.22 - Driver's License Number - Staff.
        /// </summary>
        public DriversLicenseNumber DriversLicenseNumberStaff { get; set; }

        /// <summary>
        /// STF.23 - Copy Auto Ins.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V280.CodeYesNoIndicator</para>
        /// </summary>
        public string CopyAutoIns { get; set; }

        /// <summary>
        /// STF.24 - Auto Ins Expires.
        /// </summary>
        public DateTime? AutoInsExpires { get; set; }

        /// <summary>
        /// STF.25 - Date Last DMV Review.
        /// </summary>
        public DateTime? DateLastDmvReview { get; set; }

        /// <summary>
        /// STF.26 - Date Next DMV Review.
        /// </summary>
        public DateTime? DateNextDmvReview { get; set; }

        /// <summary>
        /// STF.27 - Race.
        /// <para>Suggested: 0005 Race -&gt; ClearHl7.Codes.V280.CodeRace</para>
        /// </summary>
        public CodedWithExceptions Race { get; set; }

        /// <summary>
        /// STF.28 - Ethnic Group.
        /// <para>Suggested: 0189 Ethnic Group -&gt; ClearHl7.Codes.V280.CodeEthnicGroup</para>
        /// </summary>
        public CodedWithExceptions EthnicGroup { get; set; }

        /// <summary>
        /// STF.29 - Re-activation Approval Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V280.CodeYesNoIndicator</para>
        /// </summary>
        public string ReactivationApprovalIndicator { get; set; }

        /// <summary>
        /// STF.30 - Citizenship.
        /// <para>Suggested: 0171 Citizenship</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> Citizenship { get; set; }

        /// <summary>
        /// STF.31 - Date/Time of Death.
        /// </summary>
        public DateTime? DateTimeOfDeath { get; set; }

        /// <summary>
        /// STF.32 - Death Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V280.CodeYesNoIndicator</para>
        /// </summary>
        public string DeathIndicator { get; set; }

        /// <summary>
        /// STF.33 - Institution Relationship Type Code.
        /// <para>Suggested: 0538 Institution Relationship Type -&gt; ClearHl7.Codes.V280.CodeInstitutionRelationshipType</para>
        /// </summary>
        public CodedWithExceptions InstitutionRelationshipTypeCode { get; set; }

        /// <summary>
        /// STF.34 - Institution Relationship Period.
        /// </summary>
        public DateTimeRange InstitutionRelationshipPeriod { get; set; }

        /// <summary>
        /// STF.35 - Expected Return Date.
        /// </summary>
        public DateTime? ExpectedReturnDate { get; set; }

        /// <summary>
        /// STF.36 - Cost Center Code.
        /// <para>Suggested: 0539 Cost Center Code</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> CostCenterCode { get; set; }

        /// <summary>
        /// STF.37 - Generic Classification Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V280.CodeYesNoIndicator</para>
        /// </summary>
        public string GenericClassificationIndicator { get; set; }

        /// <summary>
        /// STF.38 - Inactive Reason Code.
        /// <para>Suggested: 0540 Inactive Reason Code -&gt; ClearHl7.Codes.V280.CodeInactiveReasonCode</para>
        /// </summary>
        public CodedWithExceptions InactiveReasonCode { get; set; }

        /// <summary>
        /// STF.39 - Generic resource type or category.
        /// <para>Suggested: 0771 Generic Resource Type Or Category</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> GenericResourceTypeOrCategory { get; set; }

        /// <summary>
        /// STF.40 - Religion.
        /// <para>Suggested: 0006 Religion -&gt; ClearHl7.Codes.V280.CodeReligion</para>
        /// </summary>
        public CodedWithExceptions Religion { get; set; }

        /// <summary>
        /// STF.41 - Signature.
        /// </summary>
        public EncapsulatedData Signature { get; set; }

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

            PrimaryKeyValueStf = segments.Length > 1 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(1), false) : null;
            StaffIdentifierList = segments.Length > 2 ? segments.ElementAtOrDefault(2).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false)) : null;
            StaffName = segments.Length > 3 ? segments.ElementAtOrDefault(3).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedPersonName>(x, false)) : null;
            StaffType = segments.Length > 4 ? segments.ElementAtOrDefault(4).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            AdministrativeSex = segments.Length > 5 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(5), false) : null;
            DateTimeOfBirth = segments.ElementAtOrDefault(6)?.ToNullableDateTime();
            ActiveInactiveFlag = segments.ElementAtOrDefault(7);
            Department = segments.Length > 8 ? segments.ElementAtOrDefault(8).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            HospitalServiceStf = segments.Length > 9 ? segments.ElementAtOrDefault(9).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            Phone = segments.Length > 10 ? segments.ElementAtOrDefault(10).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            OfficeHomeAddressBirthplace = segments.Length > 11 ? segments.ElementAtOrDefault(11).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedAddress>(x, false)) : null;
            InstitutionActivationDate = segments.Length > 12 ? segments.ElementAtOrDefault(12).Split(separator).Select(x => TypeHelper.Deserialize<DateAndInstitutionName>(x, false)) : null;
            InstitutionInactivationDate = segments.Length > 13 ? segments.ElementAtOrDefault(13).Split(separator).Select(x => TypeHelper.Deserialize<DateAndInstitutionName>(x, false)) : null;
            BackupPersonId = segments.Length > 14 ? segments.ElementAtOrDefault(14).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            EmailAddress = segments.Length > 15 ? segments.ElementAtOrDefault(15).Split(separator) : null;
            PreferredMethodOfContact = segments.Length > 16 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(16), false) : null;
            MaritalStatus = segments.Length > 17 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(17), false) : null;
            JobTitle = segments.ElementAtOrDefault(18);
            JobCodeClass = segments.Length > 19 ? TypeHelper.Deserialize<JobCodeClass>(segments.ElementAtOrDefault(19), false) : null;
            EmploymentStatusCode = segments.Length > 20 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(20), false) : null;
            AdditionalInsuredOnAuto = segments.ElementAtOrDefault(21);
            DriversLicenseNumberStaff = segments.Length > 22 ? TypeHelper.Deserialize<DriversLicenseNumber>(segments.ElementAtOrDefault(22), false) : null;
            CopyAutoIns = segments.ElementAtOrDefault(23);
            AutoInsExpires = segments.ElementAtOrDefault(24)?.ToNullableDateTime();
            DateLastDmvReview = segments.ElementAtOrDefault(25)?.ToNullableDateTime();
            DateNextDmvReview = segments.ElementAtOrDefault(26)?.ToNullableDateTime();
            Race = segments.Length > 27 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(27), false) : null;
            EthnicGroup = segments.Length > 28 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(28), false) : null;
            ReactivationApprovalIndicator = segments.ElementAtOrDefault(29);
            Citizenship = segments.Length > 30 ? segments.ElementAtOrDefault(30).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            DateTimeOfDeath = segments.ElementAtOrDefault(31)?.ToNullableDateTime();
            DeathIndicator = segments.ElementAtOrDefault(32);
            InstitutionRelationshipTypeCode = segments.Length > 33 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(33), false) : null;
            InstitutionRelationshipPeriod = segments.Length > 34 ? TypeHelper.Deserialize<DateTimeRange>(segments.ElementAtOrDefault(34), false) : null;
            ExpectedReturnDate = segments.ElementAtOrDefault(35)?.ToNullableDateTime();
            CostCenterCode = segments.Length > 36 ? segments.ElementAtOrDefault(36).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            GenericClassificationIndicator = segments.ElementAtOrDefault(37);
            InactiveReasonCode = segments.Length > 38 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(38), false) : null;
            GenericResourceTypeOrCategory = segments.Length > 39 ? segments.ElementAtOrDefault(39).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            Religion = segments.Length > 40 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(40), false) : null;
            Signature = segments.Length > 41 ? TypeHelper.Deserialize<EncapsulatedData>(segments.ElementAtOrDefault(41), false) : null;
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
                                StringHelper.StringFormatSequence(0, 42, Configuration.FieldSeparator),
                                Id,
                                PrimaryKeyValueStf?.ToDelimitedString(),
                                StaffIdentifierList != null ? string.Join(Configuration.FieldRepeatSeparator, StaffIdentifierList.Select(x => x.ToDelimitedString())) : null,
                                StaffName != null ? string.Join(Configuration.FieldRepeatSeparator, StaffName.Select(x => x.ToDelimitedString())) : null,
                                StaffType != null ? string.Join(Configuration.FieldRepeatSeparator, StaffType.Select(x => x.ToDelimitedString())) : null,
                                AdministrativeSex?.ToDelimitedString(),
                                DateTimeOfBirth.HasValue ? DateTimeOfBirth.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ActiveInactiveFlag,
                                Department != null ? string.Join(Configuration.FieldRepeatSeparator, Department.Select(x => x.ToDelimitedString())) : null,
                                HospitalServiceStf != null ? string.Join(Configuration.FieldRepeatSeparator, HospitalServiceStf.Select(x => x.ToDelimitedString())) : null,
                                Phone != null ? string.Join(Configuration.FieldRepeatSeparator, Phone.Select(x => x.ToDelimitedString())) : null,
                                OfficeHomeAddressBirthplace != null ? string.Join(Configuration.FieldRepeatSeparator, OfficeHomeAddressBirthplace.Select(x => x.ToDelimitedString())) : null,
                                InstitutionActivationDate != null ? string.Join(Configuration.FieldRepeatSeparator, InstitutionActivationDate.Select(x => x.ToDelimitedString())) : null,
                                InstitutionInactivationDate != null ? string.Join(Configuration.FieldRepeatSeparator, InstitutionInactivationDate.Select(x => x.ToDelimitedString())) : null,
                                BackupPersonId != null ? string.Join(Configuration.FieldRepeatSeparator, BackupPersonId.Select(x => x.ToDelimitedString())) : null,
                                EmailAddress != null ? string.Join(Configuration.FieldRepeatSeparator, EmailAddress) : null,
                                PreferredMethodOfContact?.ToDelimitedString(),
                                MaritalStatus?.ToDelimitedString(),
                                JobTitle,
                                JobCodeClass?.ToDelimitedString(),
                                EmploymentStatusCode?.ToDelimitedString(),
                                AdditionalInsuredOnAuto,
                                DriversLicenseNumberStaff?.ToDelimitedString(),
                                CopyAutoIns,
                                AutoInsExpires.HasValue ? AutoInsExpires.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                DateLastDmvReview.HasValue ? DateLastDmvReview.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                DateNextDmvReview.HasValue ? DateNextDmvReview.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                Race?.ToDelimitedString(),
                                EthnicGroup?.ToDelimitedString(),
                                ReactivationApprovalIndicator,
                                Citizenship != null ? string.Join(Configuration.FieldRepeatSeparator, Citizenship.Select(x => x.ToDelimitedString())) : null,
                                DateTimeOfDeath.HasValue ? DateTimeOfDeath.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                DeathIndicator,
                                InstitutionRelationshipTypeCode?.ToDelimitedString(),
                                InstitutionRelationshipPeriod?.ToDelimitedString(),
                                ExpectedReturnDate.HasValue ? ExpectedReturnDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                CostCenterCode != null ? string.Join(Configuration.FieldRepeatSeparator, CostCenterCode.Select(x => x.ToDelimitedString())) : null,
                                GenericClassificationIndicator,
                                InactiveReasonCode?.ToDelimitedString(),
                                GenericResourceTypeOrCategory != null ? string.Join(Configuration.FieldRepeatSeparator, GenericResourceTypeOrCategory.Select(x => x.ToDelimitedString())) : null,
                                Religion?.ToDelimitedString(),
                                Signature?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}