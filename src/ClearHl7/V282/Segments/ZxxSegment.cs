using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment Zxx - Any Z-Segment.
    /// </summary>
    public class ZxxSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZxxSegment"/> class.
        /// </summary>
        public ZxxSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZxxSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public ZxxSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => $"Z{ (string.IsNullOrEmpty(SegmentSuffix) ? "" : SegmentSuffix.Substring(0, Math.Min(SegmentSuffix.Length, 2))) }";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// Gets or sets the custom suffix for the Segment name.
        /// </summary>
        /// <remarks>For example, providing a SegmentSuffix of "AB" will result in a Segment named "ZAB".</remarks>
        public string SegmentSuffix { get; set; } = "XX";

        /// <summary>
        /// URD.1 - Segment items.
        /// </summary>
        public IEnumerable<IType> SegmentItems { get; set; }

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
                if (!segments[0].StartsWith("Z", StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: 'Z[XX]{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SegmentSuffix = segments.Length > 0 && segments[0].Length > 0 ? segments[0].Substring(1) : SegmentSuffix;
            SegmentItems = segments.Length > 1 && segments[1].Length > 0 ? segments[1].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<Text>(x, false, seps)) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 2, Configuration.FieldSeparator),
                                Id,
                                SegmentItems != null ? string.Join("|", SegmentItems.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
