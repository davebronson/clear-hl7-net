using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment OBX - Observation Result.
    /// </summary>
    public class ObxSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "OBX";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// OBX.1 - Set ID - OBX.
        /// </summary>
        public uint? SetIdObx { get; set; }

        /// <summary>
        /// OBX.2 - Value Type.
        /// <para>Suggested: 0125 Value Type -&gt; ClearHl7.Fhir.Codes.V280.CodeValueType</para>
        /// </summary>
        public string ValueType { get; set; }

        /// <summary>
        /// OBX.3 - Observation Identifier.
        /// </summary>
        public CodedWithExceptions ObservationIdentifier { get; set; }

        /// <summary>
        /// OBX.4 - Observation Sub-ID.
        /// </summary>
        public string ObservationSubId { get; set; }

        /// <summary>
        /// OBX.5 - Observation Value.
        /// </summary>
        public IEnumerable<string> ObservationValue { get; set; }

        /// <summary>
        /// OBX.6 - Units.
        /// </summary>
        public CodedWithExceptions Units { get; set; }

        /// <summary>
        /// OBX.7 - References Range.
        /// </summary>
        public string ReferencesRange { get; set; }

        /// <summary>
        /// OBX.8 - Interpretation Codes.
        /// <para>Suggested: 0078 Interpretation Codes -&gt; ClearHl7.Fhir.Codes.V280.CodeInterpretationCodes</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> InterpretationCodes { get; set; }

        /// <summary>
        /// OBX.9 - Probability.
        /// </summary>
        public decimal? Probability { get; set; }

        /// <summary>
        /// OBX.10 - Nature of Abnormal Test.
        /// <para>Suggested: 0080 Nature Of Abnormal Testing -&gt; ClearHl7.Fhir.Codes.V280.CodeNatureOfAbnormalTesting</para>
        /// </summary>
        public IEnumerable<string> NatureOfAbnormalTest { get; set; }

        /// <summary>
        /// OBX.11 - Observation Result Status.
        /// <para>Suggested: 0085 Observation Result Status Codes Interpretation -&gt; ClearHl7.Fhir.Codes.V280.CodeObservationResultStatusCodesInterpretation</para>
        /// </summary>
        public string ObservationResultStatus { get; set; }

        /// <summary>
        /// OBX.12 - Effective Date of Reference Range.
        /// </summary>
        public DateTime? EffectiveDateOfReferenceRange { get; set; }

        /// <summary>
        /// OBX.13 - User Defined Access Checks.
        /// </summary>
        public string UserDefinedAccessChecks { get; set; }

        /// <summary>
        /// OBX.14 - Date/Time of the Observation.
        /// </summary>
        public DateTime? DateTimeOfTheObservation { get; set; }

        /// <summary>
        /// OBX.15 - Producer's ID.
        /// </summary>
        public CodedWithExceptions ProducersId { get; set; }

        /// <summary>
        /// OBX.16 - Responsible Observer.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> ResponsibleObserver { get; set; }

        /// <summary>
        /// OBX.17 - Observation Method.
        /// </summary>
        public IEnumerable<CodedWithExceptions> ObservationMethod { get; set; }

        /// <summary>
        /// OBX.18 - Equipment Instance Identifier.
        /// </summary>
        public IEnumerable<EntityIdentifier> EquipmentInstanceIdentifier { get; set; }

        /// <summary>
        /// OBX.19 - Date/Time of the Analysis.
        /// </summary>
        public DateTime? DateTimeOfTheAnalysis { get; set; }

        /// <summary>
        /// OBX.20 - Observation Site.
        /// <para>Suggested: 0163 Body Site -&gt; ClearHl7.Fhir.Codes.V280.CodeBodySite</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ObservationSite { get; set; }

        /// <summary>
        /// OBX.21 - Observation Instance Identifier.
        /// </summary>
        public EntityIdentifier ObservationInstanceIdentifier { get; set; }

        /// <summary>
        /// OBX.22 - Mood Code.
        /// <para>Suggested: 0725 Mood Codes -&gt; ClearHl7.Fhir.Codes.V280.CodeMoodCodes</para>
        /// </summary>
        public CodedWithNoExceptions MoodCode { get; set; }

        /// <summary>
        /// OBX.23 - Performing Organization Name.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations PerformingOrganizationName { get; set; }

        /// <summary>
        /// OBX.24 - Performing Organization Address.
        /// </summary>
        public ExtendedAddress PerformingOrganizationAddress { get; set; }

        /// <summary>
        /// OBX.25 - Performing Organization Medical Director.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons PerformingOrganizationMedicalDirector { get; set; }

        /// <summary>
        /// OBX.26 - Patient Results Release Category.
        /// <para>Suggested: 0909 Patient Results Release Categorization Scheme -&gt; ClearHl7.Fhir.Codes.V280.CodePatientResultsReleaseCategorizationScheme</para>
        /// </summary>
        public string PatientResultsReleaseCategory { get; set; }

        /// <summary>
        /// OBX.27 - Root Cause.
        /// <para>Suggested: 0914 Root Cause -&gt; ClearHl7.Fhir.Codes.V280.CodeRootCause</para>
        /// </summary>
        public CodedWithExceptions RootCause { get; set; }

        /// <summary>
        /// OBX.28 - Local Process Control.
        /// <para>Suggested: 0915 Local Process Control</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> LocalProcessControl { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 29, Configuration.FieldSeparator),
                                Id,
                                SetIdObx.HasValue ? SetIdObx.Value.ToString(culture) : null,
                                ValueType,
                                ObservationIdentifier?.ToDelimitedString(),
                                ObservationSubId,
                                ObservationValue != null ? string.Join(Configuration.FieldRepeatSeparator, ObservationValue) : null,
                                Units?.ToDelimitedString(),
                                ReferencesRange,
                                InterpretationCodes != null ? string.Join(Configuration.FieldRepeatSeparator, InterpretationCodes.Select(x => x.ToDelimitedString())) : null,
                                Probability.HasValue ? Probability.Value.ToString(Consts.NumericFormat, culture) : null,
                                NatureOfAbnormalTest != null ? string.Join(Configuration.FieldRepeatSeparator, NatureOfAbnormalTest) : null,
                                ObservationResultStatus,
                                EffectiveDateOfReferenceRange.HasValue ? EffectiveDateOfReferenceRange.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                UserDefinedAccessChecks,
                                DateTimeOfTheObservation.HasValue ? DateTimeOfTheObservation.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ProducersId?.ToDelimitedString(),
                                ResponsibleObserver != null ? string.Join(Configuration.FieldRepeatSeparator, ResponsibleObserver.Select(x => x.ToDelimitedString())) : null,
                                ObservationMethod != null ? string.Join(Configuration.FieldRepeatSeparator, ObservationMethod.Select(x => x.ToDelimitedString())) : null,
                                EquipmentInstanceIdentifier != null ? string.Join(Configuration.FieldRepeatSeparator, EquipmentInstanceIdentifier.Select(x => x.ToDelimitedString())) : null,
                                DateTimeOfTheAnalysis.HasValue ? DateTimeOfTheAnalysis.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ObservationSite != null ? string.Join(Configuration.FieldRepeatSeparator, ObservationSite.Select(x => x.ToDelimitedString())) : null,
                                ObservationInstanceIdentifier?.ToDelimitedString(),
                                MoodCode?.ToDelimitedString(),
                                PerformingOrganizationName?.ToDelimitedString(),
                                PerformingOrganizationAddress?.ToDelimitedString(),
                                PerformingOrganizationMedicalDirector?.ToDelimitedString(),
                                PatientResultsReleaseCategory,
                                RootCause?.ToDelimitedString(),
                                LocalProcessControl != null ? string.Join(Configuration.FieldRepeatSeparator, LocalProcessControl.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}