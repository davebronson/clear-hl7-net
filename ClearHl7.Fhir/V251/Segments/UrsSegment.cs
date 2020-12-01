using System;
using System.Collections.Generic;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V251.Types;

namespace ClearHl7.Fhir.V251.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment URS - R/U Where Subject Definition.
    /// </summary>
    public class UrsSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "URS";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0156</remarks>
        public IEnumerable<string> RuWhichDateTimeQualifier { get; set; }

        /// <summary>
        /// URS.7 - R/U Which Date/Time Status Qualifier.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0157</remarks>
        public IEnumerable<string> RuWhichDateTimeStatusQualifier { get; set; }

        /// <summary>
        /// URS.8 - R/U Date/Time Selection Qualifier.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0158</remarks>
        public IEnumerable<string> RuDateTimeSelectionQualifier { get; set; }

        /// <summary>
        /// URS.9 - R/U Quantity/Timing Qualifier.
        /// </summary>
        public TimingQuantity RuQuantityTimingQualifier { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 10, Configuration.FieldSeparator),
                                Id,
                                RuWhereSubjectDefinition != null ? string.Join(Configuration.FieldRepeatSeparator, RuWhereSubjectDefinition) : null,
                                RuWhenDataStartDateTime.HasValue ? RuWhenDataStartDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                RuWhenDataEndDateTime.HasValue ? RuWhenDataEndDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
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