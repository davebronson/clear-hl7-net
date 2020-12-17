using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V240.Types;

namespace ClearHl7.Fhir.V240.Segments
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
        public CodedElement PrimaryKeyValueStf { get; set; }

        /// <summary>
        /// STF.2 - Staff Identifier List.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> StaffIdentifierList { get; set; }

        /// <summary>
        /// STF.3 - Staff Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> StaffName { get; set; }

        /// <summary>
        /// STF.4 - Staff Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0182</remarks>
        public IEnumerable<string> StaffType { get; set; }

        /// <summary>
        /// STF.5 - Administrative Sex.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0001</remarks>
        public string AdministrativeSex { get; set; }

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
        public IEnumerable<CodedElement> Department { get; set; }

        /// <summary>
        /// STF.9 - Hospital Service - STF.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0069</remarks>
        public IEnumerable<CodedElement> HospitalServiceStf { get; set; }

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
        public IEnumerable<CodedElement> BackupPersonId { get; set; }

        /// <summary>
        /// STF.15 - E-Mail Address.
        /// </summary>
        public IEnumerable<string> EmailAddress { get; set; }

        /// <summary>
        /// STF.16 - Preferred Method of Contact.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0185</remarks>
        public CodedElement PreferredMethodOfContact { get; set; }

        /// <summary>
        /// STF.17 - Marital Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0002</remarks>
        public CodedElement MaritalStatus { get; set; }

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
        public string EmploymentStatusCode { get; set; }

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
        public CodedElement Race { get; set; }

        /// <summary>
        /// STF.28 - Ethnic Group.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0189</remarks>
        public CodedElement EthnicGroup { get; set; }

        /// <summary>
        /// STF.29 - Re-activation Approval Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string ReactivationApprovalIndicator { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 30, Configuration.FieldSeparator),
                                Id,
                                PrimaryKeyValueStf?.ToDelimitedString(),
                                StaffIdentifierList != null ? string.Join(Configuration.FieldRepeatSeparator, StaffIdentifierList.Select(x => x.ToDelimitedString())) : null,
                                StaffName != null ? string.Join(Configuration.FieldRepeatSeparator, StaffName.Select(x => x.ToDelimitedString())) : null,
                                StaffType != null ? string.Join(Configuration.FieldRepeatSeparator, StaffType) : null,
                                AdministrativeSex,
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
                                EmploymentStatusCode,
                                AdditionalInsuredOnAuto,
                                DriversLicenseNumberStaff?.ToDelimitedString(),
                                CopyAutoIns,
                                AutoInsExpires.HasValue ? AutoInsExpires.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                DateLastDmvReview.HasValue ? DateLastDmvReview.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                DateNextDmvReview.HasValue ? DateNextDmvReview.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                Race?.ToDelimitedString(),
                                EthnicGroup?.ToDelimitedString(),
                                ReactivationApprovalIndicator
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}