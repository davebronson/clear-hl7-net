using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment OH4 - Combat Zone Work.
    /// </summary>
    public class Oh4Segment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Oh4Segment"/> class.
        /// </summary>
        public Oh4Segment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Oh4Segment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public Oh4Segment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "OH4";

        /// <inheritdoc/>
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
        /// OH4.4 - Combat Zone End Date.
        /// <para>Suggested: 0955 Industry</para>
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

            SetId = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            ActionCode = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            CombatZoneStartDate = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDateTime() : null;
            CombatZoneEndDate = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            EnteredDate = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDateTime() : null;
            CombatZoneUniqueIdentifier = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[6], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 7, Configuration.FieldSeparator),
                                Id,
                                SetId.HasValue ? SetId.Value.ToString(culture) : null,
                                ActionCode,
                                CombatZoneStartDate.ToHl7DateTimeString(typeof(Oh4Segment), nameof(CombatZoneStartDate), Consts.DateFormatPrecisionDay, culture),
                                CombatZoneEndDate.ToHl7DateTimeString(typeof(Oh4Segment), nameof(CombatZoneEndDate), Consts.DateFormatPrecisionDay, culture),
                                EnteredDate.ToHl7DateTimeString(typeof(Oh4Segment), nameof(EnteredDate), Consts.DateFormatPrecisionDay, culture),
                                CombatZoneUniqueIdentifier?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
