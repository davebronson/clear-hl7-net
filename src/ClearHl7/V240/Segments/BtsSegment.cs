using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V240.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment BTS - Batch Trailer.
    /// </summary>
    public class BtsSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BtsSegment"/> class.
        /// </summary>
        public BtsSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BtsSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public BtsSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "BTS";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// BTS.1 - Batch Message Count.
        /// </summary>
        public string BatchMessageCount { get; set; }

        /// <summary>
        /// BTS.2 - Batch Comment.
        /// </summary>
        public string BatchComment { get; set; }

        /// <summary>
        /// BTS.3 - Batch Totals.
        /// </summary>
        public IEnumerable<decimal> BatchTotals { get; set; }

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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            BatchMessageCount = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            BatchComment = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            BatchTotals = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => x.ToDecimal()) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 4, Configuration.FieldSeparator),
                                Id,
                                BatchMessageCount,
                                BatchComment,
                                BatchTotals != null ? string.Join(Configuration.FieldRepeatSeparator, BatchTotals.Select(x => x.ToString(Consts.NumericFormat, culture))) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
