using System;
using ClearHl7.Fhir.V270.Types;

namespace ClearHl7.Fhir.V270.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0806</remarks>
        public CodedWithExceptions SterilizationType { get; set; }

        /// <summary>
        /// STZ.2 - Sterilization Cycle.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0702</remarks>
        public CodedWithExceptions SterilizationCycle { get; set; }

        /// <summary>
        /// STZ.3 - Maintenance Cycle.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0809</remarks>
        public CodedWithExceptions MaintenanceCycle { get; set; }

        /// <summary>
        /// STZ.4 - Maintenance Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0811</remarks>
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
                                "{0}|{1}|{2}|{3}|{4}",
                                Id,
                                SterilizationType?.ToDelimitedString(),
                                SterilizationCycle?.ToDelimitedString(),
                                MaintenanceCycle?.ToDelimitedString(),
                                MaintenanceType?.ToDelimitedString()
                                ).TrimEnd('|');
        }
    }
}