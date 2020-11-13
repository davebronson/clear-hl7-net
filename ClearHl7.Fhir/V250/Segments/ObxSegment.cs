using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V250.Types;

namespace ClearHl7.Fhir.V250.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0125</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0078</remarks>
        public IEnumerable<CodedWithExceptions> InterpretationCodes { get; set; }

        /// <summary>
        /// OBX.9 - Probability.
        /// </summary>
        public decimal? Probability { get; set; }

        /// <summary>
        /// OBX.10 - Nature of Abnormal Test.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0080</remarks>
        public IEnumerable<string> NatureOfAbnormalTest { get; set; }

        /// <summary>
        /// OBX.11 - Observation Result Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0085</remarks>
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
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}",
                                Id,
                                SetIdObx.HasValue ? SetIdObx.Value.ToString(culture) : null,
                                ValueType,
                                ObservationIdentifier?.ToDelimitedString(),
                                ObservationSubId,
                                ObservationValue != null ? string.Join("~", ObservationValue) : null,
                                Units?.ToDelimitedString(),
                                ReferencesRange,
                                InterpretationCodes != null ? string.Join("~", InterpretationCodes.Select(x => x.ToDelimitedString())) : null,
                                Probability.HasValue ? Probability.Value.ToString(Consts.NumericFormat, culture) : null,
                                NatureOfAbnormalTest != null ? string.Join("~", NatureOfAbnormalTest) : null,
                                ObservationResultStatus,
                                EffectiveDateOfReferenceRange.HasValue ? EffectiveDateOfReferenceRange.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                UserDefinedAccessChecks,
                                DateTimeOfTheObservation.HasValue ? DateTimeOfTheObservation.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ProducersId?.ToDelimitedString(),
                                ResponsibleObserver != null ? string.Join("~", ResponsibleObserver.Select(x => x.ToDelimitedString())) : null,
                                ObservationMethod != null ? string.Join("~", ObservationMethod.Select(x => x.ToDelimitedString())) : null,
                                EquipmentInstanceIdentifier != null ? string.Join("~", EquipmentInstanceIdentifier.Select(x => x.ToDelimitedString())) : null,
                                DateTimeOfTheAnalysis.HasValue ? DateTimeOfTheAnalysis.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null
                                ).TrimEnd('|');
        }
    }
}