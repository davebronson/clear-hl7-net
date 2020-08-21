using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 ERL - Error Location.
    /// </summary>
    public class ErrorLocation
    {
        /// <summary>
        /// ERL.1 - Segment ID.
        /// </summary>
        public string SegmentId { get; set; }

        /// <summary>
        /// ERL.2 - Segment Sequence.
        /// </summary>
        public decimal SegmentSequence { get; set; }

        /// <summary>
        /// ERL.3 - Field Position.
        /// </summary>
        public decimal FieldPosition { get; set; }

        /// <summary>
        /// ERL.4 - Field Repetition.
        /// </summary>
        public decimal FieldRepetition { get; set; }

        /// <summary>
        /// ERL.5 - Component Number.
        /// </summary>
        public decimal ComponentNumber { get; set; }

        /// <summary>
        /// ERL.6 - Sub-Component Number.
        /// </summary>
        public decimal SubComponentNumber { get; set; }
    }
}
