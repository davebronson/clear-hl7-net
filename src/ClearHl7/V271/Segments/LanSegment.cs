using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V271.Types;

namespace ClearHl7.Fhir.V271.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment LAN - Language Detail.
    /// </summary>
    public class LanSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "LAN";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// LAN.1 - Set ID - LAN.
        /// </summary>
        public uint? SetIdLan { get; set; }

        /// <summary>
        /// LAN.2 - Language Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0296</remarks>
        public CodedWithExceptions LanguageCode { get; set; }

        /// <summary>
        /// LAN.3 - Language Ability Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0403</remarks>
        public IEnumerable<CodedWithExceptions> LanguageAbilityCode { get; set; }

        /// <summary>
        /// LAN.4 - Language Proficiency Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0404</remarks>
        public CodedWithExceptions LanguageProficiencyCode { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 5, Configuration.FieldSeparator),
                                Id,
                                SetIdLan.HasValue ? SetIdLan.Value.ToString(culture) : null,
                                LanguageCode?.ToDelimitedString(),
                                LanguageAbilityCode != null ? string.Join(Configuration.FieldRepeatSeparator, LanguageAbilityCode.Select(x => x.ToDelimitedString())) : null,
                                LanguageProficiencyCode?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}