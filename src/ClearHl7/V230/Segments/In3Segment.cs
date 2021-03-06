﻿using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V230.CodeYesNoIndicator</para>
        /// </summary>
        public string CertificationRequired { get; set; }

        /// <summary>
        /// IN3.5 - Penalty.
        /// <para>Suggested: 0148 Money Or Percentage Indicator -&gt; ClearHl7.Codes.V230.CodeMoneyOrPercentageIndicator</para>
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
        /// <para>Suggested: 0149 Day Type -&gt; ClearHl7.Codes.V230.CodeDayType</para>
        /// </summary>
        public DayTypeAndNumber Days { get; set; }

        /// <summary>
        /// IN3.12 - Non-Concur Code/Description.
        /// <para>Suggested: 0233 Non-Concur Code/Description</para>
        /// </summary>
        public CodedElement NonConcurCodeDescription { get; set; }

        /// <summary>
        /// IN3.13 - Non-Concur Effective Date/Time.
        /// </summary>
        public DateTime? NonConcurEffectiveDateTime { get; set; }

        /// <summary>
        /// IN3.14 - Physician Reviewer.
        /// </summary>
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
        public CodedElement AppealReason { get; set; }

        /// <summary>
        /// IN3.18 - Certification Agency.
        /// </summary>
        public CodedElement CertificationAgency { get; set; }

        /// <summary>
        /// IN3.19 - Certification Agency Phone Number.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> CertificationAgencyPhoneNumber { get; set; }

        /// <summary>
        /// IN3.20 - Pre-Certification Requirement.
        /// <para>Suggested: 0150 Certification Patient Type -&gt; ClearHl7.Codes.V230.CodeCertificationPatientType</para>
        /// </summary>
        public IEnumerable<PreCertificationRequired> PreCertificationRequirement { get; set; }

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
        /// <para>Suggested: 0151 Second Opinion Status</para>
        /// </summary>
        public string SecondOpinionStatus { get; set; }

        /// <summary>
        /// IN3.24 - Second Opinion Documentation Received.
        /// <para>Suggested: 0152 Second Opinion Documentation Received</para>
        /// </summary>
        public IEnumerable<string> SecondOpinionDocumentationReceived { get; set; }

        /// <summary>
        /// IN3.25 - Second Opinion Physician.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> SecondOpinionPhysician { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 26, Configuration.FieldSeparator),
                                Id,
                                SetIdIn3.HasValue ? SetIdIn3.Value.ToString(culture) : null,
                                CertificationNumber?.ToDelimitedString(),
                                CertifiedBy != null ? string.Join(Configuration.FieldRepeatSeparator, CertifiedBy.Select(x => x.ToDelimitedString())) : null,
                                CertificationRequired,
                                Penalty?.ToDelimitedString(),
                                CertificationDateTime.HasValue ? CertificationDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                CertificationModifyDateTime.HasValue ? CertificationModifyDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                Operator != null ? string.Join(Configuration.FieldRepeatSeparator, Operator.Select(x => x.ToDelimitedString())) : null,
                                CertificationBeginDate.HasValue ? CertificationBeginDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                CertificationEndDate.HasValue ? CertificationEndDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                Days?.ToDelimitedString(),
                                NonConcurCodeDescription?.ToDelimitedString(),
                                NonConcurEffectiveDateTime.HasValue ? NonConcurEffectiveDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                PhysicianReviewer != null ? string.Join(Configuration.FieldRepeatSeparator, PhysicianReviewer.Select(x => x.ToDelimitedString())) : null,
                                CertificationContact,
                                CertificationContactPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, CertificationContactPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                AppealReason?.ToDelimitedString(),
                                CertificationAgency?.ToDelimitedString(),
                                CertificationAgencyPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, CertificationAgencyPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                PreCertificationRequirement != null ? string.Join(Configuration.FieldRepeatSeparator, PreCertificationRequirement.Select(x => x.ToDelimitedString())) : null,
                                CaseManager,
                                SecondOpinionDate.HasValue ? SecondOpinionDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                SecondOpinionStatus,
                                SecondOpinionDocumentationReceived != null ? string.Join(Configuration.FieldRepeatSeparator, SecondOpinionDocumentationReceived) : null,
                                SecondOpinionPhysician != null ? string.Join(Configuration.FieldRepeatSeparator, SecondOpinionPhysician.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}