using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
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
        /// <para>Suggested: 0125 Value Type -&gt; ClearHl7.Codes.V230.CodeValueType</para>
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
        public IEnumerable<string> ObservationValue { get; set; }

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
        /// <para>Suggested: 0078 Interpretation Codes -&gt; ClearHl7.Codes.V230.CodeInterpretationCodes</para>
        /// </summary>
        public IEnumerable<string> InterpretationCodes { get; set; }

        /// <summary>
        /// OBX.9 - Probability.
        /// </summary>
        public decimal? Probability { get; set; }

        /// <summary>
        /// OBX.10 - Nature of Abnormal Test.
        /// <para>Suggested: 0080 Nature Of Abnormal Testing -&gt; ClearHl7.Codes.V230.CodeNatureOfAbnormalTesting</para>
        /// </summary>
        public IEnumerable<string> NatureOfAbnormalTest { get; set; }

        /// <summary>
        /// OBX.11 - Observation Result Status.
        /// <para>Suggested: 0085 Observation Result Status Codes Interpretation -&gt; ClearHl7.Codes.V230.CodeObservationResultStatusCodesInterpretation</para>
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
            ObservationIdentifier = segments.Length > 3 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(3), false) : null;
            ObservationSubId = segments.ElementAtOrDefault(4);
            ObservationValue = segments.Length > 5 ? segments.ElementAtOrDefault(5).Split(separator) : null;
            Units = segments.Length > 6 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(6), false) : null;
            ReferencesRange = segments.ElementAtOrDefault(7);
            InterpretationCodes = segments.Length > 8 ? segments.ElementAtOrDefault(8).Split(separator) : null;
            Probability = segments.ElementAtOrDefault(9)?.ToNullableDecimal();
            NatureOfAbnormalTest = segments.Length > 10 ? segments.ElementAtOrDefault(10).Split(separator) : null;
            ObservationResultStatus = segments.ElementAtOrDefault(11);
            EffectiveDateOfReferenceRange = segments.ElementAtOrDefault(12)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            UserDefinedAccessChecks = segments.ElementAtOrDefault(13);
            DateTimeOfTheObservation = segments.ElementAtOrDefault(14)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            ProducersId = segments.Length > 15 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(15), false) : null;
            ResponsibleObserver = segments.Length > 16 ? segments.ElementAtOrDefault(16).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            ObservationMethod = segments.Length > 17 ? segments.ElementAtOrDefault(17).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
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
                                StringHelper.StringFormatSequence(0, 18, Configuration.FieldSeparator),
                                Id,
                                SetIdObx.HasValue ? SetIdObx.Value.ToString(culture) : null,
                                ValueType,
                                ObservationIdentifier?.ToDelimitedString(),
                                ObservationSubId,
                                ObservationValue != null ? string.Join(Configuration.FieldRepeatSeparator, ObservationValue) : null,
                                Units?.ToDelimitedString(),
                                ReferencesRange,
                                InterpretationCodes != null ? string.Join(Configuration.FieldRepeatSeparator, InterpretationCodes) : null,
                                Probability.HasValue ? Probability.Value.ToString(Consts.NumericFormat, culture) : null,
                                NatureOfAbnormalTest != null ? string.Join(Configuration.FieldRepeatSeparator, NatureOfAbnormalTest) : null,
                                ObservationResultStatus,
                                EffectiveDateOfReferenceRange.HasValue ? EffectiveDateOfReferenceRange.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                UserDefinedAccessChecks,
                                DateTimeOfTheObservation.HasValue ? DateTimeOfTheObservation.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ProducersId?.ToDelimitedString(),
                                ResponsibleObserver != null ? string.Join(Configuration.FieldRepeatSeparator, ResponsibleObserver.Select(x => x.ToDelimitedString())) : null,
                                ObservationMethod != null ? string.Join(Configuration.FieldRepeatSeparator, ObservationMethod.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}