﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
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
        /// <para>Suggested: 0662 Test/Observations Included Within an Ordered Test Battery</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> TestObservationsIncludedWithinAnOrderedTestBattery { get; set; }

        /// <summary>
        /// OM5.3 - Observation ID Suffixes.
        /// </summary>
        public string ObservationIdSuffixes { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public Om5Segment FromDelimitedString(string delimitedString)
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

            SequenceNumberTestObservationMasterFile = segments.ElementAtOrDefault(1)?.ToNullableDecimal();
            TestObservationsIncludedWithinAnOrderedTestBattery = segments.Length > 2 ? segments.ElementAtOrDefault(2).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            ObservationIdSuffixes = segments.ElementAtOrDefault(3);
            
            return this;
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