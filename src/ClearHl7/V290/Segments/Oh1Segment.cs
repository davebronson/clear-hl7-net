using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
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
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        internal void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetId = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            ActionCode = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            EmploymentStatus = segments.Length > 3 && segments[3].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[3], false) : null;
            EmploymentStatusStartDate = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            EmploymentStatusEndDate = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDateTime() : null;
            EnteredDate = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDateTime() : null;
            EmploymentStatusUniqueIdentifier = segments.Length > 7 && segments[7].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[7], false) : null;
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