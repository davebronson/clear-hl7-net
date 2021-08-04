using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V251.Types;

namespace ClearHl7.V251.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment QAK - Query Acknowledgment.
    /// </summary>
    public class QakSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "QAK";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// QAK.1 - Query Tag.
        /// </summary>
        public string QueryTag { get; set; }

        /// <summary>
        /// QAK.2 - Query Response Status.
        /// <para>Suggested: 0208 Query Response Status -&gt; ClearHl7.Codes.V251.CodeQueryResponseStatus</para>
        /// </summary>
        public string QueryResponseStatus { get; set; }

        /// <summary>
        /// QAK.3 - Message Query Name.
        /// <para>Suggested: 0471 Query Name</para>
        /// </summary>
        public CodedElement MessageQueryName { get; set; }

        /// <summary>
        /// QAK.4 - Hit Count Total.
        /// </summary>
        public decimal? HitCountTotal { get; set; }

        /// <summary>
        /// QAK.5 - This payload.
        /// </summary>
        public decimal? ThisPayload { get; set; }

        /// <summary>
        /// QAK.6 - Hits remaining.
        /// </summary>
        public decimal? HitsRemaining { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            QueryTag = segments.ElementAtOrDefault(1);
            QueryResponseStatus = segments.ElementAtOrDefault(2);
            MessageQueryName = segments.Length > 3 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(3), false) : null;
            HitCountTotal = segments.ElementAtOrDefault(4)?.ToNullableDecimal();
            ThisPayload = segments.ElementAtOrDefault(5)?.ToNullableDecimal();
            HitsRemaining = segments.ElementAtOrDefault(6)?.ToNullableDecimal();
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
                                StringHelper.StringFormatSequence(0, 7, Configuration.FieldSeparator),
                                Id,
                                QueryTag,
                                QueryResponseStatus,
                                MessageQueryName?.ToDelimitedString(),
                                HitCountTotal.HasValue ? HitCountTotal.Value.ToString(Consts.NumericFormat, culture) : null,
                                ThisPayload.HasValue ? ThisPayload.Value.ToString(Consts.NumericFormat, culture) : null,
                                HitsRemaining.HasValue ? HitsRemaining.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}