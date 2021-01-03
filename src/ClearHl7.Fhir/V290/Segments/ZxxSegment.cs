using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;

namespace ClearHl7.Fhir.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment Zxx - Any Z-Segment.
    /// </summary>
    public class ZxxSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id => $"Z{ (string.IsNullOrEmpty(SegmentSuffix) ? "" : SegmentSuffix.Substring(0, Math.Min(SegmentSuffix.Length, 2))) }";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
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

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 2, Configuration.FieldSeparator),
                                Id,
                                SegmentItems != null ? string.Join("|", SegmentItems.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}