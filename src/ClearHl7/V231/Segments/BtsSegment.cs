using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V231.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment BTS - Batch Trailer.
    /// </summary>
    public class BtsSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "BTS";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
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

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());
            char[] separator = Configuration.FieldRepeatSeparator.ToCharArray();

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            BatchMessageCount = segments.ElementAtOrDefault(1);
            BatchComment = segments.ElementAtOrDefault(2);
            BatchTotals = segments.Length > 3 ? segments.ElementAtOrDefault(3).Split(separator).Select(x => x.ToDecimal()) : null;
        }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
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