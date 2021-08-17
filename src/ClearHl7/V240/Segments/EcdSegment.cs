using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V240.Types;

namespace ClearHl7.V240.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ECD - Equipment Command.
    /// </summary>
    public class EcdSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "ECD";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// ECD.1 - Reference Command Number.
        /// </summary>
        public decimal? ReferenceCommandNumber { get; set; }

        /// <summary>
        /// ECD.2 - Remote Control Command.
        /// <para>Suggested: 0368 Remote Control Command -&gt; ClearHl7.Codes.V240.CodeRemoteControlCommand</para>
        /// </summary>
        public CodedElement RemoteControlCommand { get; set; }

        /// <summary>
        /// ECD.3 - Response Required.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V240.CodeYesNoIndicator</para>
        /// </summary>
        public string ResponseRequired { get; set; }

        /// <summary>
        /// ECD.4 - Requested Completion Time.
        /// </summary>
        public TimingQuantity RequestedCompletionTime { get; set; }

        /// <summary>
        /// ECD.5 - Parameters.
        /// </summary>
        public IEnumerable<string> Parameters { get; set; }

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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            ReferenceCommandNumber = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            RemoteControlCommand = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[2], false) : null;
            ResponseRequired = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            RequestedCompletionTime = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<TimingQuantity>(segments[4], false) : null;
            Parameters = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(separator) : null;
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
                                StringHelper.StringFormatSequence(0, 6, Configuration.FieldSeparator),
                                Id,
                                ReferenceCommandNumber.HasValue ? ReferenceCommandNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                RemoteControlCommand?.ToDelimitedString(),
                                ResponseRequired,
                                RequestedCompletionTime?.ToDelimitedString(),
                                Parameters != null ? string.Join(Configuration.FieldRepeatSeparator, Parameters) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}