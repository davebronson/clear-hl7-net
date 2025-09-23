using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V250.Types;

namespace ClearHl7.V250.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RMI - Risk Management Incident.
    /// </summary>
    public class RmiSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RmiSegment"/> class.
        /// </summary>
        public RmiSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RmiSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public RmiSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "RMI";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// RMI.1 - Risk Management Incident Code.
        /// <para>Suggested: 0427 Risk Management Incident Code -&gt; ClearHl7.Codes.V250.CodeRiskManagementIncidentCode</para>
        /// </summary>
        public CodedElement RiskManagementIncidentCode { get; set; }

        /// <summary>
        /// RMI.2 - Date/Time Incident.
        /// </summary>
        public DateTime? DateTimeIncident { get; set; }

        /// <summary>
        /// RMI.3 - Incident Type Code.
        /// <para>Suggested: 0428 Incident Type Code -&gt; ClearHl7.Codes.V250.CodeIncidentTypeCode</para>
        /// </summary>
        public CodedElement IncidentTypeCode { get; set; }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (!string.Equals(Id, segments[0], StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            RiskManagementIncidentCode = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[1], false, seps) : null;
            DateTimeIncident = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDateTime() : null;
            IncidentTypeCode = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[3], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 4, Configuration.FieldSeparator),
                                Id,
                                RiskManagementIncidentCode?.ToDelimitedString(),
                                DateTimeIncident.ToHl7DateTimeString(typeof(RmiSegment), nameof(DateTimeIncident), Consts.DateTimeFormatPrecisionSecond, culture),
                                IncidentTypeCode?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
