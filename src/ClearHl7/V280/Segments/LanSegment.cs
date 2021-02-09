using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
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
        /// <para>Suggested: 0296 Primary Language</para>
        /// </summary>
        public CodedWithExceptions LanguageCode { get; set; }

        /// <summary>
        /// LAN.3 - Language Ability Code.
        /// <para>Suggested: 0403 Language Ability -&gt; ClearHl7.Fhir.Codes.V280.CodeLanguageAbility</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> LanguageAbilityCode { get; set; }

        /// <summary>
        /// LAN.4 - Language Proficiency Code.
        /// <para>Suggested: 0404 Language Proficiency -&gt; ClearHl7.Fhir.Codes.V280.CodeLanguageProficiency</para>
        /// </summary>
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