using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment QRI - Query Response Instance.
    /// </summary>
    public class QriSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QriSegment"/> class.
        /// </summary>
        public QriSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QriSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public QriSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "QRI";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// QRI.1 - Candidate Confidence.
        /// </summary>
        public decimal? CandidateConfidence { get; set; }

        /// <summary>
        /// QRI.2 - Match Reason Code.
        /// <para>Suggested: 0392 Match Reason -&gt; ClearHl7.Codes.V260.CodeMatchReason</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> MatchReasonCode { get; set; }

        /// <summary>
        /// QRI.3 - Algorithm Descriptor.
        /// <para>Suggested: 0393 Match Algorithms -&gt; ClearHl7.Codes.V260.CodeMatchAlgorithms</para>
        /// </summary>
        public CodedWithExceptions AlgorithmDescriptor { get; set; }

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

            CandidateConfidence = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            MatchReasonCode = segments.Length > 2 && segments[2].Length > 0 ? segments[2].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            AlgorithmDescriptor = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[3], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 4, Configuration.FieldSeparator),
                                Id,
                                CandidateConfidence.HasValue ? CandidateConfidence.Value.ToString(Consts.NumericFormat, culture) : null,
                                MatchReasonCode != null ? string.Join(Configuration.FieldRepeatSeparator, MatchReasonCode.Select(x => x.ToDelimitedString())) : null,
                                AlgorithmDescriptor?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
