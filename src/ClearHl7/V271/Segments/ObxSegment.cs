using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
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
        /// <para>Suggested: 0125 Value Type -&gt; ClearHl7.Codes.V271.CodeValueType</para>
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
        /// </summary>
        public IEnumerable<CodedWithExceptions> InterpretationCodes { get; set; }

        /// <summary>
        /// OBX.9 - Probability.
        /// </summary>
        public decimal? Probability { get; set; }

        /// <summary>
        /// OBX.10 - Nature of Abnormal Test.
        /// <para>Suggested: 0080 Nature Of Abnormal Testing -&gt; ClearHl7.Codes.V271.CodeNatureOfAbnormalTesting</para>
        /// </summary>
        public IEnumerable<string> NatureOfAbnormalTest { get; set; }

        /// <summary>
        /// OBX.11 - Observation Result Status.
        /// <para>Suggested: 0085 Observation Result Status Codes Interpretation -&gt; ClearHl7.Codes.V271.CodeObservationResultStatusCodesInterpretation</para>
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
        /// <para>Suggested: 0163 Body Site -&gt; ClearHl7.Codes.V271.CodeBodySite</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ObservationSite { get; set; }

        /// <summary>
        /// OBX.21 - Observation Instance Identifier.
        /// </summary>
        public EntityIdentifier ObservationInstanceIdentifier { get; set; }

        /// <summary>
        /// OBX.22 - Mood Code.
        /// <para>Suggested: 0725 Mood Codes -&gt; ClearHl7.Codes.V271.CodeMoodCodes</para>
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
        /// <para>Suggested: 0909 Patient Results Release Categorization Scheme -&gt; ClearHl7.Codes.V271.CodePatientResultsReleaseCategorizationScheme</para>
        /// </summary>
        public string PatientResultsReleaseCategory { get; set; }

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

            SetIdObx = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            ValueType = segments.ElementAtOrDefault(2);
            ObservationIdentifier = segments.Length > 3 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(3), false) : null;
            ObservationSubId = segments.ElementAtOrDefault(4);
            ObservationValue = segments.Length > 5 ? segments.ElementAtOrDefault(5).Split(separator) : null;
            Units = segments.Length > 6 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(6), false) : null;
            ReferencesRange = segments.ElementAtOrDefault(7);
            InterpretationCodes = segments.Length > 8 ? segments.ElementAtOrDefault(8).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            Probability = segments.ElementAtOrDefault(9)?.ToNullableDecimal();
            NatureOfAbnormalTest = segments.Length > 10 ? segments.ElementAtOrDefault(10).Split(separator) : null;
            ObservationResultStatus = segments.ElementAtOrDefault(11);
            EffectiveDateOfReferenceRange = segments.ElementAtOrDefault(12)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            UserDefinedAccessChecks = segments.ElementAtOrDefault(13);
            DateTimeOfTheObservation = segments.ElementAtOrDefault(14)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            ProducersId = segments.Length > 15 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(15), false) : null;
            ResponsibleObserver = segments.Length > 16 ? segments.ElementAtOrDefault(16).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            ObservationMethod = segments.Length > 17 ? segments.ElementAtOrDefault(17).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            EquipmentInstanceIdentifier = segments.Length > 18 ? segments.ElementAtOrDefault(18).Split(separator).Select(x => TypeHelper.Deserialize<EntityIdentifier>(x, false)) : null;
            DateTimeOfTheAnalysis = segments.ElementAtOrDefault(19)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            ObservationSite = segments.Length > 20 ? segments.ElementAtOrDefault(20).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            ObservationInstanceIdentifier = segments.Length > 21 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(21), false) : null;
            MoodCode = segments.Length > 22 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(22), false) : null;
            PerformingOrganizationName = segments.Length > 23 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments.ElementAtOrDefault(23), false) : null;
            PerformingOrganizationAddress = segments.Length > 24 ? TypeHelper.Deserialize<ExtendedAddress>(segments.ElementAtOrDefault(24), false) : null;
            PerformingOrganizationMedicalDirector = segments.Length > 25 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments.ElementAtOrDefault(25), false) : null;
            PatientResultsReleaseCategory = segments.ElementAtOrDefault(26);
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
                                StringHelper.StringFormatSequence(0, 27, Configuration.FieldSeparator),
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
                                PatientResultsReleaseCategory
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}