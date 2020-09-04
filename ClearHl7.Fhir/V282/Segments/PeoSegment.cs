using System;

namespace ClearHl7.Fhir.V282.Segments
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
        
        ///// <summary>
        ///// PEO.1 - Event Identifiers Used.
        ///// </summary>
        //public EventIdentifiersUsed { get; set; }

        ///// <summary>
        ///// PEO.2 - Event Symptom/Diagnosis Code.
        ///// </summary>
        //public EventSymptomDiagnosisCode { get; set; }

        ///// <summary>
        ///// PEO.3 - Event Onset Date/Time.
        ///// </summary>
        //public EventOnsetDateTime { get; set; }

        ///// <summary>
        ///// PEO.4 - Event Exacerbation Date/Time.
        ///// </summary>
        //public EventExacerbationDateTime { get; set; }

        ///// <summary>
        ///// PEO.5 - Event Improved Date/Time.
        ///// </summary>
        //public EventImprovedDateTime { get; set; }

        ///// <summary>
        ///// PEO.6 - Event Ended Data/Time.
        ///// </summary>
        //public EventEndedDataTime { get; set; }

        ///// <summary>
        ///// PEO.7 - Event Location Occurred Address.
        ///// </summary>
        //public EventLocationOccurredAddress { get; set; }

        ///// <summary>
        ///// PEO.8 - Event Qualification.
        ///// </summary>
        //public EventQualification { get; set; }

        ///// <summary>
        ///// PEO.9 - Event Serious.
        ///// </summary>
        //public EventSerious { get; set; }

        ///// <summary>
        ///// PEO.10 - Event Expected.
        ///// </summary>
        //public EventExpected { get; set; }

        ///// <summary>
        ///// PEO.11 - Event Outcome.
        ///// </summary>
        //public EventOutcome { get; set; }

        ///// <summary>
        ///// PEO.12 - Patient Outcome.
        ///// </summary>
        //public PatientOutcome { get; set; }

        ///// <summary>
        ///// PEO.13 - Event Description from Others.
        ///// </summary>
        //public EventDescriptionFromOthers { get; set; }

        ///// <summary>
        ///// PEO.14 - Event Description from Original Reporter.
        ///// </summary>
        //public EventDescriptionFromOriginalReporter { get; set; }

        ///// <summary>
        ///// PEO.15 - Event Description from Patient.
        ///// </summary>
        //public EventDescriptionFromPatient { get; set; }

        ///// <summary>
        ///// PEO.16 - Event Description from Practitioner.
        ///// </summary>
        //public EventDescriptionFromPractitioner { get; set; }

        ///// <summary>
        ///// PEO.17 - Event Description from Autopsy.
        ///// </summary>
        //public EventDescriptionFromAutopsy { get; set; }

        ///// <summary>
        ///// PEO.18 - Cause Of Death.
        ///// </summary>
        //public CauseOfDeath { get; set; }

        ///// <summary>
        ///// PEO.19 - Primary Observer Name.
        ///// </summary>
        //public PrimaryObserverName { get; set; }

        ///// <summary>
        ///// PEO.20 - Primary Observer Address.
        ///// </summary>
        //public PrimaryObserverAddress { get; set; }

        ///// <summary>
        ///// PEO.21 - Primary Observer Telephone.
        ///// </summary>
        //public PrimaryObserverTelephone { get; set; }

        ///// <summary>
        ///// PEO.22 - Primary Observer's Qualification.
        ///// </summary>
        //public PrimaryObserversQualification { get; set; }

        ///// <summary>
        ///// PEO.23 - Confirmation Provided By.
        ///// </summary>
        //public ConfirmationProvidedBy { get; set; }

        ///// <summary>
        ///// PEO.24 - Primary Observer Aware Date/Time.
        ///// </summary>
        //public PrimaryObserverAwareDateTime { get; set; }

        ///// <summary>
        ///// PEO.25 - Primary Observer's identity May Be Divulged.
        ///// </summary>
        //public PrimaryObserversIdentityMayBeDivulged { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}"
                                ).TrimEnd('|');
        }
    }
}