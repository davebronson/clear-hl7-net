using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment DPS - Diagnosis And Procedure Code.
    /// </summary>
    public class DpsSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DpsSegment"/> class.
        /// </summary>
        public DpsSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DpsSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public DpsSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "DPS";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// DPS.1 - Diagnosis Code - MCP.
        /// <para>Suggested: 0051 Diagnosis Code</para>
        /// </summary>
        public CodedWithExceptions DiagnosisCodeMcp { get; set; }

        /// <summary>
        /// DPS.2 - Procedure Code.
        /// <para>Suggested: 0941 Procedure Code</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ProcedureCode { get; set; }

        /// <summary>
        /// DPS.3 - Effective Date/Time.
        /// </summary>
        public DateTime? EffectiveDateTime { get; set; }

        /// <summary>
        /// DPS.4 - Expiration Date/Time.
        /// </summary>
        public DateTime? ExpirationDateTime { get; set; }

        /// <summary>
        /// DPS.5 - Type of Limitation.
        /// <para>Suggested: 0940 Type of Limitation</para>
        /// </summary>
        public CodedWithNoExceptions TypeOfLimitation { get; set; }

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

            DiagnosisCodeMcp = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[1], false, seps) : null;
            ProcedureCode = segments.Length > 2 && segments[2].Length > 0 ? segments[2].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            EffectiveDateTime = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDateTime() : null;
            ExpirationDateTime = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            TypeOfLimitation = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[5], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 6, Configuration.FieldSeparator),
                                Id,
                                DiagnosisCodeMcp?.ToDelimitedString(),
                                ProcedureCode != null ? string.Join(Configuration.FieldRepeatSeparator, ProcedureCode.Select(x => x.ToDelimitedString())) : null,
                                EffectiveDateTime?.ToHl7DateTimeString(typeof(DpsSegment), nameof(EffectiveDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                ExpirationDateTime?.ToHl7DateTimeString(typeof(DpsSegment), nameof(ExpirationDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                TypeOfLimitation?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
