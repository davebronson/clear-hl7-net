using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
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
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Codes.V271.CodeSegmentActionCode</para>
        /// </summary>
        public CodedWithNoExceptions AccessRestrictionActionCode { get; set; }

        /// <summary>
        /// ARV.3 - Access Restriction Value.
        /// <para>Suggested: 0717 Access Restriction Value -&gt; ClearHl7.Codes.V271.CodeAccessRestrictionValue</para>
        /// </summary>
        public CodedWithExceptions AccessRestrictionValue { get; set; }

        /// <summary>
        /// ARV.4 - Access Restriction Reason.
        /// <para>Suggested: 0719 Access Restriction Reason Code -&gt; ClearHl7.Codes.V271.CodeAccessRestrictionReasonCode</para>
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

            SetId = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            AccessRestrictionActionCode = segments.Length > 2 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(2), false) : null;
            AccessRestrictionValue = segments.Length > 3 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(3), false) : null;
            AccessRestrictionReason = segments.Length > 4 ? segments.ElementAtOrDefault(4).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            SpecialAccessRestrictionInstructions = segments.Length > 5 ? segments.ElementAtOrDefault(5).Split(separator) : null;
            AccessRestrictionDateRange = segments.Length > 6 ? TypeHelper.Deserialize<DateTimeRange>(segments.ElementAtOrDefault(6), false) : null;
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