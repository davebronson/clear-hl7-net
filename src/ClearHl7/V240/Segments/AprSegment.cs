using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V240.Types;

namespace ClearHl7.V240.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment APR - Appointment Preferences.
    /// </summary>
    public class AprSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AprSegment"/> class.
        /// </summary>
        public AprSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AprSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public AprSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "APR";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// APR.1 - Time Selection Criteria.
        /// <para>Suggested: 0294 Time Selection Criteria Parameter Class Codes -&gt; ClearHl7.Codes.V240.CodeTimeSelectionCriteriaParameterClassCodes</para>
        /// </summary>
        public IEnumerable<SchedulingClassValuePair> TimeSelectionCriteria { get; set; }

        /// <summary>
        /// APR.2 - Resource Selection Criteria.
        /// <para>Suggested: 0294 Time Selection Criteria Parameter Class Codes -&gt; ClearHl7.Codes.V240.CodeTimeSelectionCriteriaParameterClassCodes</para>
        /// </summary>
        public IEnumerable<SchedulingClassValuePair> ResourceSelectionCriteria { get; set; }

        /// <summary>
        /// APR.3 - Location Selection Criteria.
        /// <para>Suggested: 0294 Time Selection Criteria Parameter Class Codes -&gt; ClearHl7.Codes.V240.CodeTimeSelectionCriteriaParameterClassCodes</para>
        /// </summary>
        public IEnumerable<SchedulingClassValuePair> LocationSelectionCriteria { get; set; }

        /// <summary>
        /// APR.4 - Slot Spacing Criteria.
        /// </summary>
        public decimal? SlotSpacingCriteria { get; set; }

        /// <summary>
        /// APR.5 - Filler Override Criteria.
        /// </summary>
        public IEnumerable<SchedulingClassValuePair> FillerOverrideCriteria { get; set; }

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

            TimeSelectionCriteria = segments.Length > 1 && segments[1].Length > 0 ? segments[1].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<SchedulingClassValuePair>(x, false, seps)) : null;
            ResourceSelectionCriteria = segments.Length > 2 && segments[2].Length > 0 ? segments[2].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<SchedulingClassValuePair>(x, false, seps)) : null;
            LocationSelectionCriteria = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<SchedulingClassValuePair>(x, false, seps)) : null;
            SlotSpacingCriteria = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDecimal() : null;
            FillerOverrideCriteria = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<SchedulingClassValuePair>(x, false, seps)) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 6, Configuration.FieldSeparator),
                                Id,
                                TimeSelectionCriteria != null ? string.Join(Configuration.FieldRepeatSeparator, TimeSelectionCriteria.Select(x => x.ToDelimitedString())) : null,
                                ResourceSelectionCriteria != null ? string.Join(Configuration.FieldRepeatSeparator, ResourceSelectionCriteria.Select(x => x.ToDelimitedString())) : null,
                                LocationSelectionCriteria != null ? string.Join(Configuration.FieldRepeatSeparator, LocationSelectionCriteria.Select(x => x.ToDelimitedString())) : null,
                                SlotSpacingCriteria.HasValue ? SlotSpacingCriteria.Value.ToString(Consts.NumericFormat, culture) : null,
                                FillerOverrideCriteria != null ? string.Join(Configuration.FieldRepeatSeparator, FillerOverrideCriteria.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
