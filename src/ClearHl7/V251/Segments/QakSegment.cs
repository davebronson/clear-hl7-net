using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V251.Types;

namespace ClearHl7.V251.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment QAK - Query Acknowledgment.
    /// </summary>
    public class QakSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QakSegment"/> class.
        /// </summary>
        public QakSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QakSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public QakSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "QAK";

        /// <inheritdoc/>
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

            QueryTag = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            QueryResponseStatus = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            MessageQueryName = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[3], false, seps) : null;
            HitCountTotal = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDecimal() : null;
            ThisPayload = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDecimal() : null;
            HitsRemaining = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDecimal() : null;
        }

        /// <inheritdoc/>
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
