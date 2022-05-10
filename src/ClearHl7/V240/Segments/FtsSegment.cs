using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V240.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment FTS - File Trailer.
    /// </summary>
    public class FtsSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FtsSegment"/> class.
        /// </summary>
        public FtsSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FtsSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public FtsSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "FTS";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// FTS.1 - File Batch Count.
        /// </summary>
        public decimal? FileBatchCount { get; set; }

        /// <summary>
        /// FTS.2 - File Trailer Comment.
        /// </summary>
        public string FileTrailerComment { get; set; }

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

            FileBatchCount = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            FileTrailerComment = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 3, Configuration.FieldSeparator),
                                Id,
                                FileBatchCount.HasValue ? FileBatchCount.Value.ToString(Consts.NumericFormat, culture) : null,
                                FileTrailerComment
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
