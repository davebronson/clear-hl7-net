using System;
using ClearHl7.Fhir.V230.Types;

namespace ClearHl7.Fhir.V230.Segments
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

        /// <summary>
        /// RXR.1 - Route.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0162</remarks>
        public CodedElement Route { get; set; }

        /// <summary>
        /// RXR.2 - Administration Site.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0163</remarks>
        public CodedElement AdministrationSite { get; set; }

        /// <summary>
        /// RXR.3 - Administration Device.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0164</remarks>
        public CodedElement AdministrationDevice { get; set; }

        /// <summary>
        /// RXR.4 - Administration Method.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0165</remarks>
        public CodedElement AdministrationMethod { get; set; }

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
                                Route?.ToDelimitedString(),
                                AdministrationSite?.ToDelimitedString(),
                                AdministrationDevice?.ToDelimitedString(),
                                AdministrationMethod?.ToDelimitedString()
                                ).TrimEnd('|');
        }
    }
}