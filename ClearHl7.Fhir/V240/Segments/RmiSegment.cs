using System;
using ClearHl7.Fhir.V240.Types;

namespace ClearHl7.Fhir.V240.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RMI - Risk Management Incident.
    /// </summary>
    public class RmiSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "RMI";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// RMI.1 - Risk Management Incident Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0427</remarks>
        public CodedElement RiskManagementIncidentCode { get; set; }

        /// <summary>
        /// RMI.2 - Date/Time Incident.
        /// </summary>
        public DateTime? DateTimeIncident { get; set; }

        /// <summary>
        /// RMI.3 - Incident Type Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0428</remarks>
        public CodedElement IncidentTypeCode { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}",
                                Id,
                                RiskManagementIncidentCode?.ToDelimitedString(),
                                DateTimeIncident.HasValue ? DateTimeIncident.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                IncidentTypeCode?.ToDelimitedString()
                                ).TrimEnd('|');
        }
    }
}