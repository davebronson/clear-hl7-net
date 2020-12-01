using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V280.Types;

namespace ClearHl7.Fhir.V280.Segments
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
        public IEnumerable<CodedWithExceptions> TestObservationsIncludedWithinAnOrderedTestBattery { get; set; }

        /// <summary>
        /// OM5.3 - Observation ID Suffixes.
        /// </summary>
        public string ObservationIdSuffixes { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 4, Configuration.FieldSeparator),
                                Id,
                                SequenceNumberTestObservationMasterFile.HasValue ? SequenceNumberTestObservationMasterFile.Value.ToString(Consts.NumericFormat, culture) : null,
                                TestObservationsIncludedWithinAnOrderedTestBattery != null ? string.Join(Configuration.FieldRepeatSeparator, TestObservationsIncludedWithinAnOrderedTestBattery.Select(x => x.ToDelimitedString())) : null,
                                ObservationIdSuffixes
                                ).TrimEnd(Configuration.FieldSeparator);
        }
    }
}