using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment TQ2 - Timing Quantity Relationship.
    /// </summary>
    public class Tq2Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "TQ2";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// TQ2.1 - Set ID - TQ2.
        ///// </summary>
        //public SetIdTq2 { get; set; }

        ///// <summary>
        ///// TQ2.2 - Sequence/Results Flag.
        ///// </summary>
        //public SequenceResultsFlag { get; set; }

        ///// <summary>
        ///// TQ2.3 - Related Placer Number.
        ///// </summary>
        //public RelatedPlacerNumber { get; set; }

        ///// <summary>
        ///// TQ2.4 - Related Filler Number.
        ///// </summary>
        //public RelatedFillerNumber { get; set; }

        ///// <summary>
        ///// TQ2.5 - Related Placer Group Number.
        ///// </summary>
        //public RelatedPlacerGroupNumber { get; set; }

        ///// <summary>
        ///// TQ2.6 - Sequence Condition Code.
        ///// </summary>
        //public SequenceConditionCode { get; set; }

        ///// <summary>
        ///// TQ2.7 - Cyclic Entry/Exit Indicator.
        ///// </summary>
        //public CyclicEntryExitIndicator { get; set; }

        ///// <summary>
        ///// TQ2.8 - Sequence Condition Time Interval.
        ///// </summary>
        //public SequenceConditionTimeInterval { get; set; }

        ///// <summary>
        ///// TQ2.9 - Cyclic Group Maximum Number of Repeats.
        ///// </summary>
        //public CyclicGroupMaximumNumberOfRepeats { get; set; }

        ///// <summary>
        ///// TQ2.10 - Special Service Request Relationship.
        ///// </summary>
        //public SpecialServiceRequestRelationship { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}"
                                ).TrimEnd('|');
        }
    }
}