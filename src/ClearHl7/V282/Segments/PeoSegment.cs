using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PEO - Product Experience Observation.
    /// </summary>
    public class PeoSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PeoSegment"/> class.
        /// </summary>
        public PeoSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeoSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public PeoSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "PEO";

        /// <inheritdoc/>
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
        /// <para>Suggested: 0237 Event Qualification -&gt; ClearHl7.Codes.V282.CodeEventQualification</para>
        /// </summary>
        public IEnumerable<string> EventQualification { get; set; }

        /// <summary>
        /// PEO.9 - Event Serious.
        /// <para>Suggested: 0238 Event Seriousness -&gt; ClearHl7.Codes.V282.CodeEventSeriousness</para>
        /// </summary>
        public string EventSerious { get; set; }

        /// <summary>
        /// PEO.10 - Event Expected.
        /// <para>Suggested: 0239 Event Expected -&gt; ClearHl7.Codes.V282.CodeEventExpected</para>
        /// </summary>
        public string EventExpected { get; set; }

        /// <summary>
        /// PEO.11 - Event Outcome.
        /// <para>Suggested: 0240 Event Consequence -&gt; ClearHl7.Codes.V282.CodeEventConsequence</para>
        /// </summary>
        public IEnumerable<string> EventOutcome { get; set; }

        /// <summary>
        /// PEO.12 - Patient Outcome.
        /// <para>Suggested: 0241 Patient Outcome -&gt; ClearHl7.Codes.V282.CodePatientOutcome</para>
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
        /// <para>Suggested: 0242 Primary Observer's Qualification -&gt; ClearHl7.Codes.V282.CodePrimaryObserversQualification</para>
        /// </summary>
        public string PrimaryObserversQualification { get; set; }

        /// <summary>
        /// PEO.23 - Confirmation Provided By.
        /// <para>Suggested: 0242 Primary Observer's Qualification -&gt; ClearHl7.Codes.V282.CodePrimaryObserversQualification</para>
        /// </summary>
        public string ConfirmationProvidedBy { get; set; }

        /// <summary>
        /// PEO.24 - Primary Observer Aware Date/Time.
        /// </summary>
        public DateTime? PrimaryObserverAwareDateTime { get; set; }

        /// <summary>
        /// PEO.25 - Primary Observer's identity May Be Divulged.
        /// <para>Suggested: 0243 Identity May Be Divulged -&gt; ClearHl7.Codes.V282.CodeIdentityMayBeDivulged</para>
        /// </summary>
        public string PrimaryObserversIdentityMayBeDivulged { get; set; }

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

            EventIdentifiersUsed = segments.Length > 1 && segments[1].Length > 0 ? segments[1].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            EventSymptomDiagnosisCode = segments.Length > 2 && segments[2].Length > 0 ? segments[2].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            EventOnsetDateTime = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDateTime() : null;
            EventExacerbationDateTime = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            EventImprovedDateTime = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDateTime() : null;
            EventEndedDataTime = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDateTime() : null;
            EventLocationOccurredAddress = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedAddress>(x, false, seps)) : null;
            EventQualification = segments.Length > 8 && segments[8].Length > 0 ? segments[8].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            EventSerious = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            EventExpected = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
            EventOutcome = segments.Length > 11 && segments[11].Length > 0 ? segments[11].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            PatientOutcome = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
            EventDescriptionFromOthers = segments.Length > 13 && segments[13].Length > 0 ? segments[13].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            EventDescriptionFromOriginalReporter = segments.Length > 14 && segments[14].Length > 0 ? segments[14].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            EventDescriptionFromPatient = segments.Length > 15 && segments[15].Length > 0 ? segments[15].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            EventDescriptionFromPractitioner = segments.Length > 16 && segments[16].Length > 0 ? segments[16].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            EventDescriptionFromAutopsy = segments.Length > 17 && segments[17].Length > 0 ? segments[17].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            CauseOfDeath = segments.Length > 18 && segments[18].Length > 0 ? segments[18].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            PrimaryObserverName = segments.Length > 19 && segments[19].Length > 0 ? segments[19].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedPersonName>(x, false, seps)) : null;
            PrimaryObserverAddress = segments.Length > 20 && segments[20].Length > 0 ? segments[20].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedAddress>(x, false, seps)) : null;
            PrimaryObserverTelephone = segments.Length > 21 && segments[21].Length > 0 ? segments[21].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedTelecommunicationNumber>(x, false, seps)) : null;
            PrimaryObserversQualification = segments.Length > 22 && segments[22].Length > 0 ? segments[22] : null;
            ConfirmationProvidedBy = segments.Length > 23 && segments[23].Length > 0 ? segments[23] : null;
            PrimaryObserverAwareDateTime = segments.Length > 24 && segments[24].Length > 0 ? segments[24].ToNullableDateTime() : null;
            PrimaryObserversIdentityMayBeDivulged = segments.Length > 25 && segments[25].Length > 0 ? segments[25] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 26, Configuration.FieldSeparator),
                                Id,
                                EventIdentifiersUsed != null ? string.Join(Configuration.FieldRepeatSeparator, EventIdentifiersUsed.Select(x => x.ToDelimitedString())) : null,
                                EventSymptomDiagnosisCode != null ? string.Join(Configuration.FieldRepeatSeparator, EventSymptomDiagnosisCode.Select(x => x.ToDelimitedString())) : null,
                                EventOnsetDateTime?.ToHl7DateTimeString(typeof(PeoSegment), nameof(EventOnsetDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                EventExacerbationDateTime?.ToHl7DateTimeString(typeof(PeoSegment), nameof(EventExacerbationDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                EventImprovedDateTime?.ToHl7DateTimeString(typeof(PeoSegment), nameof(EventImprovedDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                EventEndedDataTime?.ToHl7DateTimeString(typeof(PeoSegment), nameof(EventEndedDataTime), Consts.DateTimeFormatPrecisionSecond, culture),
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
                                PrimaryObserverAwareDateTime?.ToHl7DateTimeString(typeof(PeoSegment), nameof(PrimaryObserverAwareDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                PrimaryObserversIdentityMayBeDivulged
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
