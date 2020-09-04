using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RXR - Pharmacy Treatment Route.
    /// </summary>
    public class RxrSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "RXR";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// RXR.1 - Route.
        ///// </summary>
        //public Route { get; set; }

        ///// <summary>
        ///// RXR.2 - Administration Site.
        ///// </summary>
        //public AdministrationSite { get; set; }

        ///// <summary>
        ///// RXR.3 - Administration Device.
        ///// </summary>
        //public AdministrationDevice { get; set; }

        ///// <summary>
        ///// RXR.4 - Administration Method.
        ///// </summary>
        //public AdministrationMethod { get; set; }

        ///// <summary>
        ///// RXR.5 - Routing Instruction.
        ///// </summary>
        //public RoutingInstruction { get; set; }

        ///// <summary>
        ///// RXR.6 - Administration Site Modifier.
        ///// </summary>
        //public AdministrationSiteModifier { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}"
                                ).TrimEnd('|');
        }
    }
}