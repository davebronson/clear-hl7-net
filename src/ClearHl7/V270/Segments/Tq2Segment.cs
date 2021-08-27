using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V270.Types;

namespace ClearHl7.V270.Segments
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
        /// <para>Suggested: 0503 Sequence/Results Flag -&gt; ClearHl7.Codes.V270.CodeSequenceResultsFlag</para>
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
        /// <para>Suggested: 0504 Sequence Condition Code -&gt; ClearHl7.Codes.V270.CodeSequenceConditionCode</para>
        /// </summary>
        public string SequenceConditionCode { get; set; }

        /// <summary>
        /// TQ2.7 - Cyclic Entry/Exit Indicator.
        /// <para>Suggested: 0505 Cyclic Entry/Exit Indicator -&gt; ClearHl7.Codes.V270.CodeCyclicEntryExitIndicator</para>
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
        /// <para>Suggested: 0506 Service Request Relationship -&gt; ClearHl7.Codes.V270.CodeServiceRequestRelationship</para>
        /// </summary>
        public string SpecialServiceRequestRelationship { get; set; }

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
        public void FromDelimitedString(string delimitedString, Separators separators)
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

            SetIdTq2 = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            SequenceResultsFlag = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            RelatedPlacerNumber = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<EntityIdentifier>(x, false, seps)) : null;
            RelatedFillerNumber = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<EntityIdentifier>(x, false, seps)) : null;
            RelatedPlacerGroupNumber = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<EntityIdentifier>(x, false, seps)) : null;
            SequenceConditionCode = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            CyclicEntryExitIndicator = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            SequenceConditionTimeInterval = segments.Length > 8 && segments[8].Length > 0 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments[8], false, seps) : null;
            CyclicGroupMaximumNumberOfRepeats = segments.Length > 9 && segments[9].Length > 0 ? segments[9].ToNullableDecimal() : null;
            SpecialServiceRequestRelationship = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
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