using System;

namespace ClearHl7.Fhir.V270.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment FTS - File Trailer.
    /// </summary>
    public class FtsSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "FTS";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// FTS.1 - File Batch Count.
        /// </summary>
        public decimal? FileBatchCount { get; set; }

        /// <summary>
        /// FTS.2 - File Trailer Comment.
        /// </summary>
        public string FileTrailerComment { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}",
                                Id,
                                FileBatchCount.HasValue ? FileBatchCount.Value.ToString(Consts.NumericFormat, culture) : null,
                                FileTrailerComment
                                ).TrimEnd('|');
        }
    }
}