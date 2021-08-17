using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V250.Types;

namespace ClearHl7.V250.Segments
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
        public CodedElement InstitutionRegisteringThePatient { get; set; }

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
        public CodedElement PatientStudyEligibilityStatus { get; set; }

        /// <summary>
        /// CSR.11 - Study Randomization Date/time.
        /// </summary>
        public IEnumerable<DateTime> StudyRandomizationDateTime { get; set; }

        /// <summary>
        /// CSR.12 - Randomized Study Arm.
        /// </summary>
        public IEnumerable<CodedElement> RandomizedStudyArm { get; set; }

        /// <summary>
        /// CSR.13 - Stratum for Study Randomization.
        /// </summary>
        public IEnumerable<CodedElement> StratumForStudyRandomization { get; set; }

        /// <summary>
        /// CSR.14 - Patient Evaluability Status.
        /// </summary>
        public CodedElement PatientEvaluabilityStatus { get; set; }

        /// <summary>
        /// CSR.15 - Date/Time Ended Study.
        /// </summary>
        public DateTime? DateTimeEndedStudy { get; set; }

        /// <summary>
        /// CSR.16 - Reason Ended Study.
        /// </summary>
        public CodedElement ReasonEndedStudy { get; set; }

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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SponsorStudyId = segments.Length > 1 && segments[1].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[1], false) : null;
            AlternateStudyId = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[2], false) : null;
            InstitutionRegisteringThePatient = segments.Length > 3 && segments[3].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[3], false) : null;
            SponsorPatientId = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments[4], false) : null;
            AlternatePatientIdCsr = segments.Length > 5 && segments[5].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments[5], false) : null;
            DateTimeOfPatientStudyRegistration = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDateTime() : null;
            PersonPerformingStudyRegistration = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            StudyAuthorizingProvider = segments.Length > 8 && segments[8].Length > 0 ? segments[8].Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            DateTimePatientStudyConsentSigned = segments.Length > 9 && segments[9].Length > 0 ? segments[9].ToNullableDateTime() : null;
            PatientStudyEligibilityStatus = segments.Length > 10 && segments[10].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[10], false) : null;
            StudyRandomizationDateTime = segments.Length > 11 && segments[11].Length > 0 ? segments[11].Split(separator).Select(x => x.ToDateTime()) : null;
            RandomizedStudyArm = segments.Length > 12 && segments[12].Length > 0 ? segments[12].Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            StratumForStudyRandomization = segments.Length > 13 && segments[13].Length > 0 ? segments[13].Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            PatientEvaluabilityStatus = segments.Length > 14 && segments[14].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[14], false) : null;
            DateTimeEndedStudy = segments.Length > 15 && segments[15].Length > 0 ? segments[15].ToNullableDateTime() : null;
            ReasonEndedStudy = segments.Length > 16 && segments[16].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[16], false) : null;
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
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}