using ClearHl7.Helpers;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment STZ - Sterilization Parameter.
    /// </summary>
    public class StzSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "STZ";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// STZ.1 - Sterilization Type.
        /// <para>Suggested: 0806 Sterilization Type -&gt; ClearHl7.Codes.V280.CodeSterilizationType</para>
        /// </summary>
        public CodedWithExceptions SterilizationType { get; set; }

        /// <summary>
        /// STZ.2 - Sterilization Cycle.
        /// <para>Suggested: 0702 Cycle Type -&gt; ClearHl7.Codes.V280.CodeCycleType</para>
        /// </summary>
        public CodedWithExceptions SterilizationCycle { get; set; }

        /// <summary>
        /// STZ.3 - Maintenance Cycle.
        /// <para>Suggested: 0809 Maintenance Cycle</para>
        /// </summary>
        public CodedWithExceptions MaintenanceCycle { get; set; }

        /// <summary>
        /// STZ.4 - Maintenance Type.
        /// <para>Suggested: 0811 Maintenance Type</para>
        /// </summary>
        public CodedWithExceptions MaintenanceType { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 5, Configuration.FieldSeparator),
                                Id,
                                SterilizationType?.ToDelimitedString(),
                                SterilizationCycle?.ToDelimitedString(),
                                MaintenanceCycle?.ToDelimitedString(),
                                MaintenanceType?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}