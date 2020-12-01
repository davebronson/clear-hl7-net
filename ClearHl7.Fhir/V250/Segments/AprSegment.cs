using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V250.Types;

namespace ClearHl7.Fhir.V250.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment APR - Appointment Preferences.
    /// </summary>
    public class AprSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "APR";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// APR.1 - Time Selection Criteria.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0294</remarks>
        public IEnumerable<SchedulingClassValuePair> TimeSelectionCriteria { get; set; }

        /// <summary>
        /// APR.2 - Resource Selection Criteria.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0294</remarks>
        public IEnumerable<SchedulingClassValuePair> ResourceSelectionCriteria { get; set; }

        /// <summary>
        /// APR.3 - Location Selection Criteria.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0294</remarks>
        public IEnumerable<SchedulingClassValuePair> LocationSelectionCriteria { get; set; }

        /// <summary>
        /// APR.4 - Slot Spacing Criteria.
        /// </summary>
        public decimal? SlotSpacingCriteria { get; set; }

        /// <summary>
        /// APR.5 - Filler Override Criteria.
        /// </summary>
        public IEnumerable<SchedulingClassValuePair> FillerOverrideCriteria { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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