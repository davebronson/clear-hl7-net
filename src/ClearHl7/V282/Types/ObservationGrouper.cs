using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V282.Types
{
    /// <summary>
    /// HL7 Version 2 OG - Observation Grouper.
    /// </summary>
    public class ObservationGrouper : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationGrouper"/> class.
        /// </summary>
        public ObservationGrouper()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationGrouper"/> class.
        /// </summary>
        /// <param name="group">OG.2 - Group.</param>
        /// <param name="sequence">OG.3 - Sequence.</param>
        public ObservationGrouper(decimal group, decimal sequence)
        {
            Group = group;
            Sequence = sequence;
        }

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] separator = IsSubcomponent ? seps.SubcomponentSeparator : seps.ComponentSeparator;
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(separator, StringSplitOptions.None);

            OriginalSubIdentifier = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            Group = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            Sequence = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDecimal() : null;
            Identifier = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
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
