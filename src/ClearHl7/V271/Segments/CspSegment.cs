using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment CSP - Clinical Study Phase.
    /// </summary>
    public class CspSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "CSP";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// CSP.1 - Study Phase Identifier.
        /// </summary>
        public CodedWithExceptions StudyPhaseIdentifier { get; set; }

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
        public CodedWithExceptions StudyPhaseEvaluability { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            StudyPhaseIdentifier = segments.Length > 1 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(1), false) : null;
            DateTimeStudyPhaseBegan = segments.ElementAtOrDefault(2)?.ToNullableDateTime();
            DateTimeStudyPhaseEnded = segments.ElementAtOrDefault(3)?.ToNullableDateTime();
            StudyPhaseEvaluability = segments.Length > 4 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(4), false) : null;
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
                                StudyPhaseIdentifier?.ToDelimitedString(),
                                DateTimeStudyPhaseBegan.HasValue ? DateTimeStudyPhaseBegan.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                DateTimeStudyPhaseEnded.HasValue ? DateTimeStudyPhaseEnded.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                StudyPhaseEvaluability?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}