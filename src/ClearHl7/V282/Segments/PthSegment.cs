using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PTH - Pathway.
    /// </summary>
    public class PthSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PTH";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// PTH.1 - Action Code.
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Codes.V282.CodeSegmentActionCode</para>
        /// </summary>
        public string ActionCode { get; set; }

        /// <summary>
        /// PTH.2 - Pathway ID.
        /// </summary>
        public CodedWithExceptions PathwayId { get; set; }

        /// <summary>
        /// PTH.3 - Pathway Instance ID.
        /// </summary>
        public EntityIdentifier PathwayInstanceId { get; set; }

        /// <summary>
        /// PTH.4 - Pathway Established Date/Time.
        /// </summary>
        public DateTime? PathwayEstablishedDateTime { get; set; }

        /// <summary>
        /// PTH.5 - Pathway Life Cycle Status.
        /// </summary>
        public CodedWithExceptions PathwayLifeCycleStatus { get; set; }

        /// <summary>
        /// PTH.6 - Change Pathway Life Cycle Status Date/Time.
        /// </summary>
        public DateTime? ChangePathwayLifeCycleStatusDateTime { get; set; }

        /// <summary>
        /// PTH.7 - Mood Code.
        /// <para>Suggested: 0725 Mood Codes -&gt; ClearHl7.Codes.V282.CodeMoodCodes</para>
        /// </summary>
        public CodedWithNoExceptions MoodCode { get; set; }

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

            ActionCode = segments.ElementAtOrDefault(1);
            PathwayId = segments.Length > 2 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(2), false) : null;
            PathwayInstanceId = segments.Length > 3 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(3), false) : null;
            PathwayEstablishedDateTime = segments.ElementAtOrDefault(4)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            PathwayLifeCycleStatus = segments.Length > 5 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(5), false) : null;
            ChangePathwayLifeCycleStatusDateTime = segments.ElementAtOrDefault(6)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            MoodCode = segments.Length > 7 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(7), false) : null;
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
                                StringHelper.StringFormatSequence(0, 8, Configuration.FieldSeparator),
                                Id,
                                ActionCode,
                                PathwayId?.ToDelimitedString(),
                                PathwayInstanceId?.ToDelimitedString(),
                                PathwayEstablishedDateTime.HasValue ? PathwayEstablishedDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                PathwayLifeCycleStatus?.ToDelimitedString(),
                                ChangePathwayLifeCycleStatusDateTime.HasValue ? ChangePathwayLifeCycleStatusDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                MoodCode?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}