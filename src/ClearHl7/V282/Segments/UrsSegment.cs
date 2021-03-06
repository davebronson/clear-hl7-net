﻿using ClearHl7.Helpers;

namespace ClearHl7.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment URS - Deprecated.
    /// </summary>
    public class UrsSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "URS";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// URS.1 - Segment string.
        /// </summary>
        public string SegmentString { get; set; }

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
                                SegmentString
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}