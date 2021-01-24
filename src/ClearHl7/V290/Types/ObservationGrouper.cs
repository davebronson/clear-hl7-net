using ClearHl7.Helpers;

namespace ClearHl7.V290.Types
{
    /// <summary>
    /// HL7 Version 2 OG - Observation Grouper.
    /// </summary>
    public class ObservationGrouper : IType
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
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 4, separator),
                                OriginalSubIdentifier,
                                Group.HasValue ? Group.Value.ToString(Consts.NumericFormat, culture) : null,
                                Sequence.HasValue ? Sequence.Value.ToString(Consts.NumericFormat, culture) : null,
                                Identifier
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
