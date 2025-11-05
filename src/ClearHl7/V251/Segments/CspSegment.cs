using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V251.Types;

namespace ClearHl7.V251.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment CSP - Clinical Study Phase.
    /// </summary>
    public class CspSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CspSegment"/> class.
        /// </summary>
        public CspSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CspSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public CspSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "CSP";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// CSP.1 - Study Phase Identifier.
        /// </summary>
        public CodedElement StudyPhaseIdentifier { get; set; }

        /// <summary>
        /// CSP.2 - Date/time Study Phase Began.
        /// </summary>
        public DateTime? DateTimeStudyPhaseBegan { get; set; }

        /// <summary>
        /// CSP.3 - Date/time Study Phase Ended.
        /// </summary>
        public DateTime? DateTimeStudyPhaseEnded { get; set; }

        /// <summary>
        /// CSP.4 - Study Phase Evaluability.
        /// </summary>
        public CodedElement StudyPhaseEvaluability { get; set; }

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

            StudyPhaseIdentifier = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[1], false, seps) : null;
            DateTimeStudyPhaseBegan = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDateTime() : null;
            DateTimeStudyPhaseEnded = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDateTime() : null;
            StudyPhaseEvaluability = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[4], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 5, Configuration.FieldSeparator),
                                Id,
                                StudyPhaseIdentifier?.ToDelimitedString(),
                                DateTimeStudyPhaseBegan?.ToHl7DateTimeString(typeof(CspSegment), nameof(DateTimeStudyPhaseBegan), Consts.DateTimeFormatPrecisionSecond, culture),
                                DateTimeStudyPhaseEnded?.ToHl7DateTimeString(typeof(CspSegment), nameof(DateTimeStudyPhaseEnded), Consts.DateTimeFormatPrecisionSecond, culture),
                                StudyPhaseEvaluability?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
