using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V282.Types;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment IN3 - Insurance Additional Information, Certification.
    /// </summary>
    public class In3Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "IN3";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// IN3.1 - Set ID - IN3.
        /// </summary>
        public uint? SetIdIn3 { get; set; }

        /// <summary>
        /// IN3.2 - Certification Number.
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit CertificationNumber { get; set; }

        /// <summary>
        /// IN3.3 - Certified By.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> CertifiedBy { get; set; }

        /// <summary>
        /// IN3.4 - Certification Required.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string CertificationRequired { get; set; }

        /// <summary>
        /// IN3.5 - Penalty.
        /// </summary>
        public MoneyOrPercentage Penalty { get; set; }

        /// <summary>
        /// IN3.6 - Certification Date/Time.
        /// </summary>
        public DateTime? CertificationDateTime { get; set; }

        /// <summary>
        /// IN3.7 - Certification Modify Date/Time.
        /// </summary>
        public DateTime? CertificationModifyDateTime { get; set; }

        /// <summary>
        /// IN3.8 - Operator.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> Operator { get; set; }

        /// <summary>
        /// IN3.9 - Certification Begin Date.
        /// </summary>
        public DateTime? CertificationBeginDate { get; set; }

        /// <summary>
        /// IN3.10 - Certification End Date.
        /// </summary>
        public DateTime? CertificationEndDate { get; set; }

        /// <summary>
        /// IN3.11 - Days.
        /// </summary>
        public DayTypeAndNumber Days { get; set; }

        /// <summary>
        /// IN3.12 - Non-Concur Code/Description.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0233</remarks>
        public CodedWithExceptions NonConcurCodeDescription { get; set; }

        /// <summary>
        /// IN3.13 - Non-Concur Effective Date/Time.
        /// </summary>
        public DateTime? NonConcurEffectiveDateTime { get; set; }

        /// <summary>
        /// IN3.14 - Physician Reviewer.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0010</remarks>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> PhysicianReviewer { get; set; }

        /// <summary>
        /// IN3.15 - Certification Contact.
        /// </summary>
        public string CertificationContact { get; set; }

        /// <summary>
        /// IN3.16 - Certification Contact Phone Number.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> CertificationContactPhoneNumber { get; set; }

        /// <summary>
        /// IN3.17 - Appeal Reason.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0345</remarks>
        public CodedWithExceptions AppealReason { get; set; }

        /// <summary>
        /// IN3.18 - Certification Agency.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0346</remarks>
        public CodedWithExceptions CertificationAgency { get; set; }

        /// <summary>
        /// IN3.19 - Certification Agency Phone Number.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> CertificationAgencyPhoneNumber { get; set; }

        /// <summary>
        /// IN3.20 - Pre-Certification Requirement.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public IEnumerable<InsuranceCertificationDefinition> PreCertificationRequirement { get; set; }

        /// <summary>
        /// IN3.21 - Case Manager.
        /// </summary>
        public string CaseManager { get; set; }

        /// <summary>
        /// IN3.22 - Second Opinion Date.
        /// </summary>
        public DateTime? SecondOpinionDate { get; set; }

        /// <summary>
        /// IN3.23 - Second Opinion Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0151</remarks>
        public CodedWithExceptions SecondOpinionStatus { get; set; }

        /// <summary>
        /// IN3.24 - Second Opinion Documentation Received.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0152</remarks>
        public IEnumerable<CodedWithExceptions> SecondOpinionDocumentationReceived { get; set; }

        /// <summary>
        /// IN3.25 - Second Opinion Physician.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0010</remarks>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> SecondOpinionPhysician { get; set; }

        /// <summary>
        /// IN3.26 - Certification Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0921</remarks>
        public CodedWithExceptions CertificationType { get; set; }

        /// <summary>
        /// IN3.27 - Certification Category.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0922</remarks>
        public CodedWithExceptions CertificationCategory { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|{27}",
                                Id,
                                SetIdIn3.HasValue ? SetIdIn3.Value.ToString(culture) : null,
                                CertificationNumber?.ToDelimitedString(),
                                CertifiedBy != null ? string.Join("~", CertifiedBy.Select(x => x.ToDelimitedString())) : null,
                                CertificationRequired,
                                Penalty?.ToDelimitedString(),
                                CertificationDateTime.HasValue ? CertificationDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                CertificationModifyDateTime.HasValue ? CertificationModifyDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                Operator != null ? string.Join("~", Operator.Select(x => x.ToDelimitedString())) : null,
                                CertificationBeginDate.HasValue ? CertificationBeginDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                CertificationEndDate.HasValue ? CertificationEndDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                Days?.ToDelimitedString(),
                                NonConcurCodeDescription?.ToDelimitedString(),
                                NonConcurEffectiveDateTime.HasValue ? NonConcurEffectiveDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                PhysicianReviewer != null ? string.Join("~", PhysicianReviewer.Select(x => x.ToDelimitedString())) : null,
                                CertificationContact,
                                CertificationContactPhoneNumber != null ? string.Join("~", CertificationContactPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                AppealReason?.ToDelimitedString(),
                                CertificationAgency?.ToDelimitedString(),
                                CertificationAgencyPhoneNumber != null ? string.Join("~", CertificationAgencyPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                PreCertificationRequirement != null ? string.Join("~", PreCertificationRequirement.Select(x => x.ToDelimitedString())) : null,
                                CaseManager,
                                SecondOpinionDate.HasValue ? SecondOpinionDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                SecondOpinionStatus?.ToDelimitedString(),
                                SecondOpinionDocumentationReceived != null ? string.Join("~", SecondOpinionDocumentationReceived.Select(x => x.ToDelimitedString())) : null,
                                SecondOpinionPhysician != null ? string.Join("~", SecondOpinionPhysician.Select(x => x.ToDelimitedString())) : null,
                                CertificationType?.ToDelimitedString(),
                                CertificationCategory?.ToDelimitedString()
                                ).TrimEnd('|');
        }
    }
}