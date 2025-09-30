using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment CSR - Clinical Study Registration.
    /// </summary>
    public class CsrSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CsrSegment"/> class.
        /// </summary>
        public CsrSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CsrSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public CsrSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "CSR";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// CSR.1 - Sponsor Study ID.
        /// </summary>
        public EntityIdentifier SponsorStudyId { get; set; }

        /// <summary>
        /// CSR.2 - Alternate Study ID.
        /// </summary>
        public EntityIdentifier AlternateStudyId { get; set; }

        /// <summary>
        /// CSR.3 - Institution Registering the Patient.
        /// <para>Suggested: 0589 Institution Registering The Patient</para>
        /// </summary>
        public CodedWithExceptions InstitutionRegisteringThePatient { get; set; }

        /// <summary>
        /// CSR.4 - Sponsor Patient ID.
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit SponsorPatientId { get; set; }

        /// <summary>
        /// CSR.5 - Alternate Patient ID - CSR.
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit AlternatePatientIdCsr { get; set; }

        /// <summary>
        /// CSR.6 - Date/Time of Patient Study Registration.
        /// </summary>
        public DateTime? DateTimeOfPatientStudyRegistration { get; set; }

        /// <summary>
        /// CSR.7 - Person Performing Study Registration.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> PersonPerformingStudyRegistration { get; set; }

        /// <summary>
        /// CSR.8 - Study Authorizing Provider.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> StudyAuthorizingProvider { get; set; }

        /// <summary>
        /// CSR.9 - Date/Time Patient Study Consent Signed.
        /// </summary>
        public DateTime? DateTimePatientStudyConsentSigned { get; set; }

        /// <summary>
        /// CSR.10 - Patient Study Eligibility Status.
        /// <para>Suggested: 0590 Patient Study Eligibility Status</para>
        /// </summary>
        public CodedWithExceptions PatientStudyEligibilityStatus { get; set; }

        /// <summary>
        /// CSR.11 - Study Randomization Date/time.
        /// </summary>
        public IEnumerable<DateTime> StudyRandomizationDateTime { get; set; }

        /// <summary>
        /// CSR.12 - Randomized Study Arm.
        /// <para>Suggested: 0591 Randomized Study Arm</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> RandomizedStudyArm { get; set; }

        /// <summary>
        /// CSR.13 - Stratum for Study Randomization.
        /// <para>Suggested: 0592 Stratum For Study Randomization</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> StratumForStudyRandomization { get; set; }

        /// <summary>
        /// CSR.14 - Patient Evaluability Status.
        /// <para>Suggested: 0593 Patient Evaluability Status</para>
        /// </summary>
        public CodedWithExceptions PatientEvaluabilityStatus { get; set; }

        /// <summary>
        /// CSR.15 - Date/Time Ended Study.
        /// </summary>
        public DateTime? DateTimeEndedStudy { get; set; }

        /// <summary>
        /// CSR.16 - Reason Ended Study.
        /// <para>Suggested: 0594 Reason Ended Study</para>
        /// </summary>
        public CodedWithExceptions ReasonEndedStudy { get; set; }

        /// <summary>
        /// CSR.17 - Action Code.
        /// </summary>
        public string ActionCode { get; set; }

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

            SponsorStudyId = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[1], false, seps) : null;
            AlternateStudyId = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[2], false, seps) : null;
            InstitutionRegisteringThePatient = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[3], false, seps) : null;
            SponsorPatientId = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments[4], false, seps) : null;
            AlternatePatientIdCsr = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments[5], false, seps) : null;
            DateTimeOfPatientStudyRegistration = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDateTime() : null;
            PersonPerformingStudyRegistration = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            StudyAuthorizingProvider = segments.Length > 8 && segments[8].Length > 0 ? segments[8].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            DateTimePatientStudyConsentSigned = segments.Length > 9 && segments[9].Length > 0 ? segments[9].ToNullableDateTime() : null;
            PatientStudyEligibilityStatus = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[10], false, seps) : null;
            StudyRandomizationDateTime = segments.Length > 11 && segments[11].Length > 0 ? segments[11].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => x.ToDateTime()) : null;
            RandomizedStudyArm = segments.Length > 12 && segments[12].Length > 0 ? segments[12].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            StratumForStudyRandomization = segments.Length > 13 && segments[13].Length > 0 ? segments[13].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            PatientEvaluabilityStatus = segments.Length > 14 && segments[14].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[14], false, seps) : null;
            DateTimeEndedStudy = segments.Length > 15 && segments[15].Length > 0 ? segments[15].ToNullableDateTime() : null;
            ReasonEndedStudy = segments.Length > 16 && segments[16].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[16], false, seps) : null;
            ActionCode = segments.Length > 17 && segments[17].Length > 0 ? segments[17] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 18, Configuration.FieldSeparator),
                                Id,
                                SponsorStudyId?.ToDelimitedString(),
                                AlternateStudyId?.ToDelimitedString(),
                                InstitutionRegisteringThePatient?.ToDelimitedString(),
                                SponsorPatientId?.ToDelimitedString(),
                                AlternatePatientIdCsr?.ToDelimitedString(),
                                DateTimeOfPatientStudyRegistration?.ToHl7DateTimeString(typeof(CsrSegment), nameof(DateTimeOfPatientStudyRegistration), Consts.DateTimeFormatPrecisionSecond, culture),
                                PersonPerformingStudyRegistration != null ? string.Join(Configuration.FieldRepeatSeparator, PersonPerformingStudyRegistration.Select(x => x.ToDelimitedString())) : null,
                                StudyAuthorizingProvider != null ? string.Join(Configuration.FieldRepeatSeparator, StudyAuthorizingProvider.Select(x => x.ToDelimitedString())) : null,
                                DateTimePatientStudyConsentSigned?.ToHl7DateTimeString(typeof(CsrSegment), nameof(DateTimePatientStudyConsentSigned), Consts.DateTimeFormatPrecisionSecond, culture),
                                PatientStudyEligibilityStatus?.ToDelimitedString(),
                                StudyRandomizationDateTime != null ? string.Join(Configuration.FieldRepeatSeparator, StudyRandomizationDateTime.Select(x => x.ToString(Consts.DateTimeFormatPrecisionSecond, culture))) : null,
                                RandomizedStudyArm != null ? string.Join(Configuration.FieldRepeatSeparator, RandomizedStudyArm.Select(x => x.ToDelimitedString())) : null,
                                StratumForStudyRandomization != null ? string.Join(Configuration.FieldRepeatSeparator, StratumForStudyRandomization.Select(x => x.ToDelimitedString())) : null,
                                PatientEvaluabilityStatus?.ToDelimitedString(),
                                DateTimeEndedStudy?.ToHl7DateTimeString(typeof(CsrSegment), nameof(DateTimeEndedStudy), Consts.DateTimeFormatPrecisionSecond, culture),
                                ReasonEndedStudy?.ToDelimitedString(),
                                ActionCode
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
