using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V240.Types;

namespace ClearHl7.V240.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ECR - Equipment Command Response.
    /// </summary>
    public class EcrSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "ECR";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// ECR.1 - Command Response.
        /// <para>Suggested: 0387 Command Response -&gt; ClearHl7.Codes.V240.CodeCommandResponse</para>
        /// </summary>
        public CodedElement CommandResponse { get; set; }

        /// <summary>
        /// ECR.2 - Date/Time Completed.
        /// </summary>
        public DateTime? DateTimeCompleted { get; set; }

        /// <summary>
        /// ECR.3 - Command Response Parameters.
        /// </summary>
        public IEnumerable<string> CommandResponseParameters { get; set; }

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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            CommandResponse = segments.Length > 1 && segments[1].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[1], false) : null;
            DateTimeCompleted = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDateTime() : null;
            CommandResponseParameters = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(separator) : null;
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
                                StringHelper.StringFormatSequence(0, 4, Configuration.FieldSeparator),
                                Id,
                                CommandResponse?.ToDelimitedString(),
                                DateTimeCompleted.HasValue ? DateTimeCompleted.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                CommandResponseParameters != null ? string.Join(Configuration.FieldRepeatSeparator, CommandResponseParameters) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}