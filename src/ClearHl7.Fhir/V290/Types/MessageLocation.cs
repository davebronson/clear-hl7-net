using ClearHl7.Fhir.Helpers;

namespace ClearHl7.Fhir.V290.Types
{
    /// <summary>
    /// HL7 Version 2 ERL - Message Location.
    /// </summary>
    public class MessageLocation : IType
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
        public uint? SegmentSequence { get; set; }

        /// <summary>
        /// ERL.3 - Field Position.
        /// </summary>
        public uint? FieldPosition { get; set; }

        /// <summary>
        /// ERL.4 - Field Repetition.
        /// </summary>
        public uint? FieldRepetition { get; set; }

        /// <summary>
        /// ERL.5 - Component Number.
        /// </summary>
        public uint? ComponentNumber { get; set; }

        /// <summary>
        /// ERL.6 - Sub-Component Number.
        /// </summary>
        public uint? SubComponentNumber { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 6, separator),
                                SegmentId,
                                SegmentSequence.HasValue ? SegmentSequence.Value.ToString(culture) : null,
                                FieldPosition.HasValue ? FieldPosition.Value.ToString(culture) : null,
                                FieldRepetition.HasValue ? FieldRepetition.Value.ToString(culture) : null,
                                ComponentNumber.HasValue ? ComponentNumber.Value.ToString(culture) : null,
                                SubComponentNumber.HasValue ? SubComponentNumber.Value.ToString(culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
