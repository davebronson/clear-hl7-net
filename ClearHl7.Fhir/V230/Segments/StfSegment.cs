using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V230.Types;

namespace ClearHl7.Fhir.V230.Segments
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
        public IEnumerable<CodedElement> StaffIdentifierList { get; set; }

        /// <summary>
        /// STF.3 - Staff Name.
        /// </summary>
        public ExtendedPersonName StaffName { get; set; }

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
        public IEnumerable<DateAndInstitutionName> InstitutionActivationDate { get; set; }

        /// <summary>
        /// STF.13 - Institution Inactivation Date.
        /// </summary>
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
        public string PreferredMethodOfContact { get; set; }

        /// <summary>
        /// STF.17 - Marital Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0002</remarks>
        public string MaritalStatus { get; set; }

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
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}",
                                Id,
                                PrimaryKeyValueStf?.ToDelimitedString(),
                                StaffIdentifierList != null ? string.Join("~", StaffIdentifierList.Select(x => x.ToDelimitedString())) : null,
                                StaffName?.ToDelimitedString(),
                                StaffType != null ? string.Join("~", StaffType) : null,
                                AdministrativeSex,
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
                                PreferredMethodOfContact,
                                MaritalStatus,
                                JobTitle,
                                JobCodeClass?.ToDelimitedString(),
                                EmploymentStatusCode,
                                AdditionalInsuredOnAuto,
                                DriversLicenseNumberStaff?.ToDelimitedString(),
                                CopyAutoIns,
                                AutoInsExpires.HasValue ? AutoInsExpires.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                DateLastDmvReview.HasValue ? DateLastDmvReview.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                DateNextDmvReview.HasValue ? DateNextDmvReview.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null
                                ).TrimEnd('|');
        }
    }
}