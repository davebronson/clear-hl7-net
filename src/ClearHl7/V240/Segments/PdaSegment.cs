using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V240.Types;

namespace ClearHl7.V240.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PDA - Patient Death And Autopsy.
    /// </summary>
    public class PdaSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PDA";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// PDA.1 - Death Cause Code.
        /// </summary>
        public IEnumerable<CodedElement> DeathCauseCode { get; set; }

        /// <summary>
        /// PDA.2 - Death Location.
        /// </summary>
        public PersonLocation DeathLocation { get; set; }

        /// <summary>
        /// PDA.3 - Death Certified Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string DeathCertifiedIndicator { get; set; }

        /// <summary>
        /// PDA.4 - Death Certificate Signed Date/Time.
        /// </summary>
        public DateTime? DeathCertificateSignedDateTime { get; set; }

        /// <summary>
        /// PDA.5 - Death Certified By.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons DeathCertifiedBy { get; set; }

        /// <summary>
        /// PDA.6 - Autopsy Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string AutopsyIndicator { get; set; }

        /// <summary>
        /// PDA.7 - Autopsy Start and End Date/Time.
        /// </summary>
        public DateTimeRange AutopsyStartAndEndDateTime { get; set; }

        /// <summary>
        /// PDA.8 - Autopsy Performed By.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons AutopsyPerformedBy { get; set; }

        /// <summary>
        /// PDA.9 - Coroner Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string CoronerIndicator { get; set; }
        
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
                                DeathCauseCode != null ? string.Join(Configuration.FieldRepeatSeparator, DeathCauseCode.Select(x => x.ToDelimitedString())) : null,
                                DeathLocation?.ToDelimitedString(),
                                DeathCertifiedIndicator,
                                DeathCertificateSignedDateTime.HasValue ? DeathCertificateSignedDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                DeathCertifiedBy?.ToDelimitedString(),
                                AutopsyIndicator,
                                AutopsyStartAndEndDateTime?.ToDelimitedString(),
                                AutopsyPerformedBy?.ToDelimitedString(),
                                CoronerIndicator
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}