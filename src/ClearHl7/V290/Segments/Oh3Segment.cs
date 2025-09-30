using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment OH3 - Usual Work.
    /// </summary>
    public class Oh3Segment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Oh3Segment"/> class.
        /// </summary>
        public Oh3Segment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Oh3Segment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public Oh3Segment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "OH3";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// OH3.1 - Set ID.
        /// </summary>
        public uint? SetId { get; set; }

        /// <summary>
        /// OH3.2 - Action Code.
        /// </summary>
        public string ActionCode { get; set; }

        /// <summary>
        /// OH3.3 - Occupation.
        /// <para>Suggested: 0958 Occupation</para>
        /// </summary>
        public CodedWithExceptions Occupation { get; set; }

        /// <summary>
        /// OH3.4 - Industry.
        /// <para>Suggested: 0955 Industry</para>
        /// </summary>
        public CodedWithExceptions Industry { get; set; }

        /// <summary>
        /// OH3.5 - Usual Occupation Duration (Years).
        /// </summary>
        public decimal? UsualOccupationDurationYears { get; set; }

        /// <summary>
        /// OH3.6 - Start Year.
        /// </summary>
        public DateTime? StartYear { get; set; }

        /// <summary>
        /// OH3.7 - Entered Date.
        /// </summary>
        public DateTime? EnteredDate { get; set; }

        /// <summary>
        /// OH3.8 - Work Unique Identifier.
        /// </summary>
        public EntityIdentifier WorkUniqueIdentifier { get; set; }

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
            Occupation = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[3], false, seps) : null;
            Industry = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[4], false, seps) : null;
            UsualOccupationDurationYears = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDecimal() : null;
            StartYear = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDateTime() : null;
            EnteredDate = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDateTime() : null;
            WorkUniqueIdentifier = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[8], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 9, Configuration.FieldSeparator),
                                Id,
                                SetId.HasValue ? SetId.Value.ToString(culture) : null,
                                ActionCode,
                                Occupation?.ToDelimitedString(),
                                Industry?.ToDelimitedString(),
                                UsualOccupationDurationYears.HasValue ? UsualOccupationDurationYears.Value.ToString(Consts.NumericFormat, culture) : null,
                                StartYear?.ToHl7DateTimeString(typeof(Oh3Segment), nameof(StartYear), Consts.DateFormatPrecisionDay, culture),
                                EnteredDate?.ToHl7DateTimeString(typeof(Oh3Segment), nameof(EnteredDate), Consts.DateFormatPrecisionDay, culture),
                                WorkUniqueIdentifier?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
