﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V251.Types;

namespace ClearHl7.V251.Segments
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
        /// <para>Suggested: 0125 Value Type -&gt; ClearHl7.Codes.V251.CodeValueType</para>
        /// </summary>
        public string ValueType { get; set; }

        /// <summary>
        /// OBX.3 - Observation Identifier.
        /// </summary>
        public CodedElement ObservationIdentifier { get; set; }

        /// <summary>
        /// OBX.4 - Observation Sub-ID.
        /// </summary>
        public string ObservationSubId { get; set; }

        /// <summary>
        /// OBX.5 - Observation Value.
        /// </summary>
        public ChannelDefinition ObservationValue { get; set; }

        /// <summary>
        /// OBX.6 - Units.
        /// </summary>
        public CodedElement Units { get; set; }

        /// <summary>
        /// OBX.7 - References Range.
        /// </summary>
        public string ReferencesRange { get; set; }

        /// <summary>
        /// OBX.8 - Interpretation Codes.
        /// <para>Suggested: 0078 Interpretation Codes -&gt; ClearHl7.Codes.V251.CodeInterpretationCodes</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> InterpretationCodes { get; set; }

        /// <summary>
        /// OBX.9 - Probability.
        /// </summary>
        public decimal? Probability { get; set; }

        /// <summary>
        /// OBX.10 - Nature of Abnormal Test.
        /// <para>Suggested: 0080 Nature Of Abnormal Testing -&gt; ClearHl7.Codes.V251.CodeNatureOfAbnormalTesting</para>
        /// </summary>
        public IEnumerable<string> NatureOfAbnormalTest { get; set; }

        /// <summary>
        /// OBX.11 - Observation Result Status.
        /// <para>Suggested: 0085 Observation Result Status Codes Interpretation -&gt; ClearHl7.Codes.V251.CodeObservationResultStatusCodesInterpretation</para>
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
        public CodedElement ProducersId { get; set; }

        /// <summary>
        /// OBX.16 - Responsible Observer.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> ResponsibleObserver { get; set; }

        /// <summary>
        /// OBX.17 - Observation Method.
        /// </summary>
        public IEnumerable<CodedElement> ObservationMethod { get; set; }

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
        /// </summary>
        public IEnumerable<CodedWithExceptions> ObservationSite { get; set; }

        /// <summary>
        /// OBX.21 - Observation Instance Identifier.
        /// </summary>
        public EntityIdentifier ObservationInstanceIdentifier { get; set; }

        /// <summary>
        /// OBX.22 - Mood Code.
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
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        internal void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);
            
            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdObx = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            ValueType = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            ObservationIdentifier = segments.Length > 3 && segments[3].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[3], false) : null;
            ObservationSubId = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            ObservationValue = segments.Length > 5 && segments[5].Length > 0 ? TypeHelper.Deserialize<ChannelDefinition>(segments[5], false) : null;
            Units = segments.Length > 6 && segments[6].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[6], false) : null;
            ReferencesRange = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            InterpretationCodes = segments.Length > 8 && segments[8].Length > 0 ? segments[8].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            Probability = segments.Length > 9 && segments[9].Length > 0 ? segments[9].ToNullableDecimal() : null;
            NatureOfAbnormalTest = segments.Length > 10 && segments[10].Length > 0 ? segments[10].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            ObservationResultStatus = segments.Length > 11 && segments[11].Length > 0 ? segments[11] : null;
            EffectiveDateOfReferenceRange = segments.Length > 12 && segments[12].Length > 0 ? segments[12].ToNullableDateTime() : null;
            UserDefinedAccessChecks = segments.Length > 13 && segments[13].Length > 0 ? segments[13] : null;
            DateTimeOfTheObservation = segments.Length > 14 && segments[14].Length > 0 ? segments[14].ToNullableDateTime() : null;
            ProducersId = segments.Length > 15 && segments[15].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[15], false) : null;
            ResponsibleObserver = segments.Length > 16 && segments[16].Length > 0 ? segments[16].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            ObservationMethod = segments.Length > 17 && segments[17].Length > 0 ? segments[17].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            EquipmentInstanceIdentifier = segments.Length > 18 && segments[18].Length > 0 ? segments[18].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<EntityIdentifier>(x, false)) : null;
            DateTimeOfTheAnalysis = segments.Length > 19 && segments[19].Length > 0 ? segments[19].ToNullableDateTime() : null;
            ObservationSite = segments.Length > 20 && segments[20].Length > 0 ? segments[20].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            ObservationInstanceIdentifier = segments.Length > 21 && segments[21].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[21], false) : null;
            MoodCode = segments.Length > 22 && segments[22].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[22], false) : null;
            PerformingOrganizationName = segments.Length > 23 && segments[23].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments[23], false) : null;
            PerformingOrganizationAddress = segments.Length > 24 && segments[24].Length > 0 ? TypeHelper.Deserialize<ExtendedAddress>(segments[24], false) : null;
            PerformingOrganizationMedicalDirector = segments.Length > 25 && segments[25].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[25], false) : null;
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
                                SetIdObx.HasValue ? SetIdObx.Value.ToString(culture) : null,
                                ValueType,
                                ObservationIdentifier?.ToDelimitedString(),
                                ObservationSubId,
                                ObservationValue?.ToDelimitedString(),
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
                                PerformingOrganizationMedicalDirector?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}