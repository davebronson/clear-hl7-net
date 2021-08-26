using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment Zxx - Any Z-Segment.
    /// </summary>
    public class ZxxSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id => $"Z{ (string.IsNullOrEmpty(SegmentSuffix) ? "" : SegmentSuffix.Substring(0, Math.Min(SegmentSuffix.Length, 2))) }";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// Gets or sets the custom suffix for the Segment name.
        /// </summary>
        /// <remarks>For example, providing a SegmentSuffix of "AB" will result in a Segment named "ZAB".</remarks>
        public string SegmentSuffix { get; set; } = "XX";

        /// <summary>
        /// URD.1 - Segment items.
        /// </summary>
        public IEnumerable<IType> SegmentItems { get; set; }

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
        internal void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);
            
            if (segments.Length > 0)
            {
                if (!segments[0].StartsWith("Z", StringComparison.CurrentCultureIgnoreCase))
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: 'Z[XX]{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            // TODO:  Means to provide the collection of ITypes to be used when building SegmentItems

            SegmentSuffix = segments.Length > 0 && segments[0].Length > 0 ? segments[0].Substring(1) : SegmentSuffix;
            SegmentItems = segments.Length > 1 && segments[1].Length > 0 ? segments[1].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<Text>(x, false)) : null;
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
                                StringHelper.StringFormatSequence(0, 2, Configuration.FieldSeparator),
                                Id,
                                SegmentItems != null ? string.Join(Configuration.FieldSeparator, SegmentItems.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}