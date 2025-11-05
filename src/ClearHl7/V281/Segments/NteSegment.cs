using System;
using System.Collections.Generic;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment NTE - Notes And Comments.
    /// </summary>
    public class NteSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NteSegment"/> class.
        /// </summary>
        public NteSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NteSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public NteSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "NTE";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// NTE.1 - Set ID - NTE.
        /// </summary>
        public uint? SetIdNte { get; set; }

        /// <summary>
        /// NTE.2 - Source of Comment.
        /// <para>Suggested: 0105 Source Of Comment -&gt; ClearHl7.Codes.V281.CodeSourceOfComment</para>
        /// </summary>
        public string SourceOfComment { get; set; }

        /// <summary>
        /// NTE.3 - Comment.
        /// </summary>
        public IEnumerable<string> Comment { get; set; }

        /// <summary>
        /// NTE.4 - Comment Type.
        /// <para>Suggested: 0364 Comment Type -&gt; ClearHl7.Codes.V281.CodeCommentType</para>
        /// </summary>
        public CodedWithExceptions CommentType { get; set; }

        /// <summary>
        /// NTE.5 - Entered By.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons EnteredBy { get; set; }

        /// <summary>
        /// NTE.6 - Entered Date/Time.
        /// </summary>
        public DateTime? EnteredDateTime { get; set; }

        /// <summary>
        /// NTE.7 - Effective Start Date.
        /// </summary>
        public DateTime? EffectiveStartDate { get; set; }

        /// <summary>
        /// NTE.8 - Expiration Date.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

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

            SetIdNte = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            SourceOfComment = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            Comment = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            CommentType = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[4], false, seps) : null;
            EnteredBy = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[5], false, seps) : null;
            EnteredDateTime = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDateTime() : null;
            EffectiveStartDate = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDateTime() : null;
            ExpirationDate = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDateTime() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 9, Configuration.FieldSeparator),
                                Id,
                                SetIdNte.HasValue ? SetIdNte.Value.ToString(culture) : null,
                                SourceOfComment,
                                Comment != null ? string.Join(Configuration.FieldRepeatSeparator, Comment) : null,
                                CommentType?.ToDelimitedString(),
                                EnteredBy?.ToDelimitedString(),
                                EnteredDateTime?.ToHl7DateTimeString(typeof(NteSegment), nameof(EnteredDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                EffectiveStartDate?.ToHl7DateTimeString(typeof(NteSegment), nameof(EffectiveStartDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                ExpirationDate?.ToHl7DateTimeString(typeof(NteSegment), nameof(ExpirationDate), Consts.DateTimeFormatPrecisionSecond, culture)
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
