using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V251.Types;

namespace ClearHl7.V251.Segments
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
        /// <para>Suggested: 0105 Source Of Comment -&gt; ClearHl7.Codes.V251.CodeSourceOfComment</para>
        /// </summary>
        public string SourceOfComment { get; set; }

        /// <summary>
        /// NTE.3 - Comment.
        /// </summary>
        public IEnumerable<string> Comment { get; set; }

        /// <summary>
        /// NTE.4 - Comment Type.
        /// <para>Suggested: 0364 Comment Type -&gt; ClearHl7.Codes.V251.CodeCommentType</para>
        /// </summary>
        public CodedElement CommentType { get; set; }

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

            SetIdNte = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            SourceOfComment = segments.ElementAtOrDefault(2);
            Comment = segments.Length > 3 ? segments.ElementAtOrDefault(3).Split(separator) : null;
            CommentType = segments.Length > 4 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(4), false) : null;
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
                                SetIdNte.HasValue ? SetIdNte.Value.ToString(culture) : null,
                                SourceOfComment,
                                Comment != null ? string.Join(Configuration.FieldRepeatSeparator, Comment) : null,
                                CommentType?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}