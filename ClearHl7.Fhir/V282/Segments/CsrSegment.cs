using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V282.Types;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment CSR - Clinical Study Registration.
    /// </summary>
    public class CsrSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "CSR";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
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
        /// </summary>
        public CodedWithExceptions PatientStudyEligibilityStatus { get; set; }

        /// <summary>
        /// CSR.11 - Study Randomization Date/time.
        /// </summary>
        public IEnumerable<DateTime> StudyRandomizationDateTime { get; set; }

        /// <summary>
        /// CSR.12 - Randomized Study Arm.
        /// </summary>
        public IEnumerable<CodedWithExceptions> RandomizedStudyArm { get; set; }

        /// <summary>
        /// CSR.13 - Stratum for Study Randomization.
        /// </summary>
        public IEnumerable<CodedWithExceptions> StratumForStudyRandomization { get; set; }

        /// <summary>
        /// CSR.14 - Patient Evaluability Status.
        /// </summary>
        public CodedWithExceptions PatientEvaluabilityStatus { get; set; }

        /// <summary>
        /// CSR.15 - Date/Time Ended Study.
        /// </summary>
        public DateTime? DateTimeEndedStudy { get; set; }

        /// <summary>
        /// CSR.16 - Reason Ended Study.
        /// </summary>
        public CodedWithExceptions ReasonEndedStudy { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 17, Configuration.FieldSeparator),
                                Id,
                                SponsorStudyId?.ToDelimitedString(),
                                AlternateStudyId?.ToDelimitedString(),
                                InstitutionRegisteringThePatient?.ToDelimitedString(),
                                SponsorPatientId?.ToDelimitedString(),
                                AlternatePatientIdCsr?.ToDelimitedString(),
                                DateTimeOfPatientStudyRegistration.HasValue ? DateTimeOfPatientStudyRegistration.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                PersonPerformingStudyRegistration != null ? string.Join(Configuration.FieldRepeatSeparator, PersonPerformingStudyRegistration.Select(x => x.ToDelimitedString())) : null,
                                StudyAuthorizingProvider != null ? string.Join(Configuration.FieldRepeatSeparator, StudyAuthorizingProvider.Select(x => x.ToDelimitedString())) : null,
                                DateTimePatientStudyConsentSigned.HasValue ? DateTimePatientStudyConsentSigned.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                PatientStudyEligibilityStatus?.ToDelimitedString(),
                                StudyRandomizationDateTime != null ? string.Join(Configuration.FieldRepeatSeparator, StudyRandomizationDateTime.Select(x => x.ToString(Consts.DateTimeFormatPrecisionSecond, culture))) : null,
                                RandomizedStudyArm != null ? string.Join(Configuration.FieldRepeatSeparator, RandomizedStudyArm.Select(x => x.ToDelimitedString())) : null,
                                StratumForStudyRandomization != null ? string.Join(Configuration.FieldRepeatSeparator, StratumForStudyRandomization.Select(x => x.ToDelimitedString())) : null,
                                PatientEvaluabilityStatus?.ToDelimitedString(),
                                DateTimeEndedStudy.HasValue ? DateTimeEndedStudy.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ReasonEndedStudy?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator);
        }
    }
}