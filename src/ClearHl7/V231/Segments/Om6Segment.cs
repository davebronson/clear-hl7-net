using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V231.Types;

namespace ClearHl7.V231.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment OM6 - Observations That Are Calculated From Other Observations.
    /// </summary>
    public class Om6Segment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Om6Segment"/> class.
        /// </summary>
        public Om6Segment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Om6Segment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public Om6Segment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "OM6";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// OM6.1 - Sequence Number - Test/Observation Master File.
        /// </summary>
        public decimal? SequenceNumberTestObservationMasterFile { get; set; }

        /// <summary>
        /// OM6.2 - Derivation Rule.
        /// </summary>
        public Text DerivationRule { get; set; }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (!string.Equals(Id, segments[0], StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SequenceNumberTestObservationMasterFile = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            DerivationRule = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[2], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 3, Configuration.FieldSeparator),
                                Id,
                                SequenceNumberTestObservationMasterFile.HasValue ? SequenceNumberTestObservationMasterFile.Value.ToString(Consts.NumericFormat, culture) : null,
                                DerivationRule?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
