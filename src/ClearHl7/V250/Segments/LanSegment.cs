using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V250.Types;

namespace ClearHl7.V250.Segments
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
        public CodedElement LanguageCode { get; set; }

        /// <summary>
        /// LAN.3 - Language Ability Code.
        /// <para>Suggested: 0403 Language Ability -&gt; ClearHl7.Codes.V250.CodeLanguageAbility</para>
        /// </summary>
        public IEnumerable<CodedElement> LanguageAbilityCode { get; set; }

        /// <summary>
        /// LAN.4 - Language Proficiency Code.
        /// <para>Suggested: 0404 Language Proficiency -&gt; ClearHl7.Codes.V250.CodeLanguageProficiency</para>
        /// </summary>
        public CodedElement LanguageProficiencyCode { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());
            char[] separator = Configuration.FieldRepeatSeparator.ToCharArray();

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdLan = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            LanguageCode = segments.Length > 2 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(2), false) : null;
            LanguageAbilityCode = segments.Length > 3 ? segments.ElementAtOrDefault(3).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            LanguageProficiencyCode = segments.Length > 4 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(4), false) : null;
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