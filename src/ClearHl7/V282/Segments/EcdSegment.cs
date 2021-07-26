using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
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
        /// <para>Suggested: 0368 Remote Control Command -&gt; ClearHl7.Codes.V282.CodeRemoteControlCommand</para>
        /// </summary>
        public CodedWithExceptions RemoteControlCommand { get; set; }

        /// <summary>
        /// ECD.3 - Response Required.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V282.CodeYesNoIndicator</para>
        /// </summary>
        public string ResponseRequired { get; set; }

        /// <summary>
        /// ECD.4 - Requested Completion Time.
        /// </summary>
        public string RequestedCompletionTime { get; set; }

        /// <summary>
        /// ECD.5 - Parameters.
        /// </summary>
        public IEnumerable<Text> Parameters { get; set; }

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

            ReferenceCommandNumber = segments.ElementAtOrDefault(1)?.ToNullableDecimal();
            RemoteControlCommand = segments.Length > 2 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(2), false) : null;
            ResponseRequired = segments.ElementAtOrDefault(3);
            RequestedCompletionTime = segments.ElementAtOrDefault(4);
            Parameters = segments.Length > 5 ? segments.ElementAtOrDefault(5).Split(separator).Select(x => TypeHelper.Deserialize<Text>(x, false)) : null;
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
                                RequestedCompletionTime,
                                Parameters != null ? string.Join(Configuration.FieldRepeatSeparator, Parameters.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}