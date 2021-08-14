using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V251.Types;

namespace ClearHl7.V251.Segments
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V251.CodeYesNoIndicator</para>
        /// </summary>
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
        /// <para>Suggested: 0233 Non-Concur Code/Description</para>
        /// </summary>
        public CodedElement NonConcurCodeDescription { get; set; }

        /// <summary>
        /// IN3.13 - Non-Concur Effective Date/Time.
        /// </summary>
        public DateTime? NonConcurEffectiveDateTime { get; set; }

        /// <summary>
        /// IN3.14 - Physician Reviewer.
        /// <para>Suggested: 0010 Physician ID</para>
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
        /// <para>Suggested: 0345 Appeal Reason</para>
        /// </summary>
        public CodedElement AppealReason { get; set; }

        /// <summary>
        /// IN3.18 - Certification Agency.
        /// <para>Suggested: 0346 Certification Agency</para>
        /// </summary>
        public CodedElement CertificationAgency { get; set; }

        /// <summary>
        /// IN3.19 - Certification Agency Phone Number.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> CertificationAgencyPhoneNumber { get; set; }

        /// <summary>
        /// IN3.20 - Pre-Certification Requirement.
        /// </summary>
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
        /// <para>Suggested: 0010 Physician ID</para>
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> SecondOpinionPhysician { get; set; }

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

            SetIdIn3 = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            CertificationNumber = segments.Length > 2 ? TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments.ElementAtOrDefault(2), false) : null;
            CertifiedBy = segments.Length > 3 ? segments.ElementAtOrDefault(3).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            CertificationRequired = segments.ElementAtOrDefault(4);
            Penalty = segments.Length > 5 ? TypeHelper.Deserialize<MoneyOrPercentage>(segments.ElementAtOrDefault(5), false) : null;
            CertificationDateTime = segments.ElementAtOrDefault(6)?.ToNullableDateTime();
            CertificationModifyDateTime = segments.ElementAtOrDefault(7)?.ToNullableDateTime();
            Operator = segments.Length > 8 ? segments.ElementAtOrDefault(8).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            CertificationBeginDate = segments.ElementAtOrDefault(9)?.ToNullableDateTime();
            CertificationEndDate = segments.ElementAtOrDefault(10)?.ToNullableDateTime();
            Days = segments.Length > 11 ? TypeHelper.Deserialize<DayTypeAndNumber>(segments.ElementAtOrDefault(11), false) : null;
            NonConcurCodeDescription = segments.Length > 12 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(12), false) : null;
            NonConcurEffectiveDateTime = segments.ElementAtOrDefault(13)?.ToNullableDateTime();
            PhysicianReviewer = segments.Length > 14 ? segments.ElementAtOrDefault(14).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            CertificationContact = segments.ElementAtOrDefault(15);
            CertificationContactPhoneNumber = segments.Length > 16 ? segments.ElementAtOrDefault(16).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            AppealReason = segments.Length > 17 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(17), false) : null;
            CertificationAgency = segments.Length > 18 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(18), false) : null;
            CertificationAgencyPhoneNumber = segments.Length > 19 ? segments.ElementAtOrDefault(19).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            PreCertificationRequirement = segments.Length > 20 ? segments.ElementAtOrDefault(20).Split(separator).Select(x => TypeHelper.Deserialize<InsuranceCertificationDefinition>(x, false)) : null;
            CaseManager = segments.ElementAtOrDefault(21);
            SecondOpinionDate = segments.ElementAtOrDefault(22)?.ToNullableDateTime();
            SecondOpinionStatus = segments.ElementAtOrDefault(23);
            SecondOpinionDocumentationReceived = segments.Length > 24 ? segments.ElementAtOrDefault(24).Split(separator) : null;
            SecondOpinionPhysician = segments.Length > 25 ? segments.ElementAtOrDefault(25).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
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