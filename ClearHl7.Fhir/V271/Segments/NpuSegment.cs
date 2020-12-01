using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V271.Types;

namespace ClearHl7.Fhir.V271.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment NPU - Bed Status Update.
    /// </summary>
    public class NpuSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "NPU";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// NPU.1 - Bed Location.
        /// </summary>
        public PersonLocation BedLocation { get; set; }

        /// <summary>
        /// NPU.2 - Bed Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0116</remarks>
        public CodedWithExceptions BedStatus { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 3, Configuration.FieldSeparator),
                                Id,
                                BedLocation?.ToDelimitedString(),
                                BedStatus?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator);
        }
    }
}