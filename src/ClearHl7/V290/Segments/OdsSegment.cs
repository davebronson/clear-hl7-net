using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ODS - Dietary Orders, Supplements, And Preferences.
    /// </summary>
    public class OdsSegment : ISegment
    {
        /// <inheritdoc/>
        public string Id { get; } = "ODS";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// ODS.1 - Type.
        /// <para>Suggested: 0159 Diet Code Specification Type -&gt; ClearHl7.Codes.V290.CodeDietCodeSpecificationType</para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// ODS.2 - Service Period.
        /// <para>Suggested: 0627 Service Period</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ServicePeriod { get; set; }

        /// <summary>
        /// ODS.3 - Diet, Supplement, or Preference Code.
        /// <para>Suggested: 0628 Diet, Supplement, Or Preference Code</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> DietSupplementOrPreferenceCode { get; set; }

        /// <summary>
        /// ODS.4 - Text Instruction.
        /// </summary>
        public IEnumerable<string> TextInstruction { get; set; }

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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            Type = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            ServicePeriod = segments.Length > 2 && segments[2].Length > 0 ? segments[2].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            DietSupplementOrPreferenceCode = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            TextInstruction = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 5, Configuration.FieldSeparator),
                                Id,
                                Type,
                                ServicePeriod != null ? string.Join(Configuration.FieldRepeatSeparator, ServicePeriod.Select(x => x.ToDelimitedString())) : null,
                                DietSupplementOrPreferenceCode != null ? string.Join(Configuration.FieldRepeatSeparator, DietSupplementOrPreferenceCode.Select(x => x.ToDelimitedString())) : null,
                                TextInstruction != null ? string.Join(Configuration.FieldRepeatSeparator, TextInstruction) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
