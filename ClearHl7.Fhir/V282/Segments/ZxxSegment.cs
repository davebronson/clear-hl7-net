using System;
using System.Collections.Generic;

namespace ClearHl7.Fhir.V282.Segments
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
        /// URD.1 - Segment string.
        /// </summary>
        public IEnumerable<string> SegmentStrings { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}",
                                Id,
                                SegmentStrings != null ? string.Join("|", SegmentStrings) : null
                                ).TrimEnd('|');
        }
    }
}