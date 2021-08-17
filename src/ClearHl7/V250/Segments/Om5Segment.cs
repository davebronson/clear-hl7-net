using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V250.Types;

namespace ClearHl7.V250.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment OM5 - Observation Batteries (Sets).
    /// </summary>
    public class Om5Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "OM5";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// OM5.1 - Sequence Number - Test/Observation Master File.
        /// </summary>
        public decimal? SequenceNumberTestObservationMasterFile { get; set; }

        /// <summary>
        /// OM5.2 - Test/Observations Included Within an Ordered Test Battery.
        /// </summary>
        public IEnumerable<CodedElement> TestObservationsIncludedWithinAnOrderedTestBattery { get; set; }

        /// <summary>
        /// OM5.3 - Observation ID Suffixes.
        /// </summary>
        public string ObservationIdSuffixes { get; set; }

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

            SequenceNumberTestObservationMasterFile = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            TestObservationsIncludedWithinAnOrderedTestBattery = segments.Length > 2 && segments[2].Length > 0 ? segments[2].Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            ObservationIdSuffixes = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
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
                                StringHelper.StringFormatSequence(0, 4, Configuration.FieldSeparator),
                                Id,
                                SequenceNumberTestObservationMasterFile.HasValue ? SequenceNumberTestObservationMasterFile.Value.ToString(Consts.NumericFormat, culture) : null,
                                TestObservationsIncludedWithinAnOrderedTestBattery != null ? string.Join(Configuration.FieldRepeatSeparator, TestObservationsIncludedWithinAnOrderedTestBattery.Select(x => x.ToDelimitedString())) : null,
                                ObservationIdSuffixes
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}