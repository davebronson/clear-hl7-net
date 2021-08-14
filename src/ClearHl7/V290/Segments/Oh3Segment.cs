using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment OH3 - Usual Work.
    /// </summary>
    public class Oh3Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "OH3";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
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

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetId = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            ActionCode = segments.ElementAtOrDefault(2);
            Occupation = segments.Length > 3 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(3), false) : null;
            Industry = segments.Length > 4 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(4), false) : null;
            UsualOccupationDurationYears = segments.ElementAtOrDefault(5)?.ToNullableDecimal();
            StartYear = segments.ElementAtOrDefault(6)?.ToNullableDateTime();
            EnteredDate = segments.ElementAtOrDefault(7)?.ToNullableDateTime();
            WorkUniqueIdentifier = segments.Length > 8 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(8), false) : null;
        }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
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
                                StartYear.HasValue ? StartYear.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                EnteredDate.HasValue ? EnteredDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                WorkUniqueIdentifier?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}