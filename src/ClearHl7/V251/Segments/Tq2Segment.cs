using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V251.Types;

namespace ClearHl7.V251.Segments
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
        /// <para>Suggested: 0503 Sequence/Results Flag -&gt; ClearHl7.Codes.V251.CodeSequenceResultsFlag</para>
        /// </summary>
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
        /// <para>Suggested: 0504 Sequence Condition Code -&gt; ClearHl7.Codes.V251.CodeSequenceConditionCode</para>
        /// </summary>
        public string SequenceConditionCode { get; set; }

        /// <summary>
        /// TQ2.7 - Cyclic Entry/Exit Indicator.
        /// <para>Suggested: 0505 Cyclic Entry/Exit Indicator -&gt; ClearHl7.Codes.V251.CodeCyclicEntryExitIndicator</para>
        /// </summary>
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
        /// <para>Suggested: 0506 Service Request Relationship -&gt; ClearHl7.Codes.V251.CodeServiceRequestRelationship</para>
        /// </summary>
        public string SpecialServiceRequestRelationship { get; set; }

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

            SetIdTq2 = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            SequenceResultsFlag = segments.ElementAtOrDefault(2);
            RelatedPlacerNumber = segments.Length > 3 ? segments.ElementAtOrDefault(3).Split(separator).Select(x => TypeHelper.Deserialize<EntityIdentifier>(x, false)) : null;
            RelatedFillerNumber = segments.Length > 4 ? segments.ElementAtOrDefault(4).Split(separator).Select(x => TypeHelper.Deserialize<EntityIdentifier>(x, false)) : null;
            RelatedPlacerGroupNumber = segments.Length > 5 ? segments.ElementAtOrDefault(5).Split(separator).Select(x => TypeHelper.Deserialize<EntityIdentifier>(x, false)) : null;
            SequenceConditionCode = segments.ElementAtOrDefault(6);
            CyclicEntryExitIndicator = segments.ElementAtOrDefault(7);
            SequenceConditionTimeInterval = segments.Length > 8 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(8), false) : null;
            CyclicGroupMaximumNumberOfRepeats = segments.ElementAtOrDefault(9)?.ToNullableDecimal();
            SpecialServiceRequestRelationship = segments.ElementAtOrDefault(10);
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
                                StringHelper.StringFormatSequence(0, 11, Configuration.FieldSeparator),
                                Id,
                                SetIdTq2.HasValue ? SetIdTq2.Value.ToString(culture) : null,
                                SequenceResultsFlag,
                                RelatedPlacerNumber != null ? string.Join(Configuration.FieldRepeatSeparator, RelatedPlacerNumber.Select(x => x.ToDelimitedString())) : null,
                                RelatedFillerNumber != null ? string.Join(Configuration.FieldRepeatSeparator, RelatedFillerNumber.Select(x => x.ToDelimitedString())) : null,
                                RelatedPlacerGroupNumber != null ? string.Join(Configuration.FieldRepeatSeparator, RelatedPlacerGroupNumber.Select(x => x.ToDelimitedString())) : null,
                                SequenceConditionCode,
                                CyclicEntryExitIndicator,
                                SequenceConditionTimeInterval?.ToDelimitedString(),
                                CyclicGroupMaximumNumberOfRepeats.HasValue ? CyclicGroupMaximumNumberOfRepeats.Value.ToString(Consts.NumericFormat, culture) : null,
                                SpecialServiceRequestRelationship
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}