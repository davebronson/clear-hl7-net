﻿using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V270.Types;

namespace ClearHl7.V270.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ARV - Access Restriction.
    /// </summary>
    public class ArvSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "ARV";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// ARV.1 - Set ID.
        /// </summary>
        public uint? SetId { get; set; }

        /// <summary>
        /// ARV.2 - Access Restriction Action Code.
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Codes.V270.CodeSegmentActionCode</para>
        /// </summary>
        public CodedWithNoExceptions AccessRestrictionActionCode { get; set; }

        /// <summary>
        /// ARV.3 - Access Restriction Value.
        /// <para>Suggested: 0717 Access Restriction Value -&gt; ClearHl7.Codes.V270.CodeAccessRestrictionValue</para>
        /// </summary>
        public CodedWithExceptions AccessRestrictionValue { get; set; }

        /// <summary>
        /// ARV.4 - Access Restriction Reason.
        /// <para>Suggested: 0719 Access Restriction Reason Code -&gt; ClearHl7.Codes.V270.CodeAccessRestrictionReasonCode</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> AccessRestrictionReason { get; set; }

        /// <summary>
        /// ARV.5 - Special Access Restriction Instructions.
        /// </summary>
        public IEnumerable<string> SpecialAccessRestrictionInstructions { get; set; }

        /// <summary>
        /// ARV.6 - Access Restriction Date Range.
        /// </summary>
        public DateTimeRange AccessRestrictionDateRange { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 7, Configuration.FieldSeparator),
                                Id,
                                SetId.HasValue ? SetId.Value.ToString(culture) : null,
                                AccessRestrictionActionCode?.ToDelimitedString(),
                                AccessRestrictionValue?.ToDelimitedString(),
                                AccessRestrictionReason != null ? string.Join(Configuration.FieldRepeatSeparator, AccessRestrictionReason.Select(x => x.ToDelimitedString())) : null,
                                SpecialAccessRestrictionInstructions != null ? string.Join(Configuration.FieldRepeatSeparator, SpecialAccessRestrictionInstructions) : null,
                                AccessRestrictionDateRange?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}