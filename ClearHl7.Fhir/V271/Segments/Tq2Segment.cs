using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V271.Types;

namespace ClearHl7.Fhir.V271.Segments
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

        /// <summary>
        /// TQ2.1 - Set ID - TQ2.
        /// </summary>
        public uint? SetIdTq2 { get; set; }

        /// <summary>
        /// TQ2.2 - Sequence/Results Flag.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0503</remarks>
        public string SequenceResultsFlag { get; set; }

        /// <summary>
        /// TQ2.3 - Related Placer Number.
        /// </summary>
        public IEnumerable<EntityIdentifier> RelatedPlacerNumber { get; set; }

        /// <summary>
        /// TQ2.4 - Related Filler Number.
        /// </summary>
        public IEnumerable<EntityIdentifier> RelatedFillerNumber { get; set; }

        /// <summary>
        /// TQ2.5 - Related Placer Group Number.
        /// </summary>
        public IEnumerable<EntityIdentifier> RelatedPlacerGroupNumber { get; set; }

        /// <summary>
        /// TQ2.6 - Sequence Condition Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0504</remarks>
        public string SequenceConditionCode { get; set; }

        /// <summary>
        /// TQ2.7 - Cyclic Entry/Exit Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0505</remarks>
        public string CyclicEntryExitIndicator { get; set; }

        /// <summary>
        /// TQ2.8 - Sequence Condition Time Interval.
        /// </summary>
        public CompositeQuantityWithUnits SequenceConditionTimeInterval { get; set; }

        /// <summary>
        /// TQ2.9 - Cyclic Group Maximum Number of Repeats.
        /// </summary>
        public decimal? CyclicGroupMaximumNumberOfRepeats { get; set; }

        /// <summary>
        /// TQ2.10 - Special Service Request Relationship.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0506</remarks>
        public string SpecialServiceRequestRelationship { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}",
                                Id,
                                SetIdTq2.HasValue ? SetIdTq2.Value.ToString(culture) : null,
                                SequenceResultsFlag,
                                RelatedPlacerNumber != null ? string.Join("~", RelatedPlacerNumber.Select(x => x.ToDelimitedString())) : null,
                                RelatedFillerNumber != null ? string.Join("~", RelatedFillerNumber.Select(x => x.ToDelimitedString())) : null,
                                RelatedPlacerGroupNumber != null ? string.Join("~", RelatedPlacerGroupNumber.Select(x => x.ToDelimitedString())) : null,
                                SequenceConditionCode,
                                CyclicEntryExitIndicator,
                                SequenceConditionTimeInterval?.ToDelimitedString(),
                                CyclicGroupMaximumNumberOfRepeats.HasValue ? CyclicGroupMaximumNumberOfRepeats.Value.ToString(Consts.NumericFormat, culture) : null,
                                SpecialServiceRequestRelationship
                                ).TrimEnd('|');
        }
    }
}