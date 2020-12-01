using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V282.Types;

namespace ClearHl7.Fhir.V282.Segments
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
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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