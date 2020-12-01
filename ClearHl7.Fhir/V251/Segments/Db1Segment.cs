using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V251.Types;

namespace ClearHl7.Fhir.V251.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment DB1 - Disability.
    /// </summary>
    public class Db1Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "DB1";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// DB1.1 - Set ID - DB1.
        /// </summary>
        public uint? SetIdDb1 { get; set; }

        /// <summary>
        /// DB1.2 - Disabled Person Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0334</remarks>
        public string DisabledPersonCode { get; set; }

        /// <summary>
        /// DB1.3 - Disabled Person Identifier.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> DisabledPersonIdentifier { get; set; }

        /// <summary>
        /// DB1.4 - Disability Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string DisabilityIndicator { get; set; }

        /// <summary>
        /// DB1.5 - Disability Start Date.
        /// </summary>
        public DateTime? DisabilityStartDate { get; set; }

        /// <summary>
        /// DB1.6 - Disability End Date.
        /// </summary>
        public DateTime? DisabilityEndDate { get; set; }

        /// <summary>
        /// DB1.7 - Disability Return to Work Date.
        /// </summary>
        public DateTime? DisabilityReturnToWorkDate { get; set; }

        /// <summary>
        /// DB1.8 - Disability Unable to Work Date.
        /// </summary>
        public DateTime? DisabilityUnableToWorkDate { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 9, Configuration.FieldSeparator),
                                Id,
                                SetIdDb1.HasValue ? SetIdDb1.Value.ToString(culture) : null,
                                DisabledPersonCode,
                                DisabledPersonIdentifier != null ? string.Join(Configuration.FieldRepeatSeparator, DisabledPersonIdentifier.Select(x => x.ToDelimitedString())) : null,
                                DisabilityIndicator,
                                DisabilityStartDate.HasValue ? DisabilityStartDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                DisabilityEndDate.HasValue ? DisabilityEndDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                DisabilityReturnToWorkDate.HasValue ? DisabilityReturnToWorkDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                DisabilityUnableToWorkDate.HasValue ? DisabilityUnableToWorkDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator);
        }
    }
}