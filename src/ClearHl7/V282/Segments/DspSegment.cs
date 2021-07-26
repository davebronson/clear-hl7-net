﻿using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment DSP - Display Data.
    /// </summary>
    public class DspSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "DSP";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// DSP.1 - Set ID - DSP.
        /// </summary>
        public uint? SetIdDsp { get; set; }

        /// <summary>
        /// DSP.2 - Display Level.
        /// </summary>
        public uint? DisplayLevel { get; set; }

        /// <summary>
        /// DSP.3 - Data Line.
        /// </summary>
        public Text DataLine { get; set; }

        /// <summary>
        /// DSP.4 - Logical Break Point.
        /// </summary>
        public string LogicalBreakPoint { get; set; }

        /// <summary>
        /// DSP.5 - Result ID.
        /// </summary>
        public Text ResultId { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdDsp = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            DisplayLevel = segments.ElementAtOrDefault(2)?.ToNullableUInt();
            DataLine = segments.Length > 3 ? TypeHelper.Deserialize<Text>(segments.ElementAtOrDefault(3), false) : null;
            LogicalBreakPoint = segments.ElementAtOrDefault(4);
            ResultId = segments.Length > 5 ? TypeHelper.Deserialize<Text>(segments.ElementAtOrDefault(5), false) : null;
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
                                SetIdDsp.HasValue ? SetIdDsp.Value.ToString(culture) : null,
                                DisplayLevel.HasValue ? DisplayLevel.Value.ToString(culture) : null,
                                DataLine?.ToDelimitedString(),
                                LogicalBreakPoint,
                                ResultId?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}