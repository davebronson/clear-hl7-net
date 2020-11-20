using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V240.Types;

namespace ClearHl7.Fhir.V240.Segments
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
        public CodedElement PreferredCodingSystem { get; set; }

        /// <summary>
        /// OM3.3 - Valid Coded "Answers".
        /// </summary>
        public CodedElement ValidCodedAnswers { get; set; }

        /// <summary>
        /// OM3.4 - Normal Text/Codes for Categorical Observations.
        /// </summary>
        public IEnumerable<CodedElement> NormalTextCodesForCategoricalObservations { get; set; }

        /// <summary>
        /// OM3.5 - Abnormal Text/Codes for Categorical Observations.
        /// </summary>
        public IEnumerable<CodedElement> AbnormalTextCodesForCategoricalObservations { get; set; }

        /// <summary>
        /// OM3.6 - Critical Text/Codes for Categorical Observations.
        /// </summary>
        public IEnumerable<CodedElement> CriticalTextCodesForCategoricalObservations { get; set; }

        /// <summary>
        /// OM3.7 - Value Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0125</remarks>
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
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}",
                                Id,
                                SequenceNumberTestObservationMasterFile.HasValue ? SequenceNumberTestObservationMasterFile.Value.ToString(Consts.NumericFormat, culture) : null,
                                PreferredCodingSystem?.ToDelimitedString(),
                                ValidCodedAnswers?.ToDelimitedString(),
                                NormalTextCodesForCategoricalObservations != null ? string.Join("~", NormalTextCodesForCategoricalObservations.Select(x => x.ToDelimitedString())) : null,
                                AbnormalTextCodesForCategoricalObservations != null ? string.Join("~", AbnormalTextCodesForCategoricalObservations.Select(x => x.ToDelimitedString())) : null,
                                CriticalTextCodesForCategoricalObservations != null ? string.Join("~", CriticalTextCodesForCategoricalObservations.Select(x => x.ToDelimitedString())) : null,
                                ValueType
                                ).TrimEnd('|');
        }
    }
}