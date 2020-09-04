using System;

namespace ClearHl7.Fhir.V282.Segments
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

        ///// <summary>
        ///// STZ.1 - Sterilization Type.
        ///// </summary>
        //public SterilizationType { get; set; }

        ///// <summary>
        ///// STZ.2 - Sterilization Cycle.
        ///// </summary>
        //public SterilizationCycle { get; set; }

        ///// <summary>
        ///// STZ.3 - Maintenance Cycle.
        ///// </summary>
        //public MaintenanceCycle { get; set; }

        ///// <summary>
        ///// STZ.4 - Maintenance Type.
        ///// </summary>
        //public MaintenanceType { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}"
                                ).TrimEnd('|');
        }
    }
}