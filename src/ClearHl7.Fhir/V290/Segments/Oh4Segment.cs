using System;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V290.Types;

namespace ClearHl7.Fhir.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment OH4 - Combat Zone Work.
    /// </summary>
    public class Oh4Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "OH4";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// OH4.1 - Set ID.
        /// </summary>
        public uint? SetId { get; set; }

        /// <summary>
        /// OH4.2 - Action Code.
        /// </summary>
        public string ActionCode { get; set; }

        /// <summary>
        /// OH4.3 - Combat Zone Start Date.
        /// </summary>
        public DateTime? CombatZoneStartDate { get; set; }

        /// <summary>
        /// OH4.4 - Combat Zone  End Date.
        /// </summary>
        public DateTime? CombatZoneEndDate { get; set; }

        /// <summary>
        /// OH4.5 - Entered Date.
        /// </summary>
        public DateTime? EnteredDate { get; set; }

        /// <summary>
        /// OH4.6 - Combat Zone Unique Identifier.
        /// </summary>
        public EntityIdentifier CombatZoneUniqueIdentifier { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 7, Configuration.FieldSeparator),
                                Id,
                                SetId.HasValue ? SetId.Value.ToString(culture) : null,
                                ActionCode,
                                CombatZoneStartDate.HasValue ? CombatZoneStartDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                CombatZoneEndDate.HasValue ? CombatZoneEndDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                EnteredDate.HasValue ? EnteredDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                CombatZoneUniqueIdentifier?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}