using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment OH1 - Person Employment Status.
    /// </summary>
    public class Oh1Segment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Oh1Segment"/> class.
        /// </summary>
        public Oh1Segment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Oh1Segment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public Oh1Segment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "OH1";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// OH1.1 - Set ID.
        /// </summary>
        public uint? SetId { get; set; }

        /// <summary>
        /// OH1.2 - Action Code.
        /// </summary>
        public string ActionCode { get; set; }

        /// <summary>
        /// OH1.3 - Employment Status.
        /// <para>Suggested: 0957 Employment Status</para>
        /// </summary>
        public CodedWithExceptions EmploymentStatus { get; set; }

        /// <summary>
        /// OH1.4 - Employment Status Start Date.
        /// </summary>
        public DateTime? EmploymentStatusStartDate { get; set; }

        /// <summary>
        /// OH1.5 - Employment Status End Date.
        /// </summary>
        public DateTime? EmploymentStatusEndDate { get; set; }

        /// <summary>
        /// OH1.6 - Entered Date.
        /// </summary>
        public DateTime? EnteredDate { get; set; }

        /// <summary>
        /// OH1.7 - Employment Status Unique Identifier.
        /// </summary>
        public EntityIdentifier EmploymentStatusUniqueIdentifier { get; set; }

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
            EmploymentStatus = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[3], false, seps) : null;
            EmploymentStatusStartDate = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            EmploymentStatusEndDate = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDateTime() : null;
            EnteredDate = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDateTime() : null;
            EmploymentStatusUniqueIdentifier = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[7], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 8, Configuration.FieldSeparator),
                                Id,
                                SetId.HasValue ? SetId.Value.ToString(culture) : null,
                                ActionCode,
                                EmploymentStatus?.ToDelimitedString(),
                                EmploymentStatusStartDate?.ToHl7DateTimeString(typeof(Oh1Segment), nameof(EmploymentStatusStartDate), Consts.DateFormatPrecisionDay, culture),
                                EmploymentStatusEndDate?.ToHl7DateTimeString(typeof(Oh1Segment), nameof(EmploymentStatusEndDate), Consts.DateFormatPrecisionDay, culture),
                                EnteredDate?.ToHl7DateTimeString(typeof(Oh1Segment), nameof(EnteredDate), Consts.DateFormatPrecisionDay, culture),
                                EmploymentStatusUniqueIdentifier?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
