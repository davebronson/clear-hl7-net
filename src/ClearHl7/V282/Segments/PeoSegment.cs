﻿using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
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