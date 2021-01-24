using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment QRI - Query Response Instance.
    /// </summary>
    public class QriSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "QRI";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// QRI.1 - Candidate Confidence.
        /// </summary>
        public decimal? CandidateConfidence { get; set; }

        /// <summary>
        /// QRI.2 - Match Reason Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0392</remarks>
        public IEnumerable<CodedWithExceptions> MatchReasonCode { get; set; }

        /// <summary>
        /// QRI.3 - Algorithm Descriptor.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0393</remarks>
        public CodedWithExceptions AlgorithmDescriptor { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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