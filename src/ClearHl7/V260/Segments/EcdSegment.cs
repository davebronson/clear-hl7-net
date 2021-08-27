﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
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
        /// <para>Suggested: 0368 Remote Control Command -&gt; ClearHl7.Codes.V260.CodeRemoteControlCommand</para>
        /// </summary>
        public CodedWithExceptions RemoteControlCommand { get; set; }

        /// <summary>
        /// ECD.3 - Response Required.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V260.CodeYesNoIndicator</para>
        /// </summary>
        public string ResponseRequired { get; set; }

        /// <summary>
        /// ECD.4 - Requested Completion Time.
        /// </summary>
        public TimingQuantity RequestedCompletionTime { get; set; }

        /// <summary>
        /// ECD.5 - Parameters.
        /// </summary>
        public IEnumerable<Text> Parameters { get; set; }

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

            ReferenceCommandNumber = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            RemoteControlCommand = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[2], false, seps) : null;
            ResponseRequired = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            RequestedCompletionTime = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<TimingQuantity>(segments[4], false, seps) : null;
            Parameters = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<Text>(x, false, seps)) : null;
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
                                Parameters != null ? string.Join(Configuration.FieldRepeatSeparator, Parameters.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}