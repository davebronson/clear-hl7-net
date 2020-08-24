using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 OG - Observation Grouper.
    /// </summary>
    public class ObservationGrouper
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// OG.1 - Original Sub-Identifier.
        /// </summary>
        public string OriginalSubIdentifier { get; set; }

        /// <summary>
        /// OG.2 - Group.
        /// </summary>
        public decimal? Group { get; set; }

        /// <summary>
        /// OG.3 - Sequence.
        /// </summary>
        public decimal? Sequence { get; set; }

        /// <summary>
        /// OG.4 - Identifier.
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                IsSubcomponent ? "{0}&{1}&{2}&{3}" : "{0}^{1}^{2}^{3}",
                                OriginalSubIdentifier,
                                Group.HasValue ? Group.Value.ToString(Consts.NumericFormat, culture) : null,
                                Sequence.HasValue ? Sequence.Value.ToString(Consts.NumericFormat, culture) : null,
                                Identifier
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
