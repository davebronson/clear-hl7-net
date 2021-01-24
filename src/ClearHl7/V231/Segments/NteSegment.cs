using System.Collections.Generic;
using ClearHl7.Helpers;
using ClearHl7.V231.Types;

namespace ClearHl7.V231.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment NTE - Notes And Comments.
    /// </summary>
    public class NteSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "NTE";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// NTE.1 - Set ID - NTE.
        /// </summary>
        public uint? SetIdNte { get; set; }

        /// <summary>
        /// NTE.2 - Source of Comment.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0105</remarks>
        public string SourceOfComment { get; set; }

        /// <summary>
        /// NTE.3 - Comment.
        /// </summary>
        public IEnumerable<string> Comment { get; set; }

        /// <summary>
        /// NTE.4 - Comment Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0364</remarks>
        public CodedElement CommentType { get; set; }

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
                                SetIdNte.HasValue ? SetIdNte.Value.ToString(culture) : null,
                                SourceOfComment,
                                Comment != null ? string.Join(Configuration.FieldRepeatSeparator, Comment) : null,
                                CommentType?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}