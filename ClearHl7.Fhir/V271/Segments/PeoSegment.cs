using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V271.Types;

namespace ClearHl7.Fhir.V271.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0237</remarks>
        public IEnumerable<string> EventQualification { get; set; }

        /// <summary>
        /// PEO.9 - Event Serious.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0238</remarks>
        public string EventSerious { get; set; }

        /// <summary>
        /// PEO.10 - Event Expected.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0239</remarks>
        public string EventExpected { get; set; }

        /// <summary>
        /// PEO.11 - Event Outcome.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0240</remarks>
        public IEnumerable<string> EventOutcome { get; set; }

        /// <summary>
        /// PEO.12 - Patient Outcome.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0241</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0242</remarks>
        public string PrimaryObserversQualification { get; set; }

        /// <summary>
        /// PEO.23 - Confirmation Provided By.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0242</remarks>
        public string ConfirmationProvidedBy { get; set; }

        /// <summary>
        /// PEO.24 - Primary Observer Aware Date/Time.
        /// </summary>
        public DateTime? PrimaryObserverAwareDateTime { get; set; }

        /// <summary>
        /// PEO.25 - Primary Observer's identity May Be Divulged.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0243</remarks>
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
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}",
                                Id,
                                EventIdentifiersUsed != null ? string.Join("~", EventIdentifiersUsed.Select(x => x.ToDelimitedString())) : null,
                                EventSymptomDiagnosisCode != null ? string.Join("~", EventSymptomDiagnosisCode.Select(x => x.ToDelimitedString())) : null,
                                EventOnsetDateTime.HasValue ? EventOnsetDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EventExacerbationDateTime.HasValue ? EventExacerbationDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EventImprovedDateTime.HasValue ? EventImprovedDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EventEndedDataTime.HasValue ? EventEndedDataTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EventLocationOccurredAddress != null ? string.Join("~", EventLocationOccurredAddress.Select(x => x.ToDelimitedString())) : null,
                                EventQualification != null ? string.Join("~", EventQualification) : null,
                                EventSerious,
                                EventExpected,
                                EventOutcome != null ? string.Join("~", EventOutcome) : null,
                                PatientOutcome,
                                EventDescriptionFromOthers != null ? string.Join("~", EventDescriptionFromOthers) : null,
                                EventDescriptionFromOriginalReporter != null ? string.Join("~", EventDescriptionFromOriginalReporter) : null,
                                EventDescriptionFromPatient != null ? string.Join("~", EventDescriptionFromPatient) : null,
                                EventDescriptionFromPractitioner != null ? string.Join("~", EventDescriptionFromPractitioner) : null,
                                EventDescriptionFromAutopsy != null ? string.Join("~", EventDescriptionFromAutopsy) : null,
                                CauseOfDeath != null ? string.Join("~", CauseOfDeath.Select(x => x.ToDelimitedString())) : null,
                                PrimaryObserverName != null ? string.Join("~", PrimaryObserverName.Select(x => x.ToDelimitedString())) : null,
                                PrimaryObserverAddress != null ? string.Join("~", PrimaryObserverAddress.Select(x => x.ToDelimitedString())) : null,
                                PrimaryObserverTelephone != null ? string.Join("~", PrimaryObserverTelephone.Select(x => x.ToDelimitedString())) : null,
                                PrimaryObserversQualification,
                                ConfirmationProvidedBy,
                                PrimaryObserverAwareDateTime.HasValue ? PrimaryObserverAwareDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                PrimaryObserversIdentityMayBeDivulged
                                ).TrimEnd('|');
        }
    }
}