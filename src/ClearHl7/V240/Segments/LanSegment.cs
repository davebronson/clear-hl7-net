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
    /// HL7 Version 2 Segment LAN - Language Detail.
    /// </summary>
    public class LanSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LanSegment"/> class.
        /// </summary>
        public LanSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public LanSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "LAN";

        /// <inheritdoc/>
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
        /// <para>Suggested: 0403 Language Ability -&gt; ClearHl7.Codes.V240.CodeLanguageAbility</para>
        /// </summary>
        public IEnumerable<CodedElement> LanguageAbilityCode { get; set; }

        /// <summary>
        /// LAN.4 - Language Proficiency Code.
        /// <para>Suggested: 0404 Language Proficiency -&gt; ClearHl7.Codes.V240.CodeLanguageProficiency</para>
        /// </summary>
        public CodedElement LanguageProficiencyCode { get; set; }

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

            SetIdLan = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            LanguageCode = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[2], false, seps) : null;
            LanguageAbilityCode = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            LanguageProficiencyCode = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[4], false, seps) : null;
        }

        /// <inheritdoc/>
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
