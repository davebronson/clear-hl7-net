using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment CTI - Clinical Trial Identification.
    /// </summary>
    public class CtiSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CtiSegment"/> class.
        /// </summary>
        public CtiSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CtiSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public CtiSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "CTI";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// CTI.1 - Sponsor Study ID.
        /// </summary>
        public EntityIdentifier SponsorStudyId { get; set; }

        /// <summary>
        /// CTI.2 - Study Phase Identifier.
        /// </summary>
        public CodedWithExceptions StudyPhaseIdentifier { get; set; }

        /// <summary>
        /// CTI.3 - Study Scheduled Time Point.
        /// <para>Suggested: 0595 Study Scheduled Time Point</para>
        /// </summary>
        public CodedWithExceptions StudyScheduledTimePoint { get; set; }

        /// <summary>
        /// CTI.4 - Action Code.
        /// </summary>
        public string ActionCode { get; set; }

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

            SponsorStudyId = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[1], false, seps) : null;
            StudyPhaseIdentifier = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[2], false, seps) : null;
            StudyScheduledTimePoint = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[3], false, seps) : null;
            ActionCode = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 5, Configuration.FieldSeparator),
                                Id,
                                SponsorStudyId?.ToDelimitedString(),
                                StudyPhaseIdentifier?.ToDelimitedString(),
                                StudyScheduledTimePoint?.ToDelimitedString(),
                                ActionCode
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
