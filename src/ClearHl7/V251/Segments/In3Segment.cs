using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V251.Types;

namespace ClearHl7.V251.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment IN3 - Insurance Additional Information, Certification.
    /// </summary>
    public class In3Segment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="In3Segment"/> class.
        /// </summary>
        public In3Segment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="In3Segment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public In3Segment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "IN3";

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (!string.Equals(Id, segments[0], StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdIn3 = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            CertificationNumber = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments[2], false, seps) : null;
            CertifiedBy = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            CertificationRequired = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            Penalty = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<MoneyOrPercentage>(segments[5], false, seps) : null;
            CertificationDateTime = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDateTime() : null;
            CertificationModifyDateTime = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDateTime() : null;
            Operator = segments.Length > 8 && segments[8].Length > 0 ? segments[8].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            CertificationBeginDate = segments.Length > 9 && segments[9].Length > 0 ? segments[9].ToNullableDateTime() : null;
            CertificationEndDate = segments.Length > 10 && segments[10].Length > 0 ? segments[10].ToNullableDateTime() : null;
            Days = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<DayTypeAndNumber>(segments[11], false, seps) : null;
            NonConcurCodeDescription = segments.Length > 12 && segments[12].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[12], false, seps) : null;
            NonConcurEffectiveDateTime = segments.Length > 13 && segments[13].Length > 0 ? segments[13].ToNullableDateTime() : null;
            PhysicianReviewer = segments.Length > 14 && segments[14].Length > 0 ? segments[14].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            CertificationContact = segments.Length > 15 && segments[15].Length > 0 ? segments[15] : null;
            CertificationContactPhoneNumber = segments.Length > 16 && segments[16].Length > 0 ? segments[16].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedTelecommunicationNumber>(x, false, seps)) : null;
            AppealReason = segments.Length > 17 && segments[17].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[17], false, seps) : null;
            CertificationAgency = segments.Length > 18 && segments[18].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[18], false, seps) : null;
            CertificationAgencyPhoneNumber = segments.Length > 19 && segments[19].Length > 0 ? segments[19].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedTelecommunicationNumber>(x, false, seps)) : null;
            PreCertificationRequirement = segments.Length > 20 && segments[20].Length > 0 ? segments[20].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<InsuranceCertificationDefinition>(x, false, seps)) : null;
            CaseManager = segments.Length > 21 && segments[21].Length > 0 ? segments[21] : null;
            SecondOpinionDate = segments.Length > 22 && segments[22].Length > 0 ? segments[22].ToNullableDateTime() : null;
            SecondOpinionStatus = segments.Length > 23 && segments[23].Length > 0 ? segments[23] : null;
            SecondOpinionDocumentationReceived = segments.Length > 24 && segments[24].Length > 0 ? segments[24].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            SecondOpinionPhysician = segments.Length > 25 && segments[25].Length > 0 ? segments[25].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
        }

        /// <inheritdoc/>
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
                                CertificationDateTime?.ToHl7DateTimeString(typeof(In3Segment), nameof(CertificationDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                CertificationModifyDateTime?.ToHl7DateTimeString(typeof(In3Segment), nameof(CertificationModifyDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                Operator != null ? string.Join(Configuration.FieldRepeatSeparator, Operator.Select(x => x.ToDelimitedString())) : null,
                                CertificationBeginDate?.ToHl7DateTimeString(typeof(In3Segment), nameof(CertificationBeginDate), Consts.DateFormatPrecisionDay, culture),
                                CertificationEndDate?.ToHl7DateTimeString(typeof(In3Segment), nameof(CertificationEndDate), Consts.DateFormatPrecisionDay, culture),
                                Days?.ToDelimitedString(),
                                NonConcurCodeDescription?.ToDelimitedString(),
                                NonConcurEffectiveDateTime?.ToHl7DateTimeString(typeof(In3Segment), nameof(NonConcurEffectiveDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                PhysicianReviewer != null ? string.Join(Configuration.FieldRepeatSeparator, PhysicianReviewer.Select(x => x.ToDelimitedString())) : null,
                                CertificationContact,
                                CertificationContactPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, CertificationContactPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                AppealReason?.ToDelimitedString(),
                                CertificationAgency?.ToDelimitedString(),
                                CertificationAgencyPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, CertificationAgencyPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                PreCertificationRequirement != null ? string.Join(Configuration.FieldRepeatSeparator, PreCertificationRequirement.Select(x => x.ToDelimitedString())) : null,
                                CaseManager,
                                SecondOpinionDate?.ToHl7DateTimeString(typeof(In3Segment), nameof(SecondOpinionDate), Consts.DateFormatPrecisionDay, culture),
                                SecondOpinionStatus,
                                SecondOpinionDocumentationReceived != null ? string.Join(Configuration.FieldRepeatSeparator, SecondOpinionDocumentationReceived) : null,
                                SecondOpinionPhysician != null ? string.Join(Configuration.FieldRepeatSeparator, SecondOpinionPhysician.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
