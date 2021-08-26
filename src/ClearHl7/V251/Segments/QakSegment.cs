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
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        internal void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            QueryTag = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            QueryResponseStatus = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            MessageQueryName = segments.Length > 3 && segments[3].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[3], false) : null;
            HitCountTotal = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDecimal() : null;
            ThisPayload = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDecimal() : null;
            HitsRemaining = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDecimal() : null;
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