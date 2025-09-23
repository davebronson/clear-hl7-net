using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ECR - Equipment Command Response.
    /// </summary>
    public class EcrSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EcrSegment"/> class.
        /// </summary>
        public EcrSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EcrSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public EcrSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "ECR";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// ECR.1 - Command Response.
        /// <para>Suggested: 0387 Command Response -&gt; ClearHl7.Codes.V290.CodeCommandResponse</para>
        /// </summary>
        public CodedWithExceptions CommandResponse { get; set; }

        /// <summary>
        /// ECR.2 - Date/Time Completed.
        /// </summary>
        public DateTime? DateTimeCompleted { get; set; }

        /// <summary>
        /// ECR.3 - Command Response Parameters.
        /// </summary>
        public IEnumerable<Text> CommandResponseParameters { get; set; }

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

            CommandResponse = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[1], false, seps) : null;
            DateTimeCompleted = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDateTime() : null;
            CommandResponseParameters = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<Text>(x, false, seps)) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 4, Configuration.FieldSeparator),
                                Id,
                                CommandResponse?.ToDelimitedString(),
                                DateTimeCompleted.ToHl7DateTimeString(typeof(EcrSegment), nameof(DateTimeCompleted), Consts.DateTimeFormatPrecisionSecond, culture),
                                CommandResponseParameters != null ? string.Join(Configuration.FieldRepeatSeparator, CommandResponseParameters.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
