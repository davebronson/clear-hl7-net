using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment DPS - Diagnosis And Procedure Code.
    /// </summary>
    public class DpsSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "DPS";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
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

            DiagnosisCodeMcp = segments.Length > 1 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(1), false) : null;
            ProcedureCode = segments.Length > 2 ? segments.ElementAtOrDefault(2).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            EffectiveDateTime = segments.ElementAtOrDefault(3)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            ExpirationDateTime = segments.ElementAtOrDefault(4)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            TypeOfLimitation = segments.Length > 5 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(5), false) : null;
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
                                StringHelper.StringFormatSequence(0, 6, Configuration.FieldSeparator),
                                Id,
                                DiagnosisCodeMcp?.ToDelimitedString(),
                                ProcedureCode != null ? string.Join(Configuration.FieldRepeatSeparator, ProcedureCode.Select(x => x.ToDelimitedString())) : null,
                                EffectiveDateTime.HasValue ? EffectiveDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ExpirationDateTime.HasValue ? ExpirationDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                TypeOfLimitation?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}