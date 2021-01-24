using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V270.Types;

namespace ClearHl7.V270.Segments
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
        public CodedWithExceptions UnitsOfMeasure { get; set; }

        /// <summary>
        /// OM2.3 - Range of Decimal Precision.
        /// </summary>
        public IEnumerable<decimal> RangeOfDecimalPrecision { get; set; }

        /// <summary>
        /// OM2.4 - Corresponding SI Units of Measure.
        /// </summary>
        public CodedWithExceptions CorrespondingSiUnitsOfMeasure { get; set; }

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
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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