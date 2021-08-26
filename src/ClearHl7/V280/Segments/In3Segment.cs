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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V280.CodeYesNoIndicator</para>
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
        public CodedWithExceptions NonConcurCodeDescription { get; set; }

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
        public CodedWithExceptions AppealReason { get; set; }

        /// <summary>
        /// IN3.18 - Certification Agency.
        /// <para>Suggested: 0346 Certification Agency</para>
        /// </summary>
        public CodedWithExceptions CertificationAgency { get; set; }

        /// <summary>
        /// IN3.19 - Certification Agency Phone Number.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> CertificationAgencyPhoneNumber { get; set; }

        /// <summary>
        /// IN3.20 - Pre-Certification Requirement.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V280.CodeYesNoIndicator</para>
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
        public CodedWithExceptions SecondOpinionStatus { get; set; }

        /// <summary>
        /// IN3.24 - Second Opinion Documentation Received.
        /// <para>Suggested: 0152 Second Opinion Documentation Received</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> SecondOpinionDocumentationReceived { get; set; }

        /// <summary>
        /// IN3.25 - Second Opinion Physician.
        /// <para>Suggested: 0010 Physician ID</para>
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> SecondOpinionPhysician { get; set; }

        /// <summary>
        /// IN3.26 - Certification Type.
        /// <para>Suggested: 0921 Certification Type Code -&gt; ClearHl7.Codes.V280.CodeCertificationTypeCode</para>
        /// </summary>
        public CodedWithExceptions CertificationType { get; set; }

        /// <summary>
        /// IN3.27 - Certification Category.
        /// <para>Suggested: 0922 Certification Category Code -&gt; ClearHl7.Codes.V280.CodeCertificationCategoryCode</para>
        /// </summary>
        public CodedWithExceptions CertificationCategory { get; set; }

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

            SetIdIn3 = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            CertificationNumber = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments[2], false) : null;
            CertifiedBy = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            CertificationRequired = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            Penalty = segments.Length > 5 && segments[5].Length > 0 ? TypeHelper.Deserialize<MoneyOrPercentage>(segments[5], false) : null;
            CertificationDateTime = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDateTime() : null;
            CertificationModifyDateTime = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDateTime() : null;
            Operator = segments.Length > 8 && segments[8].Length > 0 ? segments[8].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            CertificationBeginDate = segments.Length > 9 && segments[9].Length > 0 ? segments[9].ToNullableDateTime() : null;
            CertificationEndDate = segments.Length > 10 && segments[10].Length > 0 ? segments[10].ToNullableDateTime() : null;
            Days = segments.Length > 11 && segments[11].Length > 0 ? TypeHelper.Deserialize<DayTypeAndNumber>(segments[11], false) : null;
            NonConcurCodeDescription = segments.Length > 12 && segments[12].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[12], false) : null;
            NonConcurEffectiveDateTime = segments.Length > 13 && segments[13].Length > 0 ? segments[13].ToNullableDateTime() : null;
            PhysicianReviewer = segments.Length > 14 && segments[14].Length > 0 ? segments[14].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            CertificationContact = segments.Length > 15 && segments[15].Length > 0 ? segments[15] : null;
            CertificationContactPhoneNumber = segments.Length > 16 && segments[16].Length > 0 ? segments[16].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            AppealReason = segments.Length > 17 && segments[17].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[17], false) : null;
            CertificationAgency = segments.Length > 18 && segments[18].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[18], false) : null;
            CertificationAgencyPhoneNumber = segments.Length > 19 && segments[19].Length > 0 ? segments[19].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            PreCertificationRequirement = segments.Length > 20 && segments[20].Length > 0 ? segments[20].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<InsuranceCertificationDefinition>(x, false)) : null;
            CaseManager = segments.Length > 21 && segments[21].Length > 0 ? segments[21] : null;
            SecondOpinionDate = segments.Length > 22 && segments[22].Length > 0 ? segments[22].ToNullableDateTime() : null;
            SecondOpinionStatus = segments.Length > 23 && segments[23].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[23], false) : null;
            SecondOpinionDocumentationReceived = segments.Length > 24 && segments[24].Length > 0 ? segments[24].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            SecondOpinionPhysician = segments.Length > 25 && segments[25].Length > 0 ? segments[25].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            CertificationType = segments.Length > 26 && segments[26].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[26], false) : null;
            CertificationCategory = segments.Length > 27 && segments[27].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[27], false) : null;
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
                                StringHelper.StringFormatSequence(0, 28, Configuration.FieldSeparator),
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
                                SecondOpinionStatus?.ToDelimitedString(),
                                SecondOpinionDocumentationReceived != null ? string.Join(Configuration.FieldRepeatSeparator, SecondOpinionDocumentationReceived.Select(x => x.ToDelimitedString())) : null,
                                SecondOpinionPhysician != null ? string.Join(Configuration.FieldRepeatSeparator, SecondOpinionPhysician.Select(x => x.ToDelimitedString())) : null,
                                CertificationType?.ToDelimitedString(),
                                CertificationCategory?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}