using System;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment OH1 - Person Employment Status.
    /// </summary>
    public class Oh1Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "OH1";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
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

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 8, Configuration.FieldSeparator),
                                Id,
                                SetId.HasValue ? SetId.Value.ToString(culture) : null,
                                ActionCode,
                                EmploymentStatus?.ToDelimitedString(),
                                EmploymentStatusStartDate.HasValue ? EmploymentStatusStartDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                EmploymentStatusEndDate.HasValue ? EmploymentStatusEndDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                EnteredDate.HasValue ? EnteredDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                EmploymentStatusUniqueIdentifier?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}