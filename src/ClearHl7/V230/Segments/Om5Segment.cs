using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment OM5 - Observation Batteries (Sets).
    /// </summary>
    public class Om5Segment : ISegment
    {
        /// <inheritdoc/>
        public string Id { get; } = "OM5";

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SequenceNumberTestObservationMasterFile = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            TestObservationsIncludedWithinAnOrderedTestBattery = segments.Length > 2 && segments[2].Length > 0 ? segments[2].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            ObservationIdSuffixes = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
        }

        /// <inheritdoc/>
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
