using System;

namespace ClearHl7.Fhir.V282.Segments
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

        ///// <summary>
        ///// QRI.1 - Candidate Confidence.
        ///// </summary>
        //public CandidateConfidence { get; set; }

        ///// <summary>
        ///// QRI.2 - Match Reason Code.
        ///// </summary>
        //public MatchReasonCode { get; set; }

        ///// <summary>
        ///// QRI.3 - Algorithm Descriptor.
        ///// </summary>
        //public AlgorithmDescriptor { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}"
                                ).TrimEnd('|');
        }
    }
}