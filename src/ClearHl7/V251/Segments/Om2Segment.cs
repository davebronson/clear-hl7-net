using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V251.Types;

namespace ClearHl7.V251.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment OM2 - Numeric Observation.
    /// </summary>
    public class Om2Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "OM2";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// OM2.1 - Sequence Number - Test/Observation Master File.
        /// </summary>
        public decimal? SequenceNumberTestObservationMasterFile { get; set; }

        /// <summary>
        /// OM2.2 - Units of Measure.
        /// </summary>
        public CodedElement UnitsOfMeasure { get; set; }

        /// <summary>
        /// OM2.3 - Range of Decimal Precision.
        /// </summary>
        public IEnumerable<decimal> RangeOfDecimalPrecision { get; set; }

        /// <summary>
        /// OM2.4 - Corresponding SI Units of Measure.
        /// </summary>
        public CodedElement CorrespondingSiUnitsOfMeasure { get; set; }

        /// <summary>
        /// OM2.5 - SI Conversion Factor.
        /// </summary>
        public Text SiConversionFactor { get; set; }

        /// <summary>
        /// OM2.6 - Reference (Normal) Range for Ordinal and Continuous Observations.
        /// </summary>
        public IEnumerable<ReferenceRange> ReferenceNormalRangeForOrdinalAndContinuousObservations { get; set; }

        /// <summary>
        /// OM2.7 - Critical Range for Ordinal and Continuous Observations.
        /// </summary>
        public IEnumerable<ReferenceRange> CriticalRangeForOrdinalAndContinuousObservations { get; set; }

        /// <summary>
        /// OM2.8 - Absolute Range for Ordinal and Continuous Observations.
        /// </summary>
        public ReferenceRange AbsoluteRangeForOrdinalAndContinuousObservations { get; set; }

        /// <summary>
        /// OM2.9 - Delta Check Criteria.
        /// </summary>
        public IEnumerable<Delta> DeltaCheckCriteria { get; set; }

        /// <summary>
        /// OM2.10 - Minimum Meaningful Increments.
        /// </summary>
        public decimal? MinimumMeaningfulIncrements { get; set; }

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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SequenceNumberTestObservationMasterFile = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            UnitsOfMeasure = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[2], false) : null;
            RangeOfDecimalPrecision = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(separator).Select(x => x.ToDecimal()) : null;
            CorrespondingSiUnitsOfMeasure = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[4], false) : null;
            SiConversionFactor = segments.Length > 5 && segments[5].Length > 0 ? TypeHelper.Deserialize<Text>(segments[5], false) : null;
            ReferenceNormalRangeForOrdinalAndContinuousObservations = segments.Length > 6 && segments[6].Length > 0 ? segments[6].Split(separator).Select(x => TypeHelper.Deserialize<ReferenceRange>(x, false)) : null;
            CriticalRangeForOrdinalAndContinuousObservations = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(separator).Select(x => TypeHelper.Deserialize<ReferenceRange>(x, false)) : null;
            AbsoluteRangeForOrdinalAndContinuousObservations = segments.Length > 8 && segments[8].Length > 0 ? TypeHelper.Deserialize<ReferenceRange>(segments[8], false) : null;
            DeltaCheckCriteria = segments.Length > 9 && segments[9].Length > 0 ? segments[9].Split(separator).Select(x => TypeHelper.Deserialize<Delta>(x, false)) : null;
            MinimumMeaningfulIncrements = segments.Length > 10 && segments[10].Length > 0 ? segments[10].ToNullableDecimal() : null;
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
                                StringHelper.StringFormatSequence(0, 11, Configuration.FieldSeparator),
                                Id,
                                SequenceNumberTestObservationMasterFile.HasValue ? SequenceNumberTestObservationMasterFile.Value.ToString(Consts.NumericFormat, culture) : null,
                                UnitsOfMeasure?.ToDelimitedString(),
                                RangeOfDecimalPrecision != null ? string.Join(Configuration.FieldRepeatSeparator, RangeOfDecimalPrecision.Select(x => x.ToString(Consts.NumericFormat, culture))) : null,
                                CorrespondingSiUnitsOfMeasure?.ToDelimitedString(),
                                SiConversionFactor?.ToDelimitedString(),
                                ReferenceNormalRangeForOrdinalAndContinuousObservations != null ? string.Join(Configuration.FieldRepeatSeparator, ReferenceNormalRangeForOrdinalAndContinuousObservations.Select(x => x.ToDelimitedString())) : null,
                                CriticalRangeForOrdinalAndContinuousObservations != null ? string.Join(Configuration.FieldRepeatSeparator, CriticalRangeForOrdinalAndContinuousObservations.Select(x => x.ToDelimitedString())) : null,
                                AbsoluteRangeForOrdinalAndContinuousObservations?.ToDelimitedString(),
                                DeltaCheckCriteria != null ? string.Join(Configuration.FieldRepeatSeparator, DeltaCheckCriteria.Select(x => x.ToDelimitedString())) : null,
                                MinimumMeaningfulIncrements.HasValue ? MinimumMeaningfulIncrements.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}