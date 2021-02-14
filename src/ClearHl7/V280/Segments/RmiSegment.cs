using System;
using ClearHl7.Helpers;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
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
        /// <para>Suggested: 0427 Risk Management Incident Code -&gt; ClearHl7.Codes.V280.CodeRiskManagementIncidentCode</para>
        /// </summary>
        public CodedWithExceptions RiskManagementIncidentCode { get; set; }

        /// <summary>
        /// RMI.2 - Date/Time Incident.
        /// </summary>
        public DateTime? DateTimeIncident { get; set; }

        /// <summary>
        /// RMI.3 - Incident Type Code.
        /// <para>Suggested: 0428 Incident Type Code -&gt; ClearHl7.Codes.V280.CodeIncidentTypeCode</para>
        /// </summary>
        public CodedWithExceptions IncidentTypeCode { get; set; }
        
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
                                RiskManagementIncidentCode?.ToDelimitedString(),
                                DateTimeIncident.HasValue ? DateTimeIncident.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                IncidentTypeCode?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}