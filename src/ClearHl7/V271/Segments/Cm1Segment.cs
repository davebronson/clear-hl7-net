using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment CM1 - Clinical Study Phase Master.
    /// </summary>
    public class Cm1Segment : ISegment
    {
        /// <inheritdoc/>
        public string Id { get; } = "CM1";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// CM1.1 - Set ID - CM1.
        /// </summary>
        public uint? SetIdCm1 { get; set; }

        /// <summary>
        /// CM1.2 - Study Phase Identifier.
        /// </summary>
        public CodedWithExceptions StudyPhaseIdentifier { get; set; }

        /// <summary>
        /// CM1.3 - Description of Study Phase.
        /// </summary>
        public string DescriptionOfStudyPhase { get; set; }

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

            SetIdCm1 = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            StudyPhaseIdentifier = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[2], false, seps) : null;
            DescriptionOfStudyPhase = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 4, Configuration.FieldSeparator),
                                Id,
                                SetIdCm1.HasValue ? SetIdCm1.Value.ToString(culture) : null,
                                StudyPhaseIdentifier?.ToDelimitedString(),
                                DescriptionOfStudyPhase
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
