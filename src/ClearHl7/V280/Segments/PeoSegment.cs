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
    /// HL7 Version 2 Segment PEO - Product Experience Observation.
    /// </summary>
    public class PeoSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PEO";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }
        
        /// <summary>
        /// PEO.1 - Event Identifiers Used.
        /// </summary>
        public IEnumerable<CodedWithExceptions> EventIdentifiersUsed { get; set; }

        /// <summary>
        /// PEO.2 - Event Symptom/Diagnosis Code.
        /// </summary>
        public IEnumerable<CodedWithExceptions> EventSymptomDiagnosisCode { get; set; }

        /// <summary>
        /// PEO.3 - Event Onset Date/Time.
        /// </summary>
        public DateTime? EventOnsetDateTime { get; set; }

        /// <summary>
        /// PEO.4 - Event Exacerbation Date/Time.
        /// </summary>
        public DateTime? EventExacerbationDateTime { get; set; }

        /// <summary>
        /// PEO.5 - Event Improved Date/Time.
        /// </summary>
        public DateTime? EventImprovedDateTime { get; set; }

        /// <summary>
        /// PEO.6 - Event Ended Data/Time.
        /// </summary>
        public DateTime? EventEndedDataTime { get; set; }

        /// <summary>
        /// PEO.7 - Event Location Occurred Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> EventLocationOccurredAddress { get; set; }

        /// <summary>
        /// PEO.8 - Event Qualification.
        /// <para>Suggested: 0237 Event Qualification -&gt; ClearHl7.Codes.V280.CodeEventQualification</para>
        /// </summary>
        public IEnumerable<string> EventQualification { get; set; }

        /// <summary>
        /// PEO.9 - Event Serious.
        /// <para>Suggested: 0238 Event Seriousness -&gt; ClearHl7.Codes.V280.CodeEventSeriousness</para>
        /// </summary>
        public string EventSerious { get; set; }

        /// <summary>
        /// PEO.10 - Event Expected.
        /// <para>Suggested: 0239 Event Expected -&gt; ClearHl7.Codes.V280.CodeEventExpected</para>
        /// </summary>
        public string EventExpected { get; set; }

        /// <summary>
        /// PEO.11 - Event Outcome.
        /// <para>Suggested: 0240 Event Consequence -&gt; ClearHl7.Codes.V280.CodeEventConsequence</para>
        /// </summary>
        public IEnumerable<string> EventOutcome { get; set; }

        /// <summary>
        /// PEO.12 - Patient Outcome.
        /// <para>Suggested: 0241 Patient Outcome -&gt; ClearHl7.Codes.V280.CodePatientOutcome</para>
        /// </summary>
        public string PatientOutcome { get; set; }

        /// <summary>
        /// PEO.13 - Event Description from Others.
        /// </summary>
        public IEnumerable<string> EventDescriptionFromOthers { get; set; }

        /// <summary>
        /// PEO.14 - Event Description from Original Reporter.
        /// </summary>
        public IEnumerable<string> EventDescriptionFromOriginalReporter { get; set; }

        /// <summary>
        /// PEO.15 - Event Description from Patient.
        /// </summary>
        public IEnumerable<string> EventDescriptionFromPatient { get; set; }

        /// <summary>
        /// PEO.16 - Event Description from Practitioner.
        /// </summary>
        public IEnumerable<string> EventDescriptionFromPractitioner { get; set; }

        /// <summary>
        /// PEO.17 - Event Description from Autopsy.
        /// </summary>
        public IEnumerable<string> EventDescriptionFromAutopsy { get; set; }

        /// <summary>
        /// PEO.18 - Cause Of Death.
        /// </summary>
        public IEnumerable<CodedWithExceptions> CauseOfDeath { get; set; }

        /// <summary>
        /// PEO.19 - Primary Observer Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> PrimaryObserverName { get; set; }

        /// <summary>
        /// PEO.20 - Primary Observer Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> PrimaryObserverAddress { get; set; }

        /// <summary>
        /// PEO.21 - Primary Observer Telephone.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> PrimaryObserverTelephone { get; set; }

        /// <summary>
        /// PEO.22 - Primary Observer's Qualification.
        /// <para>Suggested: 0242 Primary Observer's Qualification -&gt; ClearHl7.Codes.V280.CodePrimaryObserversQualification</para>
        /// </summary>
        public string PrimaryObserversQualification { get; set; }

        /// <summary>
        /// PEO.23 - Confirmation Provided By.
        /// <para>Suggested: 0242 Primary Observer's Qualification -&gt; ClearHl7.Codes.V280.CodePrimaryObserversQualification</para>
        /// </summary>
        public string ConfirmationProvidedBy { get; set; }

        /// <summary>
        /// PEO.24 - Primary Observer Aware Date/Time.
        /// </summary>
        public DateTime? PrimaryObserverAwareDateTime { get; set; }

        /// <summary>
        /// PEO.25 - Primary Observer's identity May Be Divulged.
        /// <para>Suggested: 0243 Identity May Be Divulged -&gt; ClearHl7.Codes.V280.CodeIdentityMayBeDivulged</para>
        /// </summary>
        public string PrimaryObserversIdentityMayBeDivulged { get; set; }

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

            EventIdentifiersUsed = segments.Length > 1 ? segments.ElementAtOrDefault(1).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            EventSymptomDiagnosisCode = segments.Length > 2 ? segments.ElementAtOrDefault(2).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            EventOnsetDateTime = segments.ElementAtOrDefault(3)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            EventExacerbationDateTime = segments.ElementAtOrDefault(4)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            EventImprovedDateTime = segments.ElementAtOrDefault(5)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            EventEndedDataTime = segments.ElementAtOrDefault(6)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            EventLocationOccurredAddress = segments.Length > 7 ? segments.ElementAtOrDefault(7).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedAddress>(x, false)) : null;
            EventQualification = segments.Length > 8 ? segments.ElementAtOrDefault(8).Split(separator) : null;
            EventSerious = segments.ElementAtOrDefault(9);
            EventExpected = segments.ElementAtOrDefault(10);
            EventOutcome = segments.Length > 11 ? segments.ElementAtOrDefault(11).Split(separator) : null;
            PatientOutcome = segments.ElementAtOrDefault(12);
            EventDescriptionFromOthers = segments.Length > 13 ? segments.ElementAtOrDefault(13).Split(separator) : null;
            EventDescriptionFromOriginalReporter = segments.Length > 14 ? segments.ElementAtOrDefault(14).Split(separator) : null;
            EventDescriptionFromPatient = segments.Length > 15 ? segments.ElementAtOrDefault(15).Split(separator) : null;
            EventDescriptionFromPractitioner = segments.Length > 16 ? segments.ElementAtOrDefault(16).Split(separator) : null;
            EventDescriptionFromAutopsy = segments.Length > 17 ? segments.ElementAtOrDefault(17).Split(separator) : null;
            CauseOfDeath = segments.Length > 18 ? segments.ElementAtOrDefault(18).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            PrimaryObserverName = segments.Length > 19 ? segments.ElementAtOrDefault(19).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedPersonName>(x, false)) : null;
            PrimaryObserverAddress = segments.Length > 20 ? segments.ElementAtOrDefault(20).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedAddress>(x, false)) : null;
            PrimaryObserverTelephone = segments.Length > 21 ? segments.ElementAtOrDefault(21).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            PrimaryObserversQualification = segments.ElementAtOrDefault(22);
            ConfirmationProvidedBy = segments.ElementAtOrDefault(23);
            PrimaryObserverAwareDateTime = segments.ElementAtOrDefault(24)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            PrimaryObserversIdentityMayBeDivulged = segments.ElementAtOrDefault(25);
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
                                EventIdentifiersUsed != null ? string.Join(Configuration.FieldRepeatSeparator, EventIdentifiersUsed.Select(x => x.ToDelimitedString())) : null,
                                EventSymptomDiagnosisCode != null ? string.Join(Configuration.FieldRepeatSeparator, EventSymptomDiagnosisCode.Select(x => x.ToDelimitedString())) : null,
                                EventOnsetDateTime.HasValue ? EventOnsetDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EventExacerbationDateTime.HasValue ? EventExacerbationDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EventImprovedDateTime.HasValue ? EventImprovedDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EventEndedDataTime.HasValue ? EventEndedDataTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EventLocationOccurredAddress != null ? string.Join(Configuration.FieldRepeatSeparator, EventLocationOccurredAddress.Select(x => x.ToDelimitedString())) : null,
                                EventQualification != null ? string.Join(Configuration.FieldRepeatSeparator, EventQualification) : null,
                                EventSerious,
                                EventExpected,
                                EventOutcome != null ? string.Join(Configuration.FieldRepeatSeparator, EventOutcome) : null,
                                PatientOutcome,
                                EventDescriptionFromOthers != null ? string.Join(Configuration.FieldRepeatSeparator, EventDescriptionFromOthers) : null,
                                EventDescriptionFromOriginalReporter != null ? string.Join(Configuration.FieldRepeatSeparator, EventDescriptionFromOriginalReporter) : null,
                                EventDescriptionFromPatient != null ? string.Join(Configuration.FieldRepeatSeparator, EventDescriptionFromPatient) : null,
                                EventDescriptionFromPractitioner != null ? string.Join(Configuration.FieldRepeatSeparator, EventDescriptionFromPractitioner) : null,
                                EventDescriptionFromAutopsy != null ? string.Join(Configuration.FieldRepeatSeparator, EventDescriptionFromAutopsy) : null,
                                CauseOfDeath != null ? string.Join(Configuration.FieldRepeatSeparator, CauseOfDeath.Select(x => x.ToDelimitedString())) : null,
                                PrimaryObserverName != null ? string.Join(Configuration.FieldRepeatSeparator, PrimaryObserverName.Select(x => x.ToDelimitedString())) : null,
                                PrimaryObserverAddress != null ? string.Join(Configuration.FieldRepeatSeparator, PrimaryObserverAddress.Select(x => x.ToDelimitedString())) : null,
                                PrimaryObserverTelephone != null ? string.Join(Configuration.FieldRepeatSeparator, PrimaryObserverTelephone.Select(x => x.ToDelimitedString())) : null,
                                PrimaryObserversQualification,
                                ConfirmationProvidedBy,
                                PrimaryObserverAwareDateTime.HasValue ? PrimaryObserverAwareDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                PrimaryObserversIdentityMayBeDivulged
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}