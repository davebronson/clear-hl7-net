using System;
using System.Collections.Generic;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment URS - R/U Where Subject Definition.
    /// </summary>
    public class UrsSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UrsSegment"/> class.
        /// </summary>
        public UrsSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrsSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public UrsSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "URS";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// URS.1 - R/U Where Subject Definition.
        /// </summary>
        public IEnumerable<string> RuWhereSubjectDefinition { get; set; }

        /// <summary>
        /// URS.2 - R/U When Data Start Date/Time.
        /// </summary>
        public DateTime? RuWhenDataStartDateTime { get; set; }

        /// <summary>
        /// URS.3 - R/U When Data End Date/Time.
        /// </summary>
        public DateTime? RuWhenDataEndDateTime { get; set; }

        /// <summary>
        /// URS.4 - R/U What User Qualifier.
        /// </summary>
        public IEnumerable<string> RuWhatUserQualifier { get; set; }

        /// <summary>
        /// URS.5 - R/U Other Results Subject Definition.
        /// </summary>
        public IEnumerable<string> RuOtherResultsSubjectDefinition { get; set; }

        /// <summary>
        /// URS.6 - R/U Which Date/Time Qualifier.
        /// <para>Suggested: 0156 Which Date/Time Qualifier</para>
        /// </summary>
        public IEnumerable<string> RuWhichDateTimeQualifier { get; set; }

        /// <summary>
        /// URS.7 - R/U Which Date/Time Status Qualifier.
        /// <para>Suggested: 0157 Which Date/Time Status Qualifier</para>
        /// </summary>
        public IEnumerable<string> RuWhichDateTimeStatusQualifier { get; set; }

        /// <summary>
        /// URS.8 - R/U Date/Time Selection Qualifier.
        /// <para>Suggested: 0158 Date/Time Selection Qualifier</para>
        /// </summary>
        public IEnumerable<string> RuDateTimeSelectionQualifier { get; set; }

        /// <summary>
        /// URS.9 - R/U Quantity/Timing Qualifier.
        /// </summary>
        public TimingQuantity RuQuantityTimingQualifier { get; set; }

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

            RuWhereSubjectDefinition = segments.Length > 1 && segments[1].Length > 0 ? segments[1].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            RuWhenDataStartDateTime = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDateTime() : null;
            RuWhenDataEndDateTime = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDateTime() : null;
            RuWhatUserQualifier = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            RuOtherResultsSubjectDefinition = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            RuWhichDateTimeQualifier = segments.Length > 6 && segments[6].Length > 0 ? segments[6].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            RuWhichDateTimeStatusQualifier = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            RuDateTimeSelectionQualifier = segments.Length > 8 && segments[8].Length > 0 ? segments[8].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            RuQuantityTimingQualifier = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<TimingQuantity>(segments[9], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 10, Configuration.FieldSeparator),
                                Id,
                                RuWhereSubjectDefinition != null ? string.Join(Configuration.FieldRepeatSeparator, RuWhereSubjectDefinition) : null,
                                RuWhenDataStartDateTime?.ToHl7DateTimeString(typeof(UrsSegment), nameof(RuWhenDataStartDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                RuWhenDataEndDateTime?.ToHl7DateTimeString(typeof(UrsSegment), nameof(RuWhenDataEndDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                RuWhatUserQualifier != null ? string.Join(Configuration.FieldRepeatSeparator, RuWhatUserQualifier) : null,
                                RuOtherResultsSubjectDefinition != null ? string.Join(Configuration.FieldRepeatSeparator, RuOtherResultsSubjectDefinition) : null,
                                RuWhichDateTimeQualifier != null ? string.Join(Configuration.FieldRepeatSeparator, RuWhichDateTimeQualifier) : null,
                                RuWhichDateTimeStatusQualifier != null ? string.Join(Configuration.FieldRepeatSeparator, RuWhichDateTimeStatusQualifier) : null,
                                RuDateTimeSelectionQualifier != null ? string.Join(Configuration.FieldRepeatSeparator, RuDateTimeSelectionQualifier) : null,
                                RuQuantityTimingQualifier?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
