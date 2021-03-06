﻿using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment OM3 - Categorical Service Test Observation.
    /// </summary>
    public class Om3Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "OM3";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// OM3.1 - Sequence Number - Test/Observation Master File.
        /// </summary>
        public decimal? SequenceNumberTestObservationMasterFile { get; set; }

        /// <summary>
        /// OM3.2 - Preferred Coding System.
        /// </summary>
        public CodedWithExceptions PreferredCodingSystem { get; set; }

        /// <summary>
        /// OM3.3 - Valid Coded "Answers".
        /// </summary>
        public IEnumerable<CodedWithExceptions> ValidCodedAnswers { get; set; }

        /// <summary>
        /// OM3.4 - Normal Text/Codes for Categorical Observations.
        /// </summary>
        public IEnumerable<CodedWithExceptions> NormalTextCodesForCategoricalObservations { get; set; }

        /// <summary>
        /// OM3.5 - Abnormal Text/Codes for Categorical Observations.
        /// </summary>
        public IEnumerable<CodedWithExceptions> AbnormalTextCodesForCategoricalObservations { get; set; }

        /// <summary>
        /// OM3.6 - Critical Text/Codes for Categorical Observations.
        /// </summary>
        public IEnumerable<CodedWithExceptions> CriticalTextCodesForCategoricalObservations { get; set; }

        /// <summary>
        /// OM3.7 - Value Type.
        /// <para>Suggested: 0125 Value Type -&gt; ClearHl7.Codes.V280.CodeValueType</para>
        /// </summary>
        public string ValueType { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 8, Configuration.FieldSeparator),
                                Id,
                                SequenceNumberTestObservationMasterFile.HasValue ? SequenceNumberTestObservationMasterFile.Value.ToString(Consts.NumericFormat, culture) : null,
                                PreferredCodingSystem?.ToDelimitedString(),
                                ValidCodedAnswers != null ? string.Join(Configuration.FieldRepeatSeparator, ValidCodedAnswers.Select(x => x.ToDelimitedString())) : null,
                                NormalTextCodesForCategoricalObservations != null ? string.Join(Configuration.FieldRepeatSeparator, NormalTextCodesForCategoricalObservations.Select(x => x.ToDelimitedString())) : null,
                                AbnormalTextCodesForCategoricalObservations != null ? string.Join(Configuration.FieldRepeatSeparator, AbnormalTextCodesForCategoricalObservations.Select(x => x.ToDelimitedString())) : null,
                                CriticalTextCodesForCategoricalObservations != null ? string.Join(Configuration.FieldRepeatSeparator, CriticalTextCodesForCategoricalObservations.Select(x => x.ToDelimitedString())) : null,
                                ValueType
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}