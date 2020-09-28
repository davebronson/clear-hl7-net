using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V281.Types;

namespace ClearHl7.Fhir.V281.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0061</remarks>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> StaffIdentifierList { get; set; }

        /// <summary>
        /// STF.3 - Staff Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> StaffName { get; set; }

        /// <summary>
        /// STF.4 - Staff Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0182</remarks>
        public IEnumerable<CodedWithExceptions> StaffType { get; set; }

        /// <summary>
        /// STF.5 - Administrative Sex.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0001</remarks>
        public CodedWithExceptions AdministrativeSex { get; set; }

        /// <summary>
        /// STF.6 - Date/Time of Birth.
        /// </summary>
        public DateTime? DateTimeOfBirth { get; set; }

        /// <summary>
        /// STF.7 - Active/Inactive Flag.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0183</remarks>
        public string ActiveInactiveFlag { get; set; }

        /// <summary>
        /// STF.8 - Department.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0184</remarks>
        public IEnumerable<CodedWithExceptions> Department { get; set; }

        /// <summary>
        /// STF.9 - Hospital Service - STF.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0069</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0537</remarks>
        public IEnumerable<DateAndInstitutionName> InstitutionActivationDate { get; set; }

        /// <summary>
        /// STF.13 - Institution Inactivation Date.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0537</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0185</remarks>
        public CodedWithExceptions PreferredMethodOfContact { get; set; }

        /// <summary>
        /// STF.17 - Marital Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0002</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0066</remarks>
        public CodedWithExceptions EmploymentStatusCode { get; set; }

        /// <summary>
        /// STF.21 - Additional Insured on Auto.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string AdditionalInsuredOnAuto { get; set; }

        /// <summary>
        /// STF.22 - Driver's License Number - Staff.
        /// </summary>
        public DriversLicenseNumber DriversLicenseNumberStaff { get; set; }

        /// <summary>
        /// STF.23 - Copy Auto Ins.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0005</remarks>
        public CodedWithExceptions Race { get; set; }

        /// <summary>
        /// STF.28 - Ethnic Group.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0189</remarks>
        public CodedWithExceptions EthnicGroup { get; set; }

        /// <summary>
        /// STF.29 - Re-activation Approval Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string ReActivationApprovalIndicator { get; set; }

        /// <summary>
        /// STF.30 - Citizenship.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0171</remarks>
        public IEnumerable<CodedWithExceptions> Citizenship { get; set; }

        /// <summary>
        /// STF.31 - Date/Time of Death.
        /// </summary>
        public DateTime? DateTimeOfDeath { get; set; }

        /// <summary>
        /// STF.32 - Death Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string DeathIndicator { get; set; }

        /// <summary>
        /// STF.33 - Institution Relationship Type Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0538</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0539</remarks>
        public IEnumerable<CodedWithExceptions> CostCenterCode { get; set; }

        /// <summary>
        /// STF.37 - Generic Classification Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string GenericClassificationIndicator { get; set; }

        /// <summary>
        /// STF.38 - Inactive Reason Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0540</remarks>
        public CodedWithExceptions InactiveReasonCode { get; set; }

        /// <summary>
        /// STF.39 - Generic resource type or category.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0771</remarks>
        public IEnumerable<CodedWithExceptions> GenericResourceTypeOrCategory { get; set; }

        /// <summary>
        /// STF.40 - Religion.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0006</remarks>
        public CodedWithExceptions Religion { get; set; }

        /// <summary>
        /// STF.41 - Signature.
        /// </summary>
        public EncapsulatedData Signature { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|{27}|{28}|{29}|{30}|{31}|{32}|{33}|{34}|{35}|{36}|{37}|{38}|{39}|{40}|{41}",
                                Id,
                                PrimaryKeyValueStf?.ToDelimitedString(),
                                StaffIdentifierList != null ? string.Join("~", StaffIdentifierList.Select(x => x.ToDelimitedString())) : null,
                                StaffName != null ? string.Join("~", StaffName.Select(x => x.ToDelimitedString())) : null,
                                StaffType != null ? string.Join("~", StaffType.Select(x => x.ToDelimitedString())) : null,
                                AdministrativeSex?.ToDelimitedString(),
                                DateTimeOfBirth.HasValue ? DateTimeOfBirth.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ActiveInactiveFlag,
                                Department != null ? string.Join("~", Department.Select(x => x.ToDelimitedString())) : null,
                                HospitalServiceStf != null ? string.Join("~", HospitalServiceStf.Select(x => x.ToDelimitedString())) : null,
                                Phone != null ? string.Join("~", Phone.Select(x => x.ToDelimitedString())) : null,
                                OfficeHomeAddressBirthplace != null ? string.Join("~", OfficeHomeAddressBirthplace.Select(x => x.ToDelimitedString())) : null,
                                InstitutionActivationDate != null ? string.Join("~", InstitutionActivationDate.Select(x => x.ToDelimitedString())) : null,
                                InstitutionInactivationDate != null ? string.Join("~", InstitutionInactivationDate.Select(x => x.ToDelimitedString())) : null,
                                BackupPersonId != null ? string.Join("~", BackupPersonId.Select(x => x.ToDelimitedString())) : null,
                                EmailAddress != null ? string.Join("~", EmailAddress) : null,
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
                                ReActivationApprovalIndicator,
                                Citizenship != null ? string.Join("~", Citizenship.Select(x => x.ToDelimitedString())) : null,
                                DateTimeOfDeath.HasValue ? DateTimeOfDeath.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                DeathIndicator,
                                InstitutionRelationshipTypeCode?.ToDelimitedString(),
                                InstitutionRelationshipPeriod?.ToDelimitedString(),
                                ExpectedReturnDate.HasValue ? ExpectedReturnDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                CostCenterCode != null ? string.Join("~", CostCenterCode.Select(x => x.ToDelimitedString())) : null,
                                GenericClassificationIndicator,
                                InactiveReasonCode?.ToDelimitedString(),
                                GenericResourceTypeOrCategory != null ? string.Join("~", GenericResourceTypeOrCategory.Select(x => x.ToDelimitedString())) : null,
                                Religion?.ToDelimitedString(),
                                Signature?.ToDelimitedString()
                                ).TrimEnd('|');
        }
    }
}