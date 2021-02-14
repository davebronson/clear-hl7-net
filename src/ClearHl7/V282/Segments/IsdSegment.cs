using ClearHl7.Helpers;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ISD - Interaction Status Detail.
    /// </summary>
    public class IsdSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "ISD";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// ISD.1 - Reference Interaction Number.
        /// </summary>
        public decimal? ReferenceInteractionNumber { get; set; }

        /// <summary>
        /// ISD.2 - Interaction Type Identifier.
        /// <para>Suggested: 0368 Remote Control Command -&gt; ClearHl7.Codes.V282.CodeRemoteControlCommand</para>
        /// </summary>
        public CodedWithExceptions InteractionTypeIdentifier { get; set; }

        /// <summary>
        /// ISD.3 - Interaction Active State.
        /// <para>Suggested: 0387 Command Response -&gt; ClearHl7.Codes.V282.CodeCommandResponse</para>
        /// </summary>
        public CodedWithExceptions InteractionActiveState { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 4, Configuration.FieldSeparator),
                                Id,
                                ReferenceInteractionNumber.HasValue ? ReferenceInteractionNumber.Value.ToString(culture) : null,
                                InteractionTypeIdentifier?.ToDelimitedString(),
                                InteractionActiveState?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}