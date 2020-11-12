using System;
using ClearHl7.Fhir.V251.Types;

namespace ClearHl7.Fhir.V251.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0368</remarks>
        public CodedElement InteractionTypeIdentifier { get; set; }

        /// <summary>
        /// ISD.3 - Interaction Active State.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0387</remarks>
        public CodedElement InteractionActiveState { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}",
                                Id,
                                ReferenceInteractionNumber.HasValue ? ReferenceInteractionNumber.Value.ToString(culture) : null,
                                InteractionTypeIdentifier?.ToDelimitedString(),
                                InteractionActiveState?.ToDelimitedString()
                                ).TrimEnd('|');
        }
    }
}