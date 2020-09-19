using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 ERL - Error Location.
    /// </summary>
    public class ErrorLocation : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// ERL.1 - Segment ID.
        /// </summary>
        public string SegmentId { get; set; }

        /// <summary>
        /// ERL.2 - Segment Sequence.
        /// </summary>
        public decimal? SegmentSequence { get; set; }

        /// <summary>
        /// ERL.3 - Field Position.
        /// </summary>
        public decimal? FieldPosition { get; set; }

        /// <summary>
        /// ERL.4 - Field Repetition.
        /// </summary>
        public decimal? FieldRepetition { get; set; }

        /// <summary>
        /// ERL.5 - Component Number.
        /// </summary>
        public decimal? ComponentNumber { get; set; }

        /// <summary>
        /// ERL.6 - Sub-Component Number.
        /// </summary>
        public decimal? SubComponentNumber { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                IsSubcomponent ? "{0}&{1}&{2}&{3}&{4}&{5}" : "{0}^{1}^{2}^{3}^{4}^{5}",
                                SegmentId,
                                SegmentSequence.HasValue ? SegmentSequence.Value.ToString(Consts.NumericFormat, culture) : null,
                                FieldPosition.HasValue ? FieldPosition.Value.ToString(Consts.NumericFormat, culture) : null,
                                FieldRepetition.HasValue ? FieldRepetition.Value.ToString(Consts.NumericFormat, culture) : null,
                                ComponentNumber.HasValue ? ComponentNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                SubComponentNumber.HasValue ? SubComponentNumber.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
